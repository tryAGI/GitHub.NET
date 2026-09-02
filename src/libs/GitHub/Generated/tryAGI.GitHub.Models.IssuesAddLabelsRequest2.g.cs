
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesAddLabelsRequest2
    {
        /// <summary>
        /// The labels to add to the issue's existing labels. You can also pass an `array` of labels directly, but GitHub recommends passing an object with the `labels` key. To replace all of the labels for an issue, use "[Set labels for an issue](https://docs.github.com/rest/issues/labels#set-labels-for-an-issue)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.OneOf<string, global::tryAGI.GitHub.IssuesAddLabelsRequestLabel>>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAddLabelsRequest2" /> class.
        /// </summary>
        /// <param name="labels">
        /// The labels to add to the issue's existing labels. You can also pass an `array` of labels directly, but GitHub recommends passing an object with the `labels` key. To replace all of the labels for an issue, use "[Set labels for an issue](https://docs.github.com/rest/issues/labels#set-labels-for-an-issue)."
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesAddLabelsRequest2(
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.OneOf<string, global::tryAGI.GitHub.IssuesAddLabelsRequestLabel>>? labels)
        {
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAddLabelsRequest2" /> class.
        /// </summary>
        public IssuesAddLabelsRequest2()
        {
        }

    }
}