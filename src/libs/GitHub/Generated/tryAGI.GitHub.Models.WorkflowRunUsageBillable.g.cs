
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkflowRunUsageBillable
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("UBUNTU")]
        public global::tryAGI.GitHub.WorkflowRunUsageBillableUbuntu? Ubuntu { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MACOS")]
        public global::tryAGI.GitHub.WorkflowRunUsageBillableMacos? Macos { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("WINDOWS")]
        public global::tryAGI.GitHub.WorkflowRunUsageBillableWindows? Windows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRunUsageBillable" /> class.
        /// </summary>
        /// <param name="ubuntu"></param>
        /// <param name="macos"></param>
        /// <param name="windows"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowRunUsageBillable(
            global::tryAGI.GitHub.WorkflowRunUsageBillableUbuntu? ubuntu,
            global::tryAGI.GitHub.WorkflowRunUsageBillableMacos? macos,
            global::tryAGI.GitHub.WorkflowRunUsageBillableWindows? windows)
        {
            this.Ubuntu = ubuntu;
            this.Macos = macos;
            this.Windows = windows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRunUsageBillable" /> class.
        /// </summary>
        public WorkflowRunUsageBillable()
        {
        }

    }
}