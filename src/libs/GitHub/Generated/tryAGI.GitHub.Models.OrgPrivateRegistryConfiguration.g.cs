
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Private registry configuration for an organization
    /// </summary>
    public sealed partial class OrgPrivateRegistryConfiguration
    {
        /// <summary>
        /// The name of the private registry configuration.<br/>
        /// Example: MAVEN_REPOSITORY_SECRET
        /// </summary>
        /// <example>MAVEN_REPOSITORY_SECRET</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The registry type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OrgPrivateRegistryConfigurationRegistryTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.OrgPrivateRegistryConfigurationRegistryType RegistryType { get; set; }

        /// <summary>
        /// The authentication type for the private registry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OrgPrivateRegistryConfigurationAuthTypeJsonConverter))]
        public global::tryAGI.GitHub.OrgPrivateRegistryConfigurationAuthType? AuthType { get; set; }

        /// <summary>
        /// The URL of the private registry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The username to use when authenticating with the private registry.<br/>
        /// Example: monalisa
        /// </summary>
        /// <example>monalisa</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Whether this private registry replaces the base registry (e.g., npmjs.org for npm, rubygems.org for rubygems). When `true`, Dependabot will only use this registry and will not fall back to the public registry. When `false` (default), Dependabot will use this registry for scoped packages but may fall back to the public registry for other packages.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replaces_base")]
        public bool? ReplacesBase { get; set; }

        /// <summary>
        /// Which type of organization repositories have access to the private registry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OrgPrivateRegistryConfigurationVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.OrgPrivateRegistryConfigurationVisibility Visibility { get; set; }

        /// <summary>
        /// The tenant ID of the Azure AD application.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        /// The client ID of the Azure AD application.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// The AWS region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_region")]
        public string? AwsRegion { get; set; }

        /// <summary>
        /// The AWS account ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_id")]
        public string? AccountId { get; set; }

        /// <summary>
        /// The AWS IAM role name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_name")]
        public string? RoleName { get; set; }

        /// <summary>
        /// The CodeArtifact domain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// The CodeArtifact domain owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain_owner")]
        public string? DomainOwner { get; set; }

        /// <summary>
        /// The JFrog OIDC provider name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jfrog_oidc_provider_name")]
        public string? JfrogOidcProviderName { get; set; }

        /// <summary>
        /// The OIDC audience.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        public string? Audience { get; set; }

        /// <summary>
        /// The JFrog identity mapping name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_mapping_name")]
        public string? IdentityMappingName { get; set; }

        /// <summary>
        /// The Cloudsmith organization namespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// The Cloudsmith service account slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_slug")]
        public string? ServiceSlug { get; set; }

        /// <summary>
        /// The Cloudsmith API host.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_host")]
        public string? ApiHost { get; set; }

        /// <summary>
        /// The full resource name of the GCP Workload Identity Provider (e.g. `projects/&lt;NUM&gt;/locations/global/workloadIdentityPools/&lt;POOL&gt;/providers/&lt;PROVIDER&gt;`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workload_identity_provider")]
        public string? WorkloadIdentityProvider { get; set; }

        /// <summary>
        /// The GCP service account email to impersonate. If omitted, the federated token is used directly (direct WIF).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account")]
        public string? ServiceAccount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgPrivateRegistryConfiguration" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the private registry configuration.<br/>
        /// Example: MAVEN_REPOSITORY_SECRET
        /// </param>
        /// <param name="registryType">
        /// The registry type.
        /// </param>
        /// <param name="visibility">
        /// Which type of organization repositories have access to the private registry.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="authType">
        /// The authentication type for the private registry.
        /// </param>
        /// <param name="url">
        /// The URL of the private registry.
        /// </param>
        /// <param name="username">
        /// The username to use when authenticating with the private registry.<br/>
        /// Example: monalisa
        /// </param>
        /// <param name="replacesBase">
        /// Whether this private registry replaces the base registry (e.g., npmjs.org for npm, rubygems.org for rubygems). When `true`, Dependabot will only use this registry and will not fall back to the public registry. When `false` (default), Dependabot will use this registry for scoped packages but may fall back to the public registry for other packages.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="tenantId">
        /// The tenant ID of the Azure AD application.
        /// </param>
        /// <param name="clientId">
        /// The client ID of the Azure AD application.
        /// </param>
        /// <param name="awsRegion">
        /// The AWS region.
        /// </param>
        /// <param name="accountId">
        /// The AWS account ID.
        /// </param>
        /// <param name="roleName">
        /// The AWS IAM role name.
        /// </param>
        /// <param name="domain">
        /// The CodeArtifact domain.
        /// </param>
        /// <param name="domainOwner">
        /// The CodeArtifact domain owner.
        /// </param>
        /// <param name="jfrogOidcProviderName">
        /// The JFrog OIDC provider name.
        /// </param>
        /// <param name="audience">
        /// The OIDC audience.
        /// </param>
        /// <param name="identityMappingName">
        /// The JFrog identity mapping name.
        /// </param>
        /// <param name="namespace">
        /// The Cloudsmith organization namespace.
        /// </param>
        /// <param name="serviceSlug">
        /// The Cloudsmith service account slug.
        /// </param>
        /// <param name="apiHost">
        /// The Cloudsmith API host.
        /// </param>
        /// <param name="workloadIdentityProvider">
        /// The full resource name of the GCP Workload Identity Provider (e.g. `projects/&lt;NUM&gt;/locations/global/workloadIdentityPools/&lt;POOL&gt;/providers/&lt;PROVIDER&gt;`).
        /// </param>
        /// <param name="serviceAccount">
        /// The GCP service account email to impersonate. If omitted, the federated token is used directly (direct WIF).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgPrivateRegistryConfiguration(
            string name,
            global::tryAGI.GitHub.OrgPrivateRegistryConfigurationRegistryType registryType,
            global::tryAGI.GitHub.OrgPrivateRegistryConfigurationVisibility visibility,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::tryAGI.GitHub.OrgPrivateRegistryConfigurationAuthType? authType,
            string? url,
            string? username,
            bool? replacesBase,
            string? tenantId,
            string? clientId,
            string? awsRegion,
            string? accountId,
            string? roleName,
            string? domain,
            string? domainOwner,
            string? jfrogOidcProviderName,
            string? audience,
            string? identityMappingName,
            string? @namespace,
            string? serviceSlug,
            string? apiHost,
            string? workloadIdentityProvider,
            string? serviceAccount)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.RegistryType = registryType;
            this.AuthType = authType;
            this.Url = url;
            this.Username = username;
            this.ReplacesBase = replacesBase;
            this.Visibility = visibility;
            this.TenantId = tenantId;
            this.ClientId = clientId;
            this.AwsRegion = awsRegion;
            this.AccountId = accountId;
            this.RoleName = roleName;
            this.Domain = domain;
            this.DomainOwner = domainOwner;
            this.JfrogOidcProviderName = jfrogOidcProviderName;
            this.Audience = audience;
            this.IdentityMappingName = identityMappingName;
            this.Namespace = @namespace;
            this.ServiceSlug = serviceSlug;
            this.ApiHost = apiHost;
            this.WorkloadIdentityProvider = workloadIdentityProvider;
            this.ServiceAccount = serviceAccount;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgPrivateRegistryConfiguration" /> class.
        /// </summary>
        public OrgPrivateRegistryConfiguration()
        {
        }

    }
}