#!/usr/bin/env bash
set -euo pipefail

repo_root=$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)
spec="$repo_root/src/libs/GitHub/openapi.yaml"
version=0.11.0-canary.1

if [[ -n ${GITHUB_FAMILY_ROOT:-} ]]; then
  packages_root=$(cd "$GITHUB_FAMILY_ROOT" && pwd)
  scratch=$(dirname "$packages_root")
else
  scratch=$(mktemp -d "${RUNNER_TEMP:-/tmp}/github-package-family.XXXXXX")
  packages_root="$scratch/GeneratedPackages"
  "${AUTOSDK_CLI:-autosdk}" generate "$spec" \
    --namespace tryAGI.GitHub \
    --clientClassName GitHubClient \
    --targetFramework net8.0 \
    --output "$scratch" \
    --split-by-tags \
    --package-id tryAGI.GitHub \
    --exclude-deprecated-operations \
    --generate-http-exception-hierarchy \
    --generate-pageable-helpers \
    --generate-retry-handler \
    --use-system-net-http-json \
    --clean-stale-files
fi

solution="$packages_root/tryAGI.GitHub.slnx"
manifest="$packages_root/autosdk-packages.json"
issues="$packages_root/tryAGI.GitHub.Issues"
test -f "$solution"
test -f "$manifest"
test -d "$issues"

# Generated projects live outside src/libs, so carry the repository's package
# identity, signing and resource metadata into their common MSBuild parent.
cp "$repo_root/README.md" "$scratch/README.md"
cp "$repo_root/assets/nuget_icon.png" "$scratch/nuget_icon.png"
cp "$repo_root/src/key.snk" "$scratch/key.snk"
cat > "$scratch/Directory.Build.props" <<'EOF'
<Project>
  <PropertyGroup>
    <LangVersion>preview</LangVersion>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <SignAssembly>true</SignAssembly>
    <AssemblyOriginatorKeyFile>$(MSBuildThisFileDirectory)key.snk</AssemblyOriginatorKeyFile>
    <Authors>HavenDV</Authors>
    <PackageLicenseExpression>MIT</PackageLicenseExpression>
    <PackageIcon>nuget_icon.png</PackageIcon>
    <PackageReadmeFile>README.md</PackageReadmeFile>
    <RepositoryUrl>https://github.com/tryAGI/GitHub.NET</RepositoryUrl>
    <RepositoryType>git</RepositoryType>
    <PackageTags>api;client;sdk;dotnet;openapi;generated;github;rest;tryagi</PackageTags>
    <EnableNETAnalyzers>false</EnableNETAnalyzers>
    <RunAnalyzersDuringBuild>false</RunAnalyzersDuringBuild>
    <GenerateDocumentationFile>false</GenerateDocumentationFile>
    <DebugType>none</DebugType>
    <DebugSymbols>false</DebugSymbols>
  </PropertyGroup>
  <ItemGroup>
    <None Include="$(MSBuildThisFileDirectory)README.md" Pack="true" PackagePath="/" />
    <None Include="$(MSBuildThisFileDirectory)nuget_icon.png" Pack="true" PackagePath="/" />
  </ItemGroup>
</Project>
EOF

# This hand-written extension is part of the existing aggregate package API.
# The Issues package owns its methods and references Core for shared types.
cp "$repo_root/src/libs/GitHub/GitHubIssueExtensions.cs" "$issues/GitHubIssueExtensions.cs"

dotnet build "$solution" --configuration Release --maxcpucount:1 \
  -p:Version="$version" \
  -p:ProduceReferenceAssembly=false \
  -p:UseSharedCompilation=false

feed=$(mktemp -d "${RUNNER_TEMP:-/tmp}/github-package-feed.XXXXXX")
dotnet pack "$solution" --no-build --configuration Release --maxcpucount:1 \
  -p:Version="$version" \
  -p:ProduceReferenceAssembly=false \
  -p:EnablePackageValidation=true \
  -o "$feed"

python3 - "$manifest" "$feed" "$version" <<'PY'
import json
from pathlib import Path
import sys

manifest = json.loads(Path(sys.argv[1]).read_text(encoding="utf-8"))
feed = Path(sys.argv[2])
version = sys.argv[3]
expected = {entry["packageId"] for entry in manifest["packages"]}
actual = {path.name.removesuffix(f".{version}.nupkg") for path in feed.glob("*.nupkg")}
if expected != actual:
    raise SystemExit(f"Package mismatch: missing={sorted(expected - actual)}, extra={sorted(actual - expected)}")
print(f"Packed {len(actual)} packages from {len(expected)} manifest entries")
PY

for package in tryAGI.GitHub.Issues tryAGI.GitHub; do
  consumer=$(mktemp -d "${RUNNER_TEMP:-/tmp}/github-package-consumer.XXXXXX")
  cat > "$consumer/Consumer.csproj" <<EOF
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include="$package" Version="$version" />
  </ItemGroup>
</Project>
EOF
  if [[ $package == tryAGI.GitHub.Issues ]]; then
    cat > "$consumer/Program.cs" <<'EOF'
using tryAGI.GitHub;
using var client = new IssuesClient();
var options = GitHubRequestOptions.CreateAuthenticated("test-token");
Console.WriteLine($"{client.GetType().Name}: {options.Headers.Count}");
EOF
  else
    cat > "$consumer/Program.cs" <<'EOF'
using tryAGI.GitHub;
using var client = new GitHubClient();
Console.WriteLine(client.Issues.GetType().Name);
EOF
  fi
  cat > "$consumer/NuGet.Config" <<EOF
<configuration>
  <packageSources>
    <clear />
    <add key="family" value="$feed" />
    <add key="nuget.org" value="https://api.nuget.org/v3/index.json" />
  </packageSources>
  <packageSourceMapping>
    <packageSource key="family"><package pattern="tryAGI.GitHub*" /></packageSource>
    <packageSource key="nuget.org"><package pattern="*" /></packageSource>
  </packageSourceMapping>
</configuration>
EOF
  NUGET_PACKAGES="$consumer/packages" dotnet restore "$consumer/Consumer.csproj" --configfile "$consumer/NuGet.Config"
  NUGET_PACKAGES="$consumer/packages" dotnet run --project "$consumer/Consumer.csproj" --no-restore
done
