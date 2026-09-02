
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EnterpriseTeamOrganizationsBulkRemoveRequest
    {
        /// <summary>
        /// Organization slug to unassign the team from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_slugs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> OrganizationSlugs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseTeamOrganizationsBulkRemoveRequest" /> class.
        /// </summary>
        /// <param name="organizationSlugs">
        /// Organization slug to unassign the team from.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnterpriseTeamOrganizationsBulkRemoveRequest(
            global::System.Collections.Generic.IList<string> organizationSlugs)
        {
            this.OrganizationSlugs = organizationSlugs ?? throw new global::System.ArgumentNullException(nameof(organizationSlugs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseTeamOrganizationsBulkRemoveRequest" /> class.
        /// </summary>
        public EnterpriseTeamOrganizationsBulkRemoveRequest()
        {
        }

    }
}