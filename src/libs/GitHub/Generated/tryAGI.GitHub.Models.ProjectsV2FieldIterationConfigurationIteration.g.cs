
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectsV2FieldIterationConfigurationIteration
    {
        /// <summary>
        /// The title of the iteration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The start date of the iteration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartDate { get; set; }

        /// <summary>
        /// The duration of the iteration in days.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2FieldIterationConfigurationIteration" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the iteration.
        /// </param>
        /// <param name="startDate">
        /// The start date of the iteration.
        /// </param>
        /// <param name="duration">
        /// The duration of the iteration in days.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsV2FieldIterationConfigurationIteration(
            string title,
            global::System.DateTime startDate,
            int duration)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.StartDate = startDate;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2FieldIterationConfigurationIteration" /> class.
        /// </summary>
        public ProjectsV2FieldIterationConfigurationIteration()
        {
        }

    }
}