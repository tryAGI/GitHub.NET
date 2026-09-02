#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Update a release asset<br/>
        /// Users with push access to the repository can edit a release asset.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="assetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ReleaseAsset> ReposUpdateReleaseAssetAsync(
            string owner,
            string repo,
            int assetId,

            global::tryAGI.GitHub.ReposUpdateReleaseAssetRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a release asset<br/>
        /// Users with push access to the repository can edit a release asset.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="assetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ReleaseAsset>> ReposUpdateReleaseAssetAsResponseAsync(
            string owner,
            string repo,
            int assetId,

            global::tryAGI.GitHub.ReposUpdateReleaseAssetRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a release asset<br/>
        /// Users with push access to the repository can edit a release asset.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="assetId"></param>
        /// <param name="name">
        /// The file name of the asset.
        /// </param>
        /// <param name="label">
        /// An alternate short description of the asset. Used in place of the filename.
        /// </param>
        /// <param name="state">
        /// Example: "uploaded"
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ReleaseAsset> ReposUpdateReleaseAssetAsync(
            string owner,
            string repo,
            int assetId,
            string? name = default,
            string? label = default,
            string? state = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}