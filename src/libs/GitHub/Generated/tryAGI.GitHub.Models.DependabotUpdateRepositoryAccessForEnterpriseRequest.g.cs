
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Example: {"repository_ids_to_add":[123,456],"repository_ids_to_remove":[789]}
    /// </summary>
    public sealed partial class DependabotUpdateRepositoryAccessForEnterpriseRequest
    {
        /// <summary>
        /// List of repository IDs to add.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_ids_to_add")]
        public global::System.Collections.Generic.IList<int>? RepositoryIdsToAdd { get; set; }

        /// <summary>
        /// List of repository IDs to remove.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_ids_to_remove")]
        public global::System.Collections.Generic.IList<int>? RepositoryIdsToRemove { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotUpdateRepositoryAccessForEnterpriseRequest" /> class.
        /// </summary>
        /// <param name="repositoryIdsToAdd">
        /// List of repository IDs to add.
        /// </param>
        /// <param name="repositoryIdsToRemove">
        /// List of repository IDs to remove.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DependabotUpdateRepositoryAccessForEnterpriseRequest(
            global::System.Collections.Generic.IList<int>? repositoryIdsToAdd,
            global::System.Collections.Generic.IList<int>? repositoryIdsToRemove)
        {
            this.RepositoryIdsToAdd = repositoryIdsToAdd;
            this.RepositoryIdsToRemove = repositoryIdsToRemove;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotUpdateRepositoryAccessForEnterpriseRequest" /> class.
        /// </summary>
        public DependabotUpdateRepositoryAccessForEnterpriseRequest()
        {
        }

    }
}