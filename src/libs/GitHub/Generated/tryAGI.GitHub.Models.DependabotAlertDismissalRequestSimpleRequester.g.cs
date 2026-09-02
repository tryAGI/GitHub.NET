
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The user who requested the dismissal.
    /// </summary>
    public sealed partial class DependabotAlertDismissalRequestSimpleRequester
    {
        /// <summary>
        /// The unique identifier of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The login name of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        public string? Login { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertDismissalRequestSimpleRequester" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the user.
        /// </param>
        /// <param name="login">
        /// The login name of the user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DependabotAlertDismissalRequestSimpleRequester(
            int? id,
            string? login)
        {
            this.Id = id;
            this.Login = login;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertDismissalRequestSimpleRequester" /> class.
        /// </summary>
        public DependabotAlertDismissalRequestSimpleRequester()
        {
        }

    }
}