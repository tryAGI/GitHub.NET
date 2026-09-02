using System.Net;
using System.Text;
using tryAGI.GitHub;

namespace GitHub.IntegrationTests;

[TestClass]
public sealed class IssueExtensionsTests
{
    [TestMethod]
    public void AuthenticatedRequestOptions_AreRequestScoped()
    {
        var options = GitHubRequestOptions.CreateAuthenticated("token", "Bearer");

        options.Headers["Authorization"].Should().Be("Bearer token");
        options.Headers["Accept"].Should().Be("application/vnd.github+json");
        options.Headers["X-GitHub-Api-Version"].Should().Be("2022-11-28");
    }

    [TestMethod]
    public async Task ConditionalIssueRead_MapsNotModifiedAndPreservesEtag()
    {
        using var handler = new DelegateHandler(request =>
        {
            request.Headers.IfNoneMatch.Single().Tag.Should().Be("\"issues-v1\"");
            request.RequestUri!.PathAndQuery.Should().Be(
                "/repos/HavenDV/Advantage/issues?state=all&sort=updated&direction=desc&per_page=100&page=1");
            var response = new HttpResponseMessage(HttpStatusCode.NotModified);
            response.Headers.ETag = new System.Net.Http.Headers.EntityTagHeaderValue("\"issues-v1\"");
            return response;
        });
        using var httpClient = new HttpClient(handler) { BaseAddress = new Uri("https://api.github.com/") };
        using var client = new IssuesClient(httpClient, disposeHttpClient: false);

        var snapshot = await client.ListRepositoryIssuesConditionalAsync(
            "HavenDV",
            "Advantage",
            "\"issues-v1\"");

        snapshot.NotModified.Should().BeTrue();
        snapshot.EntityTag.Should().Be("\"issues-v1\"");
        snapshot.Issues.Should().BeEmpty();
    }

    [TestMethod]
    public async Task MarkerScan_ReturnsIssuesAndSkipsPullRequests()
    {
        const string marker = "<!-- advantage-improvement:475 -->";
        using var handler = new DelegateHandler(request =>
        {
            request.RequestUri!.PathAndQuery.Should().Be(
                "/repos/HavenDV/Advantage/issues?state=all&sort=updated&direction=desc&per_page=100&page=1");
            return Json(HttpStatusCode.OK, $$"""
                [
                  {
                    "id": 42,
                    "node_id": "I_42",
                    "url": "https://api.github.com/repos/HavenDV/Advantage/issues/42",
                    "repository_url": "https://api.github.com/repos/HavenDV/Advantage",
                    "labels_url": "https://api.github.com/repos/HavenDV/Advantage/issues/42/labels{/name}",
                    "comments_url": "https://api.github.com/repos/HavenDV/Advantage/issues/42/comments",
                    "events_url": "https://api.github.com/repos/HavenDV/Advantage/issues/42/events",
                    "html_url": "https://github.com/HavenDV/Advantage/issues/42",
                    "number": 42,
                    "state": "open",
                    "title": "Issue",
                    "body": "{{marker}}",
                    "labels": [],
                    "locked": false,
                    "comments": 0,
                    "created_at": "2026-09-01T00:00:00Z",
                    "updated_at": "2026-09-01T00:00:00Z"
                  },
                  {
                    "id": 43,
                    "node_id": "PR_43",
                    "url": "https://api.github.com/repos/HavenDV/Advantage/issues/43",
                    "repository_url": "https://api.github.com/repos/HavenDV/Advantage",
                    "labels_url": "https://api.github.com/repos/HavenDV/Advantage/issues/43/labels{/name}",
                    "comments_url": "https://api.github.com/repos/HavenDV/Advantage/issues/43/comments",
                    "events_url": "https://api.github.com/repos/HavenDV/Advantage/issues/43/events",
                    "html_url": "https://github.com/HavenDV/Advantage/pull/43",
                    "number": 43,
                    "state": "open",
                    "title": "Pull request",
                    "body": "{{marker}}",
                    "labels": [],
                    "locked": false,
                    "comments": 0,
                    "pull_request": {
                      "url": "https://api.github.com/repos/HavenDV/Advantage/pulls/43",
                      "html_url": "https://github.com/HavenDV/Advantage/pull/43",
                      "diff_url": "https://github.com/HavenDV/Advantage/pull/43.diff",
                      "patch_url": "https://github.com/HavenDV/Advantage/pull/43.patch"
                    },
                    "created_at": "2026-09-01T00:00:00Z",
                    "updated_at": "2026-09-01T00:00:00Z"
                  }
                ]
                """);
        });
        using var httpClient = new HttpClient(handler) { BaseAddress = new Uri("https://api.github.com/") };
        using var client = new IssuesClient(httpClient, disposeHttpClient: false);

        var issues = await client.FindIssuesByMarkerAsync("HavenDV", "Advantage", marker);

        issues.Select(static issue => issue.Number).Should().Equal(42);
    }

    private static HttpResponseMessage Json(HttpStatusCode statusCode, string json) => new(statusCode)
    {
        Content = new StringContent(json, Encoding.UTF8, "application/json"),
    };

    private sealed class DelegateHandler(Func<HttpRequestMessage, HttpResponseMessage> handle) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken) => Task.FromResult(handle(request));
    }
}
