dotnet tool update --global autosdk.cli --version 0.34.2
curl --fail --location --output openapi.yaml https://raw.githubusercontent.com/github/rest-api-description/main/descriptions/api.github.com/api.github.com.yaml
autosdk generate openapi.yaml \
  --namespace tryAGI.GitHub \
  --clientClassName GitHubClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --generate-http-exception-hierarchy \
  --generate-pageable-helpers \
  --generate-retry-handler \
  --use-system-net-http-json \
  --clean-stale-files
