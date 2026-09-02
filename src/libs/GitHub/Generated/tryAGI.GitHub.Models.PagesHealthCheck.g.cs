
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Pages Health Check Status
    /// </summary>
    public sealed partial class PagesHealthCheck
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public global::tryAGI.GitHub.PagesHealthCheckDomain? Domain { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alt_domain")]
        public global::tryAGI.GitHub.PagesHealthCheckAltDomain? AltDomain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PagesHealthCheck" /> class.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="altDomain"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PagesHealthCheck(
            global::tryAGI.GitHub.PagesHealthCheckDomain? domain,
            global::tryAGI.GitHub.PagesHealthCheckAltDomain? altDomain)
        {
            this.Domain = domain;
            this.AltDomain = altDomain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagesHealthCheck" /> class.
        /// </summary>
        public PagesHealthCheck()
        {
        }

    }
}