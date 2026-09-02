
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
    /// </summary>
    public sealed partial class Integration
    {
        /// <summary>
        /// Unique identifier of the GitHub app<br/>
        /// Example: 37
        /// </summary>
        /// <example>37</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The slug name of the GitHub app<br/>
        /// Example: probot-owners
        /// </summary>
        /// <example>probot-owners</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Example: MDExOkludGVncmF0aW9uMQ==
        /// </summary>
        /// <example>MDExOkludGVncmF0aW9uMQ==</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Example: "Iv1.25b5d1e65ffc4022"
        /// </summary>
        /// <example>"Iv1.25b5d1e65ffc4022"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.Enterprise>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.Enterprise> Owner { get; set; }

        /// <summary>
        /// The name of the GitHub app<br/>
        /// Example: Probot Owners
        /// </summary>
        /// <example>Probot Owners</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: The description of the app.
        /// </summary>
        /// <example>The description of the app.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: https://example.com
        /// </summary>
        /// <example>https://example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/apps/super-ci
        /// </summary>
        /// <example>https://github.com/apps/super-ci</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Example: 2017-07-08T16:18:44-04:00
        /// </summary>
        /// <example>2017-07-08T16:18:44-04:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Example: 2017-07-08T16:18:44-04:00
        /// </summary>
        /// <example>2017-07-08T16:18:44-04:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The set of permissions for the GitHub app<br/>
        /// Example: {"issues":"read","deployments":"write"}
        /// </summary>
        /// <example>{"issues":"read","deployments":"write"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.IntegrationPermissions Permissions { get; set; }

        /// <summary>
        /// The list of events for the GitHub app. Note that the `installation_target`, `security_advisory`, and `meta` events are not included because they are global events and not specific to an installation.<br/>
        /// Example: [label, deployment]
        /// </summary>
        /// <example>[label, deployment]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Events { get; set; }

        /// <summary>
        /// The number of installations associated with the GitHub app. Only returned when the integration is requesting details about itself.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("installations_count")]
        public int? InstallationsCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Integration" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the GitHub app<br/>
        /// Example: 37
        /// </param>
        /// <param name="nodeId">
        /// Example: MDExOkludGVncmF0aW9uMQ==
        /// </param>
        /// <param name="owner"></param>
        /// <param name="name">
        /// The name of the GitHub app<br/>
        /// Example: Probot Owners
        /// </param>
        /// <param name="externalUrl">
        /// Example: https://example.com
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/apps/super-ci
        /// </param>
        /// <param name="createdAt">
        /// Example: 2017-07-08T16:18:44-04:00
        /// </param>
        /// <param name="updatedAt">
        /// Example: 2017-07-08T16:18:44-04:00
        /// </param>
        /// <param name="permissions">
        /// The set of permissions for the GitHub app<br/>
        /// Example: {"issues":"read","deployments":"write"}
        /// </param>
        /// <param name="events">
        /// The list of events for the GitHub app. Note that the `installation_target`, `security_advisory`, and `meta` events are not included because they are global events and not specific to an installation.<br/>
        /// Example: [label, deployment]
        /// </param>
        /// <param name="slug">
        /// The slug name of the GitHub app<br/>
        /// Example: probot-owners
        /// </param>
        /// <param name="clientId">
        /// Example: "Iv1.25b5d1e65ffc4022"
        /// </param>
        /// <param name="description">
        /// Example: The description of the app.
        /// </param>
        /// <param name="installationsCount">
        /// The number of installations associated with the GitHub app. Only returned when the integration is requesting details about itself.<br/>
        /// Example: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Integration(
            int id,
            string nodeId,
            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.Enterprise> owner,
            string name,
            string externalUrl,
            string htmlUrl,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::tryAGI.GitHub.IntegrationPermissions permissions,
            global::System.Collections.Generic.IList<string> events,
            string? slug,
            string? clientId,
            string? description,
            int? installationsCount)
        {
            this.Id = id;
            this.Slug = slug;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.ClientId = clientId;
            this.Owner = owner;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.ExternalUrl = externalUrl ?? throw new global::System.ArgumentNullException(nameof(externalUrl));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.InstallationsCount = installationsCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Integration" /> class.
        /// </summary>
        public Integration()
        {
        }

    }
}