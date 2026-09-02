#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IEnterpriseTeamsClient
    {
        /// <summary>
        /// Get an enterprise team<br/>
        /// Gets a team using the team's slug. To create the slug, GitHub replaces special characters in the name string, changes all words to lowercase, and replaces spaces with a `-` separator and adds the "ent:" prefix. For example, "My TEam Näme" would become `ent:my-team-name`.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="teamSlug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.EnterpriseTeamWithMemberCount> EnterpriseTeamsGetAsync(
            string enterprise,
            string teamSlug,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an enterprise team<br/>
        /// Gets a team using the team's slug. To create the slug, GitHub replaces special characters in the name string, changes all words to lowercase, and replaces spaces with a `-` separator and adds the "ent:" prefix. For example, "My TEam Näme" would become `ent:my-team-name`.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="teamSlug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.EnterpriseTeamWithMemberCount>> EnterpriseTeamsGetAsResponseAsync(
            string enterprise,
            string teamSlug,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}