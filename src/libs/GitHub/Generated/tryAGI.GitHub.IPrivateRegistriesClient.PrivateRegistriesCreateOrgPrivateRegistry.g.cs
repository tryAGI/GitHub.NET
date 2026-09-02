#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IPrivateRegistriesClient
    {
        /// <summary>
        /// Create a private registry for an organization<br/>
        /// Creates a private registry configuration with an encrypted value for an organization. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). For more information, see "[Encrypting secrets for the REST API](https://docs.github.com/rest/guides/encrypting-secrets-for-the-rest-api)."<br/>
        /// For OIDC-based registries (`oidc_azure`, `oidc_aws`, `oidc_jfrog`, `oidc_cloudsmith`, or `oidc_gcp`), the `encrypted_value` and `key_id` fields should be omitted.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.OrgPrivateRegistryConfigurationWithSelectedRepositories> PrivateRegistriesCreateOrgPrivateRegistryAsync(
            string org,

            global::tryAGI.GitHub.PrivateRegistriesCreateOrgPrivateRegistryRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a private registry for an organization<br/>
        /// Creates a private registry configuration with an encrypted value for an organization. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). For more information, see "[Encrypting secrets for the REST API](https://docs.github.com/rest/guides/encrypting-secrets-for-the-rest-api)."<br/>
        /// For OIDC-based registries (`oidc_azure`, `oidc_aws`, `oidc_jfrog`, `oidc_cloudsmith`, or `oidc_gcp`), the `encrypted_value` and `key_id` fields should be omitted.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.OrgPrivateRegistryConfigurationWithSelectedRepositories>> PrivateRegistriesCreateOrgPrivateRegistryAsResponseAsync(
            string org,

            global::tryAGI.GitHub.PrivateRegistriesCreateOrgPrivateRegistryRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a private registry for an organization<br/>
        /// Creates a private registry configuration with an encrypted value for an organization. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). For more information, see "[Encrypting secrets for the REST API](https://docs.github.com/rest/guides/encrypting-secrets-for-the-rest-api)."<br/>
        /// For OIDC-based registries (`oidc_azure`, `oidc_aws`, `oidc_jfrog`, `oidc_cloudsmith`, or `oidc_gcp`), the `encrypted_value` and `key_id` fields should be omitted.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
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
        /// The value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get private registries public key for an organization](https://docs.github.com/rest/private-registries/organization-configurations#get-private-registries-public-key-for-an-organization) endpoint. Required when `auth_type` is `token` or `username_password`. Should be omitted for OIDC auth types.
        /// </param>
        /// <param name="keyId">
        /// The ID of the key you used to encrypt the secret. Required when `auth_type` is `token` or `username_password`. Should be omitted for OIDC auth types.
        /// </param>
        /// <param name="visibility">
        /// Which type of organization repositories have access to the private registry. `selected` means only the repositories specified by `selected_repository_ids` can access the private registry.
        /// </param>
        /// <param name="selectedRepositoryIds">
        /// An array of repository IDs that can access the organization private registry. You can only provide a list of repository IDs when `visibility` is set to `selected`. You can manage the list of selected repositories using the [Update a private registry for an organization](https://docs.github.com/rest/private-registries/organization-configurations#update-a-private-registry-for-an-organization) endpoint. This field should be omitted if `visibility` is set to `all` or `private`.
        /// </param>
        /// <param name="authType">
        /// The authentication type for the private registry. Defaults to `token` if not specified. Use `oidc_azure`, `oidc_aws`, `oidc_jfrog`, `oidc_cloudsmith`, or `oidc_gcp` for OIDC authentication.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.OrgPrivateRegistryConfigurationWithSelectedRepositories> PrivateRegistriesCreateOrgPrivateRegistryAsync(
            string org,
            global::tryAGI.GitHub.PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType registryType,
            string url,
            global::tryAGI.GitHub.PrivateRegistriesCreateOrgPrivateRegistryRequestVisibility visibility,
            string? username = default,
            bool? replacesBase = default,
            string? encryptedValue = default,
            string? keyId = default,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds = default,
            global::tryAGI.GitHub.PrivateRegistriesCreateOrgPrivateRegistryRequestAuthType? authType = default,
            string? tenantId = default,
            string? clientId = default,
            string? awsRegion = default,
            string? accountId = default,
            string? roleName = default,
            string? domain = default,
            string? domainOwner = default,
            string? jfrogOidcProviderName = default,
            string? audience = default,
            string? identityMappingName = default,
            string? @namespace = default,
            string? serviceSlug = default,
            string? apiHost = default,
            string? workloadIdentityProvider = default,
            string? serviceAccount = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}