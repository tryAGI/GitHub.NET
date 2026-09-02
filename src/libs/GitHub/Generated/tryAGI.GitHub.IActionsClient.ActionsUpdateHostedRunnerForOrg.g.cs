#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Update a GitHub-hosted runner for an organization<br/>
        /// Updates a GitHub-hosted runner for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `manage_runners:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="hostedRunnerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ActionsHostedRunner> ActionsUpdateHostedRunnerForOrgAsync(
            string org,
            int hostedRunnerId,

            global::tryAGI.GitHub.ActionsUpdateHostedRunnerForOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a GitHub-hosted runner for an organization<br/>
        /// Updates a GitHub-hosted runner for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `manage_runners:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="hostedRunnerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ActionsHostedRunner>> ActionsUpdateHostedRunnerForOrgAsResponseAsync(
            string org,
            int hostedRunnerId,

            global::tryAGI.GitHub.ActionsUpdateHostedRunnerForOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a GitHub-hosted runner for an organization<br/>
        /// Updates a GitHub-hosted runner for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `manage_runners:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="hostedRunnerId"></param>
        /// <param name="name">
        /// Name of the runner. Must be between 1 and 64 characters and may only contain upper and lowercase letters a-z, numbers 0-9, '.', '-', and '_'.
        /// </param>
        /// <param name="runnerGroupId">
        /// The existing runner group to add this runner to.
        /// </param>
        /// <param name="maximumRunners">
        /// The maximum amount of runners to scale up to. Runners will not auto-scale above this number. Use this setting to limit your cost.
        /// </param>
        /// <param name="enableStaticIp">
        /// Whether this runner should be updated with a static public IP. Note limit on account. To list limits on account, use `GET actions/hosted-runners/limits`
        /// </param>
        /// <param name="size">
        /// The machine size of the runner. To list available sizes, use `GET actions/hosted-runners/machine-sizes`
        /// </param>
        /// <param name="imageSource">
        /// The source type of the runner image to use. Must match the source of the image specified by `image_id`. Can be one of `github`, `partner`, or `custom`.
        /// </param>
        /// <param name="imageId">
        /// The unique identifier of the runner image. To list available images, use `GET /actions/hosted-runners/images/github-owned`, `GET /actions/hosted-runners/images/partner`, or `GET /actions/hosted-runners/images/custom`.
        /// </param>
        /// <param name="imageVersion">
        /// The version of the runner image to deploy. This is relevant only for runners using custom images.
        /// </param>
        /// <param name="imageGen">
        /// Whether to enable image generation for this runner pool. When enabled, the runner pool is used to build and publish custom runner images.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ActionsHostedRunner> ActionsUpdateHostedRunnerForOrgAsync(
            string org,
            int hostedRunnerId,
            string? name = default,
            int? runnerGroupId = default,
            int? maximumRunners = default,
            bool? enableStaticIp = default,
            string? size = default,
            global::tryAGI.GitHub.ActionsUpdateHostedRunnerForOrgRequestImageSource? imageSource = default,
            string? imageId = default,
            string? imageVersion = default,
            bool? imageGen = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}