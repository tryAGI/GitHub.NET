#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ISecretScanningClient
    {
        /// <summary>
        /// Update an organization custom pattern<br/>
        /// Updates a secret scanning custom pattern for an organization.<br/>
        /// Personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="patternId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.SecretScanningCustomPattern> SecretScanningUpdateOrgCustomPatternAsync(
            string org,
            int patternId,

            global::tryAGI.GitHub.SecretScanningCustomPatternToUpdate request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an organization custom pattern<br/>
        /// Updates a secret scanning custom pattern for an organization.<br/>
        /// Personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="patternId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.SecretScanningCustomPattern>> SecretScanningUpdateOrgCustomPatternAsResponseAsync(
            string org,
            int patternId,

            global::tryAGI.GitHub.SecretScanningCustomPatternToUpdate request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an organization custom pattern<br/>
        /// Updates a secret scanning custom pattern for an organization.<br/>
        /// Personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="patternId"></param>
        /// <param name="pattern">
        /// The updated regular expression of the custom pattern.
        /// </param>
        /// <param name="startDelimiter">
        /// The updated start delimiter regex for the custom pattern.
        /// </param>
        /// <param name="endDelimiter">
        /// The updated end delimiter regex for the custom pattern.
        /// </param>
        /// <param name="mustMatch">
        /// Updated list of regexes that the secret must match.
        /// </param>
        /// <param name="mustNotMatch">
        /// Updated list of regexes that the secret must not match.
        /// </param>
        /// <param name="customPatternVersion">
        /// The version of the entity. This is used to confirm you're updating the current version of the entity and mitigate unintentionally overriding someone else's update.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.SecretScanningCustomPattern> SecretScanningUpdateOrgCustomPatternAsync(
            string org,
            int patternId,
            string? pattern = default,
            string? startDelimiter = default,
            string? endDelimiter = default,
            global::System.Collections.Generic.IList<string>? mustMatch = default,
            global::System.Collections.Generic.IList<string>? mustNotMatch = default,
            string? customPatternVersion = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}