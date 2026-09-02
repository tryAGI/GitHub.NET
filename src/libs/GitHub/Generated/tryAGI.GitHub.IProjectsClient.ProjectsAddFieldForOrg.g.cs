#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Add a field to an organization-owned project.<br/>
        /// Add a field to an organization-owned project.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ProjectsV2Field> ProjectsAddFieldForOrgAsync(
            int projectNumber,
            string org,

            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.ProjectsAddFieldForOrgRequestVariant1, global::tryAGI.GitHub.ProjectsAddFieldForOrgRequestVariant2, global::tryAGI.GitHub.ProjectsAddFieldForOrgRequestVariant3, global::tryAGI.GitHub.ProjectsAddFieldForOrgRequestVariant4> request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a field to an organization-owned project.<br/>
        /// Add a field to an organization-owned project.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ProjectsV2Field>> ProjectsAddFieldForOrgAsResponseAsync(
            int projectNumber,
            string org,

            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.ProjectsAddFieldForOrgRequestVariant1, global::tryAGI.GitHub.ProjectsAddFieldForOrgRequestVariant2, global::tryAGI.GitHub.ProjectsAddFieldForOrgRequestVariant3, global::tryAGI.GitHub.ProjectsAddFieldForOrgRequestVariant4> request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a field to an organization-owned project.<br/>
        /// Add a field to an organization-owned project.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ProjectsV2Field> ProjectsAddFieldForOrgAsync(
            int projectNumber,
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}