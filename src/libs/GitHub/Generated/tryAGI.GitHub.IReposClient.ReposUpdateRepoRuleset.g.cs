#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Update a repository ruleset<br/>
        /// Update a ruleset for a repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="rulesetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.RepositoryRuleset> ReposUpdateRepoRulesetAsync(
            string owner,
            string repo,
            int rulesetId,

            global::tryAGI.GitHub.ReposUpdateRepoRulesetRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a repository ruleset<br/>
        /// Update a ruleset for a repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="rulesetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.RepositoryRuleset>> ReposUpdateRepoRulesetAsResponseAsync(
            string owner,
            string repo,
            int rulesetId,

            global::tryAGI.GitHub.ReposUpdateRepoRulesetRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a repository ruleset<br/>
        /// Update a ruleset for a repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="rulesetId"></param>
        /// <param name="name">
        /// The name of the ruleset.
        /// </param>
        /// <param name="target">
        /// The target of the ruleset
        /// </param>
        /// <param name="enforcement">
        /// The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).
        /// </param>
        /// <param name="bypassActors">
        /// The actors that can bypass the rules in this ruleset
        /// </param>
        /// <param name="conditions">
        /// Parameters for a repository ruleset ref name condition
        /// </param>
        /// <param name="rules">
        /// An array of rules within the ruleset.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.RepositoryRuleset> ReposUpdateRepoRulesetAsync(
            string owner,
            string repo,
            int rulesetId,
            string? name = default,
            global::tryAGI.GitHub.ReposUpdateRepoRulesetRequestTarget? target = default,
            global::tryAGI.GitHub.RepositoryRuleEnforcement? enforcement = default,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.RepositoryRulesetBypassActor>? bypassActors = default,
            global::tryAGI.GitHub.RepositoryRulesetConditions? conditions = default,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.RepositoryRule>? rules = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}