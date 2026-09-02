#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ISecretScanningClient
    {
        /// <summary>
        /// Update a secret scanning alert<br/>
        /// Updates the status of a secret scanning alert in an eligible repository.<br/>
        /// You can also use this endpoint to assign or unassign an alert to a user who has write access to the repository.<br/>
        /// The authenticated user must be an administrator for the repository or for the organization that owns the repository to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber">
        /// The security alert number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.SecretScanningAlertWithMetadata> SecretScanningUpdateAlertAsync(
            string owner,
            string repo,
            int alertNumber,

            global::tryAGI.GitHub.SecretScanningUpdateAlertRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a secret scanning alert<br/>
        /// Updates the status of a secret scanning alert in an eligible repository.<br/>
        /// You can also use this endpoint to assign or unassign an alert to a user who has write access to the repository.<br/>
        /// The authenticated user must be an administrator for the repository or for the organization that owns the repository to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber">
        /// The security alert number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.SecretScanningAlertWithMetadata>> SecretScanningUpdateAlertAsResponseAsync(
            string owner,
            string repo,
            int alertNumber,

            global::tryAGI.GitHub.SecretScanningUpdateAlertRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a secret scanning alert<br/>
        /// Updates the status of a secret scanning alert in an eligible repository.<br/>
        /// You can also use this endpoint to assign or unassign an alert to a user who has write access to the repository.<br/>
        /// The authenticated user must be an administrator for the repository or for the organization that owns the repository to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber">
        /// The security alert number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// Sets the state of the secret scanning alert. You must provide `resolution` when you set the state to `resolved`.
        /// </param>
        /// <param name="resolution">
        /// **Required when the `state` is `resolved`.** The reason for resolving the alert.
        /// </param>
        /// <param name="resolutionComment">
        /// An optional comment when closing or reopening an alert. Cannot be updated or deleted.
        /// </param>
        /// <param name="assignee">
        /// The username of the user to assign to the alert. Set to `null` to unassign the alert.
        /// </param>
        /// <param name="validity">
        /// Sets the validity of the secret scanning alert. Can be `active`, `inactive`, or `null` to clear the override.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.SecretScanningAlertWithMetadata> SecretScanningUpdateAlertAsync(
            string owner,
            string repo,
            int alertNumber,
            global::tryAGI.GitHub.SecretScanningAlertState? state = default,
            global::tryAGI.GitHub.SecretScanningAlertResolution? resolution = default,
            string? resolutionComment = default,
            string? assignee = default,
            global::tryAGI.GitHub.SecretScanningUpdateAlertRequestValidity? validity = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}