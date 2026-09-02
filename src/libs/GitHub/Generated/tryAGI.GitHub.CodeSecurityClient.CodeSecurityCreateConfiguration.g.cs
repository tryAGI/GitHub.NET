
#nullable enable

namespace tryAGI.GitHub
{
    public partial class CodeSecurityClient
    {
        partial void PrepareCodeSecurityCreateConfigurationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequest request);
        partial void PrepareCodeSecurityCreateConfigurationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequest request);
        partial void ProcessCodeSecurityCreateConfigurationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodeSecurityCreateConfigurationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a code security configuration<br/>
        /// Creates a code security configuration in an organization.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CodeSecurityConfiguration> CodeSecurityCreateConfigurationAsync(
            string org,

            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CodeSecurityCreateConfigurationAsResponseAsync(
                org: org,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Create a code security configuration<br/>
        /// Creates a code security configuration in an organization.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CodeSecurityConfiguration>> CodeSecurityCreateConfigurationAsResponseAsync(
            string org,

            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCodeSecurityCreateConfigurationArguments(
                httpClient: HttpClient,
                org: ref org,
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
                                path: $"/orgs/{org}/code-security/configurations",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
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
                PrepareCodeSecurityCreateConfigurationRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    org: org!,
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
                                operationId: "CodeSecurityCreateConfiguration",
                                methodName: "CodeSecurityCreateConfigurationAsync",
                                pathTemplate: "$\"/orgs/{org}/code-security/configurations\"",
                                httpMethod: "POST",
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
                                operationId: "CodeSecurityCreateConfiguration",
                                methodName: "CodeSecurityCreateConfigurationAsync",
                                pathTemplate: "$\"/orgs/{org}/code-security/configurations\"",
                                httpMethod: "POST",
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
                                operationId: "CodeSecurityCreateConfiguration",
                                methodName: "CodeSecurityCreateConfigurationAsync",
                                pathTemplate: "$\"/orgs/{org}/code-security/configurations\"",
                                httpMethod: "POST",
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
                ProcessCodeSecurityCreateConfigurationResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CodeSecurityCreateConfiguration",
                                methodName: "CodeSecurityCreateConfigurationAsync",
                                pathTemplate: "$\"/orgs/{org}/code-security/configurations\"",
                                httpMethod: "POST",
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
                                operationId: "CodeSecurityCreateConfiguration",
                                methodName: "CodeSecurityCreateConfigurationAsync",
                                pathTemplate: "$\"/orgs/{org}/code-security/configurations\"",
                                httpMethod: "POST",
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
                                ProcessCodeSecurityCreateConfigurationResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::tryAGI.GitHub.CodeSecurityConfiguration.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CodeSecurityConfiguration>(
                                        statusCode: __response.StatusCode,
                                        headers: global::tryAGI.GitHub.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::tryAGI.GitHub.CodeSecurityConfiguration.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CodeSecurityConfiguration>(
                                        statusCode: __response.StatusCode,
                                        headers: global::tryAGI.GitHub.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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
        /// Create a code security configuration<br/>
        /// Creates a code security configuration in an organization.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name">
        /// The name of the code security configuration. Must be unique within the organization.
        /// </param>
        /// <param name="description">
        /// A description of the code security configuration
        /// </param>
        /// <param name="advancedSecurity">
        /// The enablement status of GitHub Advanced Security features. `enabled` will enable both Code Security and Secret Protection features.<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; `code_security` and `secret_protection` are deprecated values for this field. Prefer the individual `code_security` and `secret_protection` fields to set the status of these features.<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="codeSecurity">
        /// The enablement status of GitHub Code Security features.
        /// </param>
        /// <param name="dependencyGraph">
        /// The enablement status of Dependency Graph<br/>
        /// Default Value: enabled
        /// </param>
        /// <param name="dependencyGraphAutosubmitAction">
        /// The enablement status of Automatic dependency submission<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="dependencyGraphAutosubmitActionOptions">
        /// Feature options for Automatic dependency submission
        /// </param>
        /// <param name="dependabotAlerts">
        /// The enablement status of Dependabot alerts<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="dependabotSecurityUpdates">
        /// The enablement status of Dependabot security updates<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="dependabotDelegatedAlertDismissal">
        /// The enablement status of Dependabot delegated alert dismissal. Requires Dependabot alerts to be enabled.<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="codeScanningOptions">
        /// Security Configuration feature options for code scanning
        /// </param>
        /// <param name="codeScanningDefaultSetup">
        /// The enablement status of code scanning default setup<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="codeScanningDefaultSetupOptions">
        /// Feature options for code scanning default setup
        /// </param>
        /// <param name="codeScanningDelegatedAlertDismissal">
        /// The enablement status of code scanning delegated alert dismissal<br/>
        /// Default Value: not_set
        /// </param>
        /// <param name="secretProtection">
        /// The enablement status of GitHub Secret Protection features.
        /// </param>
        /// <param name="secretScanning">
        /// The enablement status of secret scanning<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningPushProtection">
        /// The enablement status of secret scanning push protection<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningDelegatedBypass">
        /// The enablement status of secret scanning delegated bypass<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningDelegatedBypassOptions">
        /// Feature options for secret scanning delegated bypass
        /// </param>
        /// <param name="secretScanningValidityChecks">
        /// The enablement status of secret scanning validity checks<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningNonProviderPatterns">
        /// The enablement status of secret scanning non provider patterns<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningGenericSecrets">
        /// The enablement status of Copilot secret scanning<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningDelegatedAlertDismissal">
        /// The enablement status of secret scanning delegated alert dismissal
        /// </param>
        /// <param name="secretScanningExtendedMetadata">
        /// The enablement status of secret scanning extended metadata
        /// </param>
        /// <param name="privateVulnerabilityReporting">
        /// The enablement status of private vulnerability reporting<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="enforcement">
        /// The enforcement status for a security configuration<br/>
        /// Default Value: enforced
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CodeSecurityConfiguration> CodeSecurityCreateConfigurationAsync(
            string org,
            string name,
            string? description = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestAdvancedSecurity? advancedSecurity = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestCodeSecurity? codeSecurity = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestDependencyGraph? dependencyGraph = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction? dependencyGraphAutosubmitAction = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitActionOptions? dependencyGraphAutosubmitActionOptions = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestDependabotAlerts? dependabotAlerts = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates? dependabotSecurityUpdates = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestDependabotDelegatedAlertDismissal? dependabotDelegatedAlertDismissal = default,
            global::tryAGI.GitHub.CodeScanningOptions? codeScanningOptions = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup? codeScanningDefaultSetup = default,
            global::tryAGI.GitHub.CodeScanningDefaultSetupOptions? codeScanningDefaultSetupOptions = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestCodeScanningDelegatedAlertDismissal? codeScanningDelegatedAlertDismissal = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretProtection? secretProtection = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanning? secretScanning = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningPushProtection? secretScanningPushProtection = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass? secretScanningDelegatedBypass = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassOptions? secretScanningDelegatedBypassOptions = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks? secretScanningValidityChecks = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningGenericSecrets? secretScanningGenericSecrets = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningDelegatedAlertDismissal? secretScanningDelegatedAlertDismissal = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningExtendedMetadata? secretScanningExtendedMetadata = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestPrivateVulnerabilityReporting? privateVulnerabilityReporting = default,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestEnforcement? enforcement = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequest
            {
                Name = name,
                Description = description,
                AdvancedSecurity = advancedSecurity,
                CodeSecurity = codeSecurity,
                DependencyGraph = dependencyGraph,
                DependencyGraphAutosubmitAction = dependencyGraphAutosubmitAction,
                DependencyGraphAutosubmitActionOptions = dependencyGraphAutosubmitActionOptions,
                DependabotAlerts = dependabotAlerts,
                DependabotSecurityUpdates = dependabotSecurityUpdates,
                DependabotDelegatedAlertDismissal = dependabotDelegatedAlertDismissal,
                CodeScanningOptions = codeScanningOptions,
                CodeScanningDefaultSetup = codeScanningDefaultSetup,
                CodeScanningDefaultSetupOptions = codeScanningDefaultSetupOptions,
                CodeScanningDelegatedAlertDismissal = codeScanningDelegatedAlertDismissal,
                SecretProtection = secretProtection,
                SecretScanning = secretScanning,
                SecretScanningPushProtection = secretScanningPushProtection,
                SecretScanningDelegatedBypass = secretScanningDelegatedBypass,
                SecretScanningDelegatedBypassOptions = secretScanningDelegatedBypassOptions,
                SecretScanningValidityChecks = secretScanningValidityChecks,
                SecretScanningNonProviderPatterns = secretScanningNonProviderPatterns,
                SecretScanningGenericSecrets = secretScanningGenericSecrets,
                SecretScanningDelegatedAlertDismissal = secretScanningDelegatedAlertDismissal,
                SecretScanningExtendedMetadata = secretScanningExtendedMetadata,
                PrivateVulnerabilityReporting = privateVulnerabilityReporting,
                Enforcement = enforcement,
            };

            return await CodeSecurityCreateConfigurationAsync(
                org: org,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}