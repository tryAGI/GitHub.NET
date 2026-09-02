#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Create issue field for an organization<br/>
        /// Creates a new issue field for an organization.<br/>
        /// You can find out more about issue fields in [Managing issue fields in an organization](https://docs.github.com/issues/tracking-your-work-with-issues/using-issues/managing-issue-fields-in-an-organization).<br/>
        /// To use this endpoint, the authenticated user must be an administrator for the organization. OAuth app tokens and<br/>
        /// personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.IssueField> OrgsCreateIssueFieldAsync(
            string org,

            global::tryAGI.GitHub.OrganizationCreateIssueField request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create issue field for an organization<br/>
        /// Creates a new issue field for an organization.<br/>
        /// You can find out more about issue fields in [Managing issue fields in an organization](https://docs.github.com/issues/tracking-your-work-with-issues/using-issues/managing-issue-fields-in-an-organization).<br/>
        /// To use this endpoint, the authenticated user must be an administrator for the organization. OAuth app tokens and<br/>
        /// personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.IssueField>> OrgsCreateIssueFieldAsResponseAsync(
            string org,

            global::tryAGI.GitHub.OrganizationCreateIssueField request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create issue field for an organization<br/>
        /// Creates a new issue field for an organization.<br/>
        /// You can find out more about issue fields in [Managing issue fields in an organization](https://docs.github.com/issues/tracking-your-work-with-issues/using-issues/managing-issue-fields-in-an-organization).<br/>
        /// To use this endpoint, the authenticated user must be an administrator for the organization. OAuth app tokens and<br/>
        /// personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name">
        /// Name of the issue field.
        /// </param>
        /// <param name="description">
        /// Description of the issue field.
        /// </param>
        /// <param name="dataType">
        /// The data type of the issue field.
        /// </param>
        /// <param name="visibility">
        /// The visibility of the issue field. Can be `organization_members_only` (visible only within the organization) or `all` (visible to all users who can see issues). Only used when the visibility settings feature is enabled. Defaults to `organization_members_only`.
        /// </param>
        /// <param name="options">
        /// Options for select fields. Required when data_type is 'single_select' or 'multi_select'.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.IssueField> OrgsCreateIssueFieldAsync(
            string org,
            string name,
            global::tryAGI.GitHub.OrganizationCreateIssueFieldDataType dataType,
            string? description = default,
            global::tryAGI.GitHub.OrganizationCreateIssueFieldVisibility? visibility = default,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrganizationCreateIssueFieldOption>? options = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}