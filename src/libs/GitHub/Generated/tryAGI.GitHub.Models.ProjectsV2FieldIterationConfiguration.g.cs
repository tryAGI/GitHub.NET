
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The configuration for iteration fields.
    /// </summary>
    public sealed partial class ProjectsV2FieldIterationConfiguration
    {
        /// <summary>
        /// The start date of the first iteration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartDate { get; set; }

        /// <summary>
        /// The default duration for iterations in days. Individual iterations can override this value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Duration { get; set; }

        /// <summary>
        /// Zero or more iterations for the field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iterations")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.ProjectsV2FieldIterationConfigurationIteration>? Iterations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2FieldIterationConfiguration" /> class.
        /// </summary>
        /// <param name="startDate">
        /// The start date of the first iteration.
        /// </param>
        /// <param name="duration">
        /// The default duration for iterations in days. Individual iterations can override this value.
        /// </param>
        /// <param name="iterations">
        /// Zero or more iterations for the field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsV2FieldIterationConfiguration(
            global::System.DateTime startDate,
            int duration,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.ProjectsV2FieldIterationConfigurationIteration>? iterations)
        {
            this.StartDate = startDate;
            this.Duration = duration;
            this.Iterations = iterations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2FieldIterationConfiguration" /> class.
        /// </summary>
        public ProjectsV2FieldIterationConfiguration()
        {
        }

    }
}