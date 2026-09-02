#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ISecretScanningClient
    {
        /// <summary>
        /// List secret scanning alerts for an organization<br/>
        /// Lists secret scanning alerts for eligible repositories in an organization, from newest to oldest.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="state"></param>
        /// <param name="secretType"></param>
        /// <param name="excludeSecretTypes"></param>
        /// <param name="excludeProviders"></param>
        /// <param name="providers"></param>
        /// <param name="resolution"></param>
        /// <param name="assignee"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="validity"></param>
        /// <param name="isPubliclyLeaked">
        /// Default Value: false
        /// </param>
        /// <param name="isMultiRepo">
        /// Default Value: false
        /// </param>
        /// <param name="hideSecret">
        /// Default Value: false
        /// </param>
        /// <param name="isBypassed"></param>
        /// <param name="includedMetadata"></param>
        /// <param name="ownerEmailHash"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrganizationSecretScanningAlert>> SecretScanningListAlertsForOrgAsync(
            string org,
            global::tryAGI.GitHub.SecretScanningListAlertsForOrgState? state = default,
            string? secretType = default,
            string? excludeSecretTypes = default,
            string? excludeProviders = default,
            string? providers = default,
            string? resolution = default,
            string? assignee = default,
            global::tryAGI.GitHub.SecretScanningListAlertsForOrgSort? sort = default,
            global::tryAGI.GitHub.SecretScanningListAlertsForOrgDirection? direction = default,
            int? page = default,
            int? perPage = default,
            string? before = default,
            string? after = default,
            string? validity = default,
            bool? isPubliclyLeaked = default,
            bool? isMultiRepo = default,
            bool? hideSecret = default,
            bool? isBypassed = default,
            string? includedMetadata = default,
            string? ownerEmailHash = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List secret scanning alerts for an organization<br/>
        /// Lists secret scanning alerts for eligible repositories in an organization, from newest to oldest.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="state"></param>
        /// <param name="secretType"></param>
        /// <param name="excludeSecretTypes"></param>
        /// <param name="excludeProviders"></param>
        /// <param name="providers"></param>
        /// <param name="resolution"></param>
        /// <param name="assignee"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="validity"></param>
        /// <param name="isPubliclyLeaked">
        /// Default Value: false
        /// </param>
        /// <param name="isMultiRepo">
        /// Default Value: false
        /// </param>
        /// <param name="hideSecret">
        /// Default Value: false
        /// </param>
        /// <param name="isBypassed"></param>
        /// <param name="includedMetadata"></param>
        /// <param name="ownerEmailHash"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrganizationSecretScanningAlert>>> SecretScanningListAlertsForOrgAsResponseAsync(
            string org,
            global::tryAGI.GitHub.SecretScanningListAlertsForOrgState? state = default,
            string? secretType = default,
            string? excludeSecretTypes = default,
            string? excludeProviders = default,
            string? providers = default,
            string? resolution = default,
            string? assignee = default,
            global::tryAGI.GitHub.SecretScanningListAlertsForOrgSort? sort = default,
            global::tryAGI.GitHub.SecretScanningListAlertsForOrgDirection? direction = default,
            int? page = default,
            int? perPage = default,
            string? before = default,
            string? after = default,
            string? validity = default,
            bool? isPubliclyLeaked = default,
            bool? isMultiRepo = default,
            bool? hideSecret = default,
            bool? isBypassed = default,
            string? includedMetadata = default,
            string? ownerEmailHash = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}