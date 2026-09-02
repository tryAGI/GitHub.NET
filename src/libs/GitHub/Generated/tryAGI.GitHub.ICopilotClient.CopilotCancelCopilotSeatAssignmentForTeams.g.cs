#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Remove teams from the Copilot subscription for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Sets seats for all members of each team specified to "pending cancellation".<br/>
        /// This will cause the members of the specified team(s) to lose access to GitHub Copilot at the end of the current billing cycle unless they retain access through another team.<br/>
        /// For more information about disabling access to Copilot, see "[Revoking access to Copilot for members of your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-access-to-github-copilot-in-your-organization/revoking-access-to-copilot-for-members-of-your-organization)."<br/>
        /// Only organization owners can cancel Copilot seats for their organization members.<br/>
        /// The response contains the total number of seats set to "pending cancellation".<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotCancelCopilotSeatAssignmentForTeamsResponse> CopilotCancelCopilotSeatAssignmentForTeamsAsync(
            string org,

            global::tryAGI.GitHub.CopilotCancelCopilotSeatAssignmentForTeamsRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove teams from the Copilot subscription for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Sets seats for all members of each team specified to "pending cancellation".<br/>
        /// This will cause the members of the specified team(s) to lose access to GitHub Copilot at the end of the current billing cycle unless they retain access through another team.<br/>
        /// For more information about disabling access to Copilot, see "[Revoking access to Copilot for members of your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-access-to-github-copilot-in-your-organization/revoking-access-to-copilot-for-members-of-your-organization)."<br/>
        /// Only organization owners can cancel Copilot seats for their organization members.<br/>
        /// The response contains the total number of seats set to "pending cancellation".<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotCancelCopilotSeatAssignmentForTeamsResponse>> CopilotCancelCopilotSeatAssignmentForTeamsAsResponseAsync(
            string org,

            global::tryAGI.GitHub.CopilotCancelCopilotSeatAssignmentForTeamsRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove teams from the Copilot subscription for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Sets seats for all members of each team specified to "pending cancellation".<br/>
        /// This will cause the members of the specified team(s) to lose access to GitHub Copilot at the end of the current billing cycle unless they retain access through another team.<br/>
        /// For more information about disabling access to Copilot, see "[Revoking access to Copilot for members of your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-access-to-github-copilot-in-your-organization/revoking-access-to-copilot-for-members-of-your-organization)."<br/>
        /// Only organization owners can cancel Copilot seats for their organization members.<br/>
        /// The response contains the total number of seats set to "pending cancellation".<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="selectedTeams">
        /// The names of teams from which to revoke access to GitHub Copilot.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotCancelCopilotSeatAssignmentForTeamsResponse> CopilotCancelCopilotSeatAssignmentForTeamsAsync(
            string org,
            global::System.Collections.Generic.IList<string> selectedTeams,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}