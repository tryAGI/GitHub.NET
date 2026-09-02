
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrivateRegistriesUpdateOrgPrivateRegistryRequest
    {
        /// <summary>
        /// The registry type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryTypeJsonConverter))]
        public global::tryAGI.GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType? RegistryType { get; set; }

        /// <summary>
        /// The URL of the private registry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The username to use when authenticating with the private registry. This field should be omitted if the private registry does not require a username for authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Whether this private registry should replace the base registry (e.g., npmjs.org for npm, rubygems.org for rubygems). When set to `true`, Dependabot will only use this registry and will not fall back to the public registry. When set to `false` (default), Dependabot will use this registry for scoped packages but may fall back to the public registry for other packages.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replaces_base")]
        public bool? ReplacesBase { get; set; }

        /// <summary>
        /// The value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get private registries public key for an organization](https://docs.github.com/rest/private-registries/organization-configurations#get-private-registries-public-key-for-an-organization) endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_value")]
        public string? EncryptedValue { get; set; }

        /// <summary>
        /// The ID of the key you used to encrypt the secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_id")]
        public string? KeyId { get; set; }

        /// <summary>
        /// Which type of organization repositories have access to the private registry. `selected` means only the repositories specified by `selected_repository_ids` can access the private registry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.PrivateRegistriesUpdateOrgPrivateRegistryRequestVisibilityJsonConverter))]
        public global::tryAGI.GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequestVisibility? Visibility { get; set; }

        /// <summary>
        /// An array of repository IDs that can access the organization private registry. You can only provide a list of repository IDs when `visibility` is set to `selected`. This field should be omitted if `visibility` is set to `all` or `private`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_repository_ids")]
        public global::System.Collections.Generic.IList<int>? SelectedRepositoryIds { get; set; }

        /// <summary>
        /// The authentication type for the private registry. This field cannot be changed after creation. If provided, it must match the existing `auth_type` of the configuration. To change the authentication type, delete and recreate the configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthTypeJsonConverter))]
        public global::tryAGI.GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthType? AuthType { get; set; }

        /// <summary>
        /// The tenant ID of the Azure AD application. Required when `auth_type` is `oidc_azure`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        /// The client ID of the Azure AD application. Required when `auth_type` is `oidc_azure`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// The AWS region. Required when `auth_type` is `oidc_aws`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_region")]
        public string? AwsRegion { get; set; }

        /// <summary>
        /// The AWS account ID. Required when `auth_type` is `oidc_aws`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_id")]
        public string? AccountId { get; set; }

        /// <summary>
        /// The AWS IAM role name. Required when `auth_type` is `oidc_aws`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_name")]
        public string? RoleName { get; set; }

        /// <summary>
        /// The CodeArtifact domain. Required when `auth_type` is `oidc_aws`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// The CodeArtifact domain owner (AWS account ID). Required when `auth_type` is `oidc_aws`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain_owner")]
        public string? DomainOwner { get; set; }

        /// <summary>
        /// The JFrog OIDC provider name. Required when `auth_type` is `oidc_jfrog`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jfrog_oidc_provider_name")]
        public string? JfrogOidcProviderName { get; set; }

        /// <summary>
        /// The OIDC audience. Optional for `oidc_aws`, `oidc_jfrog`, and `oidc_gcp`, and required for `oidc_cloudsmith` auth types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        public string? Audience { get; set; }

        /// <summary>
        /// The JFrog identity mapping name. Optional for `oidc_jfrog` auth type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_mapping_name")]
        public string? IdentityMappingName { get; set; }

        /// <summary>
        /// The Cloudsmith organization namespace. Required when `auth_type` is `oidc_cloudsmith`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// The Cloudsmith service account slug. Required when `auth_type` is `oidc_cloudsmith`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_slug")]
        public string? ServiceSlug { get; set; }

        /// <summary>
        /// The Cloudsmith API host. Optional for `oidc_cloudsmith` auth type. If omitted, `api.cloudsmith.io` is used by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_host")]
        public string? ApiHost { get; set; }

        /// <summary>
        /// The full resource name of the GCP Workload Identity Provider (e.g. `projects/&lt;NUM&gt;/locations/global/workloadIdentityPools/&lt;POOL&gt;/providers/&lt;PROVIDER&gt;`). Required when `auth_type` is `oidc_gcp`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workload_identity_provider")]
        public string? WorkloadIdentityProvider { get; set; }

        /// <summary>
        /// The GCP service account email to impersonate. Optional for `oidc_gcp` auth type. If omitted, the federated token is used directly (direct WIF).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account")]
        public string? ServiceAccount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateRegistriesUpdateOrgPrivateRegistryRequest" /> class.
        /// </summary>
        /// <param name="registryType">
        /// The registry type.
        /// </param>
        /// <param name="url">
        /// The URL of the private registry.
        /// </param>
        /// <param name="username">
        /// The username to use when authenticating with the private registry. This field should be omitted if the private registry does not require a username for authentication.
        /// </param>
        /// <param name="replacesBase">
        /// Whether this private registry should replace the base registry (e.g., npmjs.org for npm, rubygems.org for rubygems). When set to `true`, Dependabot will only use this registry and will not fall back to the public registry. When set to `false` (default), Dependabot will use this registry for scoped packages but may fall back to the public registry for other packages.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="encryptedValue">
        /// The value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get private registries public key for an organization](https://docs.github.com/rest/private-registries/organization-configurations#get-private-registries-public-key-for-an-organization) endpoint.
        /// </param>
        /// <param name="keyId">
        /// The ID of the key you used to encrypt the secret.
        /// </param>
        /// <param name="visibility">
        /// Which type of organization repositories have access to the private registry. `selected` means only the repositories specified by `selected_repository_ids` can access the private registry.
        /// </param>
        /// <param name="selectedRepositoryIds">
        /// An array of repository IDs that can access the organization private registry. You can only provide a list of repository IDs when `visibility` is set to `selected`. This field should be omitted if `visibility` is set to `all` or `private`.
        /// </param>
        /// <param name="authType">
        /// The authentication type for the private registry. This field cannot be changed after creation. If provided, it must match the existing `auth_type` of the configuration. To change the authentication type, delete and recreate the configuration.
        /// </param>
        /// <param name="tenantId">
        /// The tenant ID of the Azure AD application. Required when `auth_type` is `oidc_azure`.
        /// </param>
        /// <param name="clientId">
        /// The client ID of the Azure AD application. Required when `auth_type` is `oidc_azure`.
        /// </param>
        /// <param name="awsRegion">
        /// The AWS region. Required when `auth_type` is `oidc_aws`.
        /// </param>
        /// <param name="accountId">
        /// The AWS account ID. Required when `auth_type` is `oidc_aws`.
        /// </param>
        /// <param name="roleName">
        /// The AWS IAM role name. Required when `auth_type` is `oidc_aws`.
        /// </param>
        /// <param name="domain">
        /// The CodeArtifact domain. Required when `auth_type` is `oidc_aws`.
        /// </param>
        /// <param name="domainOwner">
        /// The CodeArtifact domain owner (AWS account ID). Required when `auth_type` is `oidc_aws`.
        /// </param>
        /// <param name="jfrogOidcProviderName">
        /// The JFrog OIDC provider name. Required when `auth_type` is `oidc_jfrog`.
        /// </param>
        /// <param name="audience">
        /// The OIDC audience. Optional for `oidc_aws`, `oidc_jfrog`, and `oidc_gcp`, and required for `oidc_cloudsmith` auth types.
        /// </param>
        /// <param name="identityMappingName">
        /// The JFrog identity mapping name. Optional for `oidc_jfrog` auth type.
        /// </param>
        /// <param name="namespace">
        /// The Cloudsmith organization namespace. Required when `auth_type` is `oidc_cloudsmith`.
        /// </param>
        /// <param name="serviceSlug">
        /// The Cloudsmith service account slug. Required when `auth_type` is `oidc_cloudsmith`.
        /// </param>
        /// <param name="apiHost">
        /// The Cloudsmith API host. Optional for `oidc_cloudsmith` auth type. If omitted, `api.cloudsmith.io` is used by default.
        /// </param>
        /// <param name="workloadIdentityProvider">
        /// The full resource name of the GCP Workload Identity Provider (e.g. `projects/&lt;NUM&gt;/locations/global/workloadIdentityPools/&lt;POOL&gt;/providers/&lt;PROVIDER&gt;`). Required when `auth_type` is `oidc_gcp`.
        /// </param>
        /// <param name="serviceAccount">
        /// The GCP service account email to impersonate. Optional for `oidc_gcp` auth type. If omitted, the federated token is used directly (direct WIF).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateRegistriesUpdateOrgPrivateRegistryRequest(
            global::tryAGI.GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType? registryType,
            string? url,
            string? username,
            bool? replacesBase,
            string? encryptedValue,
            string? keyId,
            global::tryAGI.GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequestVisibility? visibility,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds,
            global::tryAGI.GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthType? authType,
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
            this.RegistryType = registryType;
            this.Url = url;
            this.Username = username;
            this.ReplacesBase = replacesBase;
            this.EncryptedValue = encryptedValue;
            this.KeyId = keyId;
            this.Visibility = visibility;
            this.SelectedRepositoryIds = selectedRepositoryIds;
            this.AuthType = authType;
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateRegistriesUpdateOrgPrivateRegistryRequest" /> class.
        /// </summary>
        public PrivateRegistriesUpdateOrgPrivateRegistryRequest()
        {
        }

    }
}