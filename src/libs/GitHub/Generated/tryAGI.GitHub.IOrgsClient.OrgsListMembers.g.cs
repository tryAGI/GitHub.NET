#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List organization members<br/>
        /// List all users who are members of an organization. If the authenticated user is also a member of this organization then both concealed and public members will be returned.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="filter">
        /// Default Value: all
        /// </param>
        /// <param name="role">
        /// Default Value: all
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.SimpleUser>> OrgsListMembersAsync(
            string org,
            global::tryAGI.GitHub.OrgsListMembersFilter? filter = default,
            global::tryAGI.GitHub.OrgsListMembersRole? role = default,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List organization members<br/>
        /// List all users who are members of an organization. If the authenticated user is also a member of this organization then both concealed and public members will be returned.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="filter">
        /// Default Value: all
        /// </param>
        /// <param name="role">
        /// Default Value: all
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.SimpleUser>>> OrgsListMembersAsResponseAsync(
            string org,
            global::tryAGI.GitHub.OrgsListMembersFilter? filter = default,
            global::tryAGI.GitHub.OrgsListMembersRole? role = default,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}