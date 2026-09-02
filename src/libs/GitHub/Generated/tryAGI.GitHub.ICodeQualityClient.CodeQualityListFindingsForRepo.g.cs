#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICodeQualityClient
    {
        /// <summary>
        /// List code quality findings for a repository<br/>
        /// Lists code quality findings for a repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="state"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.CodeQualityFinding>> CodeQualityListFindingsForRepoAsync(
            string owner,
            string repo,
            int? perPage = default,
            global::tryAGI.GitHub.CodeQualityListFindingsForRepoDirection? direction = default,
            string? before = default,
            string? after = default,
            global::tryAGI.GitHub.CodeQualityListFindingsForRepoState? state = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List code quality findings for a repository<br/>
        /// Lists code quality findings for a repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="state"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.CodeQualityFinding>>> CodeQualityListFindingsForRepoAsResponseAsync(
            string owner,
            string repo,
            int? perPage = default,
            global::tryAGI.GitHub.CodeQualityListFindingsForRepoDirection? direction = default,
            string? before = default,
            string? after = default,
            global::tryAGI.GitHub.CodeQualityListFindingsForRepoState? state = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}