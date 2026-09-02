
#nullable enable

namespace tryAGI.GitHub
{
    public partial class PrivateRegistriesClient
    {
        partial void PreparePrivateRegistriesUpdateOrgPrivateRegistryArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string secretName,
            global::tryAGI.GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequest request);
        partial void PreparePrivateRegistriesUpdateOrgPrivateRegistryRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string secretName,
            global::tryAGI.GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequest request);
        partial void ProcessPrivateRegistriesUpdateOrgPrivateRegistryResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Update a private registry for an organization<br/>
        /// Updates a private registry configuration with an encrypted value for an organization. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). For more information, see "[Encrypting secrets for the REST API](https://docs.github.com/rest/guides/encrypting-secrets-for-the-rest-api)."<br/>
        /// For OIDC-based registries (`oidc_azure`, `oidc_aws`, `oidc_jfrog`, `oidc_cloudsmith`, or `oidc_gcp`), the `encrypted_value` and `key_id` fields should be omitted.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task PrivateRegistriesUpdateOrgPrivateRegistryAsync(
            string org,
            string secretName,

            global::tryAGI.GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            await PrivateRegistriesUpdateOrgPrivateRegistryAsResponseAsync(
                org: org,
                secretName: secretName,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);
        }
        /// <summary>
        /// Update a private registry for an organization<br/>
        /// Updates a private registry configuration with an encrypted value for an organization. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). For more information, see "[Encrypting secrets for the REST API](https://docs.github.com/rest/guides/encrypting-secrets-for-the-rest-api)."<br/>
        /// For OIDC-based registries (`oidc_azure`, `oidc_aws`, `oidc_jfrog`, `oidc_cloudsmith`, or `oidc_gcp`), the `encrypted_value` and `key_id` fields should be omitted.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> PrivateRegistriesUpdateOrgPrivateRegistryAsResponseAsync(
            string org,
            string secretName,

            global::tryAGI.GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePrivateRegistriesUpdateOrgPrivateRegistryArguments(
                httpClient: HttpClient,
                org: ref org,
                secretName: ref secretName,
                request: request);

            using var __timeoutCancellationTokenSource = global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::tryAGI.GitHub.PathBuilder(
                                path: $"/orgs/{org}/private-registries/{secretName}",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: new global::System.Net.Http.HttpMethod("PATCH"),
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
                            var __httpRequestContent = global::tryAGI.GitHub.AutoSdkPolyfills.CreateJsonContent(
                                inputValue: request,
                                inputType: request.GetType(),
                                mediaType: "application/json",
                                jsonSerializerContext: JsonSerializerContext);
                            __httpRequest.Content = __httpRequestContent;
                global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PreparePrivateRegistriesUpdateOrgPrivateRegistryRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    org: org!,
                    secretName: secretName!,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PrivateRegistriesUpdateOrgPrivateRegistry",
                                methodName: "PrivateRegistriesUpdateOrgPrivateRegistryAsync",
                                pathTemplate: "$\"/orgs/{org}/private-registries/{secretName}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PrivateRegistriesUpdateOrgPrivateRegistry",
                                methodName: "PrivateRegistriesUpdateOrgPrivateRegistryAsync",
                                pathTemplate: "$\"/orgs/{org}/private-registries/{secretName}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PrivateRegistriesUpdateOrgPrivateRegistry",
                                methodName: "PrivateRegistriesUpdateOrgPrivateRegistryAsync",
                                pathTemplate: "$\"/orgs/{org}/private-registries/{secretName}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessPrivateRegistriesUpdateOrgPrivateRegistryResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PrivateRegistriesUpdateOrgPrivateRegistry",
                                methodName: "PrivateRegistriesUpdateOrgPrivateRegistryAsync",
                                pathTemplate: "$\"/orgs/{org}/private-registries/{secretName}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PrivateRegistriesUpdateOrgPrivateRegistry",
                                methodName: "PrivateRegistriesUpdateOrgPrivateRegistryAsync",
                                pathTemplate: "$\"/orgs/{org}/private-registries/{secretName}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Resource not found
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::tryAGI.GitHub.BasicError? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::tryAGI.GitHub.BasicError.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::tryAGI.GitHub.BasicError.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::tryAGI.GitHub.ApiException<global::tryAGI.GitHub.BasicError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Validation failed, or the endpoint has been spammed.
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::tryAGI.GitHub.ValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::tryAGI.GitHub.ValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::tryAGI.GitHub.ValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::tryAGI.GitHub.ApiException<global::tryAGI.GitHub.ValidationError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                return new global::tryAGI.GitHub.AutoSDKHttpResponse(
                                        statusCode: __response.StatusCode,
                                        headers: global::tryAGI.GitHub.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::tryAGI.GitHub.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    return new global::tryAGI.GitHub.AutoSDKHttpResponse(
                                        statusCode: __response.StatusCode,
                                        headers: global::tryAGI.GitHub.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::tryAGI.GitHub.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Update a private registry for an organization<br/>
        /// Updates a private registry configuration with an encrypted value for an organization. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). For more information, see "[Encrypting secrets for the REST API](https://docs.github.com/rest/guides/encrypting-secrets-for-the-rest-api)."<br/>
        /// For OIDC-based registries (`oidc_azure`, `oidc_aws`, `oidc_jfrog`, `oidc_cloudsmith`, or `oidc_gcp`), the `encrypted_value` and `key_id` fields should be omitted.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task PrivateRegistriesUpdateOrgPrivateRegistryAsync(
            string org,
            string secretName,
            global::tryAGI.GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType? registryType = default,
            string? url = default,
            string? username = default,
            bool? replacesBase = default,
            string? encryptedValue = default,
            string? keyId = default,
            global::tryAGI.GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequestVisibility? visibility = default,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds = default,
            global::tryAGI.GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequestAuthType? authType = default,
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::tryAGI.GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequest
            {
                RegistryType = registryType,
                Url = url,
                Username = username,
                ReplacesBase = replacesBase,
                EncryptedValue = encryptedValue,
                KeyId = keyId,
                Visibility = visibility,
                SelectedRepositoryIds = selectedRepositoryIds,
                AuthType = authType,
                TenantId = tenantId,
                ClientId = clientId,
                AwsRegion = awsRegion,
                AccountId = accountId,
                RoleName = roleName,
                Domain = domain,
                DomainOwner = domainOwner,
                JfrogOidcProviderName = jfrogOidcProviderName,
                Audience = audience,
                IdentityMappingName = identityMappingName,
                Namespace = @namespace,
                ServiceSlug = serviceSlug,
                ApiHost = apiHost,
                WorkloadIdentityProvider = workloadIdentityProvider,
                ServiceAccount = serviceAccount,
            };

            await PrivateRegistriesUpdateOrgPrivateRegistryAsync(
                org: org,
                secretName: secretName,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}