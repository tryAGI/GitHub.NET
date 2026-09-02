
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ActionsCreateWorkflowDispatchRequest
    {
        /// <summary>
        /// The git reference for the workflow. The reference can be a branch or tag name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// Input keys and values configured in the workflow file. The maximum number of properties is 25. Any default properties configured in the workflow file will be used when `inputs` are omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// Whether the response should include the workflow run ID and URLs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_run_details")]
        public bool? ReturnRunDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCreateWorkflowDispatchRequest" /> class.
        /// </summary>
        /// <param name="ref">
        /// The git reference for the workflow. The reference can be a branch or tag name.
        /// </param>
        /// <param name="inputs">
        /// Input keys and values configured in the workflow file. The maximum number of properties is 25. Any default properties configured in the workflow file will be used when `inputs` are omitted.
        /// </param>
        /// <param name="returnRunDetails">
        /// Whether the response should include the workflow run ID and URLs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsCreateWorkflowDispatchRequest(
            string @ref,
            object? inputs,
            bool? returnRunDetails)
        {
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Inputs = inputs;
            this.ReturnRunDetails = returnRunDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCreateWorkflowDispatchRequest" /> class.
        /// </summary>
        public ActionsCreateWorkflowDispatchRequest()
        {
        }

    }
}