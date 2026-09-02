#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ISecretScanningClient
    {
        /// <summary>
        /// List organization custom patterns<br/>
        /// Lists secret scanning custom patterns for an organization.<br/>
        /// Personal access tokens (classic) need the `read:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="state"></param>
        /// <param name="pushProtection"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningCustomPattern>> SecretScanningListOrgCustomPatternsAsync(
            string org,
            global::tryAGI.GitHub.SecretScanningListOrgCustomPatternsState? state = default,
            global::tryAGI.GitHub.SecretScanningListOrgCustomPatternsPushProtection? pushProtection = default,
            global::tryAGI.GitHub.SecretScanningListOrgCustomPatternsSort? sort = default,
            global::tryAGI.GitHub.SecretScanningListOrgCustomPatternsDirection? direction = default,
            string? before = default,
            string? after = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List organization custom patterns<br/>
        /// Lists secret scanning custom patterns for an organization.<br/>
        /// Personal access tokens (classic) need the `read:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="state"></param>
        /// <param name="pushProtection"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningCustomPattern>>> SecretScanningListOrgCustomPatternsAsResponseAsync(
            string org,
            global::tryAGI.GitHub.SecretScanningListOrgCustomPatternsState? state = default,
            global::tryAGI.GitHub.SecretScanningListOrgCustomPatternsPushProtection? pushProtection = default,
            global::tryAGI.GitHub.SecretScanningListOrgCustomPatternsSort? sort = default,
            global::tryAGI.GitHub.SecretScanningListOrgCustomPatternsDirection? direction = default,
            string? before = default,
            string? after = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}