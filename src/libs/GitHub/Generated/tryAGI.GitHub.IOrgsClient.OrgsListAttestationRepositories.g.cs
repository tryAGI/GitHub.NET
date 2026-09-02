#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List attestation repositories<br/>
        /// List repositories owned by the provided organization that have created at least one attested artifact<br/>
        /// Results will be sorted in ascending order by repository ID
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="org"></param>
        /// <param name="predicateType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrgsListAttestationRepositoriesResponseItem>> OrgsListAttestationRepositoriesAsync(
            string org,
            int? perPage = default,
            string? before = default,
            string? after = default,
            string? predicateType = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List attestation repositories<br/>
        /// List repositories owned by the provided organization that have created at least one attested artifact<br/>
        /// Results will be sorted in ascending order by repository ID
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="org"></param>
        /// <param name="predicateType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrgsListAttestationRepositoriesResponseItem>>> OrgsListAttestationRepositoriesAsResponseAsync(
            string org,
            int? perPage = default,
            string? before = default,
            string? after = default,
            string? predicateType = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}