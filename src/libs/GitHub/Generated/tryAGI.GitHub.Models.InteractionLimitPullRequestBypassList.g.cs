
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A list of user logins to add or remove from the pull request creation cap bypass list.
    /// </summary>
    public sealed partial class InteractionLimitPullRequestBypassList
    {
        /// <summary>
        /// A list of user logins to add or remove from the bypass list.<br/>
        /// Example: [octocat, monalisa]
        /// </summary>
        /// <example>[octocat, monalisa]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionLimitPullRequestBypassList" /> class.
        /// </summary>
        /// <param name="users">
        /// A list of user logins to add or remove from the bypass list.<br/>
        /// Example: [octocat, monalisa]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InteractionLimitPullRequestBypassList(
            global::System.Collections.Generic.IList<string> users)
        {
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionLimitPullRequestBypassList" /> class.
        /// </summary>
        public InteractionLimitPullRequestBypassList()
        {
        }

    }
}