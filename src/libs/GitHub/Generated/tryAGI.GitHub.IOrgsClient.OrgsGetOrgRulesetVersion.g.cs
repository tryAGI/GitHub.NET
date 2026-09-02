#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get organization ruleset version<br/>
        /// Get a version of an organization ruleset.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="rulesetId"></param>
        /// <param name="versionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.RulesetVersionWithState> OrgsGetOrgRulesetVersionAsync(
            string org,
            int rulesetId,
            int versionId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get organization ruleset version<br/>
        /// Get a version of an organization ruleset.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="rulesetId"></param>
        /// <param name="versionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.RulesetVersionWithState>> OrgsGetOrgRulesetVersionAsResponseAsync(
            string org,
            int rulesetId,
            int versionId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}