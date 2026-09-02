#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Create or update custom property values for a repository<br/>
        /// Create new or update existing custom property values for a repository.<br/>
        /// Using a value of `null` for a custom property will remove or 'unset' the property value from the repository.<br/>
        /// Repository admins and other users with the repository-level "edit custom property values" fine-grained permission can use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ReposCustomPropertiesForReposCreateOrUpdateRepositoryValuesAsync(
            string owner,
            string repo,

            global::tryAGI.GitHub.ReposCustomPropertiesForReposCreateOrUpdateRepositoryValuesRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update custom property values for a repository<br/>
        /// Create new or update existing custom property values for a repository.<br/>
        /// Using a value of `null` for a custom property will remove or 'unset' the property value from the repository.<br/>
        /// Repository admins and other users with the repository-level "edit custom property values" fine-grained permission can use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> ReposCustomPropertiesForReposCreateOrUpdateRepositoryValuesAsResponseAsync(
            string owner,
            string repo,

            global::tryAGI.GitHub.ReposCustomPropertiesForReposCreateOrUpdateRepositoryValuesRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update custom property values for a repository<br/>
        /// Create new or update existing custom property values for a repository.<br/>
        /// Using a value of `null` for a custom property will remove or 'unset' the property value from the repository.<br/>
        /// Repository admins and other users with the repository-level "edit custom property values" fine-grained permission can use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="properties">
        /// A list of custom property names and associated values to apply to the repositories.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ReposCustomPropertiesForReposCreateOrUpdateRepositoryValuesAsync(
            string owner,
            string repo,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.CustomPropertyValue> properties,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}