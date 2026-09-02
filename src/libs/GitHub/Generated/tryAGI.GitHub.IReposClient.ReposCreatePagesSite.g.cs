#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Create a GitHub Pages site<br/>
        /// Configures a GitHub Pages site. For more information, see "[About GitHub Pages](/github/working-with-github-pages/about-github-pages)."<br/>
        /// The authenticated user must be a repository administrator, maintainer, or have the 'manage GitHub Pages settings' permission.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.Page> ReposCreatePagesSiteAsync(
            string owner,
            string repo,

            global::tryAGI.GitHub.ReposCreatePagesSiteRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a GitHub Pages site<br/>
        /// Configures a GitHub Pages site. For more information, see "[About GitHub Pages](/github/working-with-github-pages/about-github-pages)."<br/>
        /// The authenticated user must be a repository administrator, maintainer, or have the 'manage GitHub Pages settings' permission.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.Page>> ReposCreatePagesSiteAsResponseAsync(
            string owner,
            string repo,

            global::tryAGI.GitHub.ReposCreatePagesSiteRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a GitHub Pages site<br/>
        /// Configures a GitHub Pages site. For more information, see "[About GitHub Pages](/github/working-with-github-pages/about-github-pages)."<br/>
        /// The authenticated user must be a repository administrator, maintainer, or have the 'manage GitHub Pages settings' permission.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="buildType">
        /// The process in which the Page will be built. Possible values are `"legacy"` and `"workflow"`.
        /// </param>
        /// <param name="source">
        /// The source branch and directory used to publish your Pages site.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.Page> ReposCreatePagesSiteAsync(
            string owner,
            string repo,
            global::tryAGI.GitHub.ReposCreatePagesSiteRequestBuildType? buildType = default,
            global::tryAGI.GitHub.ReposCreatePagesSiteRequestSource? source = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}