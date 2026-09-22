# tryAGI.GitHub
Generated .NET SDK for the GitHub REST API, built from GitHub's official OpenAPI description with [AutoSDK](https://github.com/tryAGI/AutoSDK).

[![Nuget package](https://img.shields.io/nuget/vpre/tryAGI.GitHub)](https://www.nuget.org/packages/tryAGI.GitHub/)
[![dotnet](https://github.com/tryAGI/GitHub.NET/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/GitHub.NET/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/GitHub.NET)](https://github.com/tryAGI/GitHub.NET/blob/main/LICENSE.txt)

## Features 🔥
- Fully generated C# SDK based on the [official GitHub REST OpenAPI specification](https://github.com/github/rest-api-description) using [AutoSDK](https://github.com/tryAGI/AutoSDK)
- Request-level headers, cancellation, retries, response headers, ETags, and RFC 5988 Link pagination
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes

### Usage
```csharp
using tryAGI.GitHub;

using var httpClient = new HttpClient { BaseAddress = new Uri("https://api.github.com/") };
httpClient.DefaultRequestHeaders.Authorization =
    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey);
var api = new GitHubClient(httpClient);

var issue = await api.Issues.IssuesGetAsync("HavenDV", "Advantage", 475);
```

## Modular package canary

The [package family canary](.github/workflows/package-family-canary.yml) generates
`Core`, tag packages such as `Issues`, and the aggregate `tryAGI.GitHub` package
from the checked-in OpenAPI specification. It builds and packs the family, then
restores focused and aggregate consumers from the local package feed. Run the
same check locally with `scripts/test-package-family.sh` after installing the
pinned AutoSDK CLI version shown in the workflow. The canary does not publish
packages.

## Support

Priority place for bugs: https://github.com/tryAGI/AutoSDK/issues
Priority place for ideas and general questions: https://github.com/tryAGI/AutoSDK/discussions
