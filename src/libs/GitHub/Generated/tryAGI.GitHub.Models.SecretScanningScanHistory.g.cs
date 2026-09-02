
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SecretScanningScanHistory
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incremental_scans")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningScan>? IncrementalScans { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern_update_scans")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningScan>? PatternUpdateScans { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backfill_scans")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningScan>? BackfillScans { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_pattern_backfill_scans")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.SecretScanningScan, global::tryAGI.GitHub.SecretScanningScanHistoryCustomPatternBackfillScan>>? CustomPatternBackfillScans { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generic_secrets_backfill_scans")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningScan>? GenericSecretsBackfillScans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningScanHistory" /> class.
        /// </summary>
        /// <param name="incrementalScans"></param>
        /// <param name="patternUpdateScans"></param>
        /// <param name="backfillScans"></param>
        /// <param name="customPatternBackfillScans"></param>
        /// <param name="genericSecretsBackfillScans"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningScanHistory(
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningScan>? incrementalScans,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningScan>? patternUpdateScans,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningScan>? backfillScans,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.SecretScanningScan, global::tryAGI.GitHub.SecretScanningScanHistoryCustomPatternBackfillScan>>? customPatternBackfillScans,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningScan>? genericSecretsBackfillScans)
        {
            this.IncrementalScans = incrementalScans;
            this.PatternUpdateScans = patternUpdateScans;
            this.BackfillScans = backfillScans;
            this.CustomPatternBackfillScans = customPatternBackfillScans;
            this.GenericSecretsBackfillScans = genericSecretsBackfillScans;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningScanHistory" /> class.
        /// </summary>
        public SecretScanningScanHistory()
        {
        }

    }
}