#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Update issue field for an organization<br/>
        /// Updates an issue field for an organization.<br/>
        /// You can find out more about issue fields in [Managing issue fields in an organization](https://docs.github.com/issues/tracking-your-work-with-issues/using-issues/managing-issue-fields-in-an-organization).<br/>
        /// To use this endpoint, the authenticated user must be an administrator for the organization. OAuth app tokens and<br/>
        /// personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="issueFieldId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.IssueField> OrgsUpdateIssueFieldAsync(
            string org,
            int issueFieldId,

            global::tryAGI.GitHub.OrganizationUpdateIssueField request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update issue field for an organization<br/>
        /// Updates an issue field for an organization.<br/>
        /// You can find out more about issue fields in [Managing issue fields in an organization](https://docs.github.com/issues/tracking-your-work-with-issues/using-issues/managing-issue-fields-in-an-organization).<br/>
        /// To use this endpoint, the authenticated user must be an administrator for the organization. OAuth app tokens and<br/>
        /// personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="issueFieldId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.IssueField>> OrgsUpdateIssueFieldAsResponseAsync(
            string org,
            int issueFieldId,

            global::tryAGI.GitHub.OrganizationUpdateIssueField request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update issue field for an organization<br/>
        /// Updates an issue field for an organization.<br/>
        /// You can find out more about issue fields in [Managing issue fields in an organization](https://docs.github.com/issues/tracking-your-work-with-issues/using-issues/managing-issue-fields-in-an-organization).<br/>
        /// To use this endpoint, the authenticated user must be an administrator for the organization. OAuth app tokens and<br/>
        /// personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="issueFieldId"></param>
        /// <param name="name">
        /// Name of the issue field.
        /// </param>
        /// <param name="description">
        /// Description of the issue field.
        /// </param>
        /// <param name="visibility">
        /// The visibility of the issue field. Can be `organization_members_only` (visible only within the organization) or `all` (visible to all users who can see issues). Only used when the visibility settings feature is enabled.
        /// </param>
        /// <param name="options">
        /// Options for select fields. Only applicable when updating single_select or multi_select fields. When provided, this array **replaces** the entire existing set of options rather than adding to or updating individual options. To retain or update an existing option, include it in the array with its `id`. Options sent without an `id` are treated as new options and may cause existing options to be deleted and recreated.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.IssueField> OrgsUpdateIssueFieldAsync(
            string org,
            int issueFieldId,
            string? name = default,
            string? description = default,
            global::tryAGI.GitHub.OrganizationUpdateIssueFieldVisibility? visibility = default,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrganizationUpdateIssueFieldOption>? options = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}