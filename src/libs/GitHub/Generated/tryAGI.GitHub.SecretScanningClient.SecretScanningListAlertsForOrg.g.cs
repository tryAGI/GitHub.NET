
#nullable enable

namespace tryAGI.GitHub
{
    public partial class SecretScanningClient
    {
        partial void PrepareSecretScanningListAlertsForOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref global::tryAGI.GitHub.SecretScanningListAlertsForOrgState? state,
            ref string? secretType,
            ref string? excludeSecretTypes,
            ref string? excludeProviders,
            ref string? providers,
            ref string? resolution,
            ref string? assignee,
            ref global::tryAGI.GitHub.SecretScanningListAlertsForOrgSort? sort,
            ref global::tryAGI.GitHub.SecretScanningListAlertsForOrgDirection? direction,
            ref int? page,
            ref int? perPage,
            ref string? before,
            ref string? after,
            ref string? validity,
            ref bool? isPubliclyLeaked,
            ref bool? isMultiRepo,
            ref bool? hideSecret,
            ref bool? isBypassed,
            ref string? includedMetadata,
            ref string? ownerEmailHash);
        partial void PrepareSecretScanningListAlertsForOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::tryAGI.GitHub.SecretScanningListAlertsForOrgState? state,
            string? secretType,
            string? excludeSecretTypes,
            string? excludeProviders,
            string? providers,
            string? resolution,
            string? assignee,
            global::tryAGI.GitHub.SecretScanningListAlertsForOrgSort? sort,
            global::tryAGI.GitHub.SecretScanningListAlertsForOrgDirection? direction,
            int? page,
            int? perPage,
            string? before,
            string? after,
            string? validity,
            bool? isPubliclyLeaked,
            bool? isMultiRepo,
            bool? hideSecret,
            bool? isBypassed,
            string? includedMetadata,
            string? ownerEmailHash);
        partial void ProcessSecretScanningListAlertsForOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSecretScanningListAlertsForOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List secret scanning alerts for an organization<br/>
        /// Lists secret scanning alerts for eligible repositories in an organization, from newest to oldest.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="state"></param>
        /// <param name="secretType"></param>
        /// <param name="excludeSecretTypes"></param>
        /// <param name="excludeProviders"></param>
        /// <param name="providers"></param>
        /// <param name="resolution"></param>
        /// <param name="assignee"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="validity"></param>
        /// <param name="isPubliclyLeaked">
        /// Default Value: false
        /// </param>
        /// <param name="isMultiRepo">
        /// Default Value: false
        /// </param>
        /// <param name="hideSecret">
        /// Default Value: false
        /// </param>
        /// <param name="isBypassed"></param>
        /// <param name="includedMetadata"></param>
        /// <param name="ownerEmailHash"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrganizationSecretScanningAlert>> SecretScanningListAlertsForOrgAsync(
            string org,
            global::tryAGI.GitHub.SecretScanningListAlertsForOrgState? state = default,
            string? secretType = default,
            string? excludeSecretTypes = default,
            string? excludeProviders = default,
            string? providers = default,
            string? resolution = default,
            string? assignee = default,
            global::tryAGI.GitHub.SecretScanningListAlertsForOrgSort? sort = default,
            global::tryAGI.GitHub.SecretScanningListAlertsForOrgDirection? direction = default,
            int? page = default,
            int? perPage = default,
            string? before = default,
            string? after = default,
            string? validity = default,
            bool? isPubliclyLeaked = default,
            bool? isMultiRepo = default,
            bool? hideSecret = default,
            bool? isBypassed = default,
            string? includedMetadata = default,
            string? ownerEmailHash = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await SecretScanningListAlertsForOrgAsResponseAsync(
                org: org,
                state: state,
                secretType: secretType,
                excludeSecretTypes: excludeSecretTypes,
                excludeProviders: excludeProviders,
                providers: providers,
                resolution: resolution,
                assignee: assignee,
                sort: sort,
                direction: direction,
                page: page,
                perPage: perPage,
                before: before,
                after: after,
                validity: validity,
                isPubliclyLeaked: isPubliclyLeaked,
                isMultiRepo: isMultiRepo,
                hideSecret: hideSecret,
                isBypassed: isBypassed,
                includedMetadata: includedMetadata,
                ownerEmailHash: ownerEmailHash,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List secret scanning alerts for an organization<br/>
        /// Lists secret scanning alerts for eligible repositories in an organization, from newest to oldest.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="state"></param>
        /// <param name="secretType"></param>
        /// <param name="excludeSecretTypes"></param>
        /// <param name="excludeProviders"></param>
        /// <param name="providers"></param>
        /// <param name="resolution"></param>
        /// <param name="assignee"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="validity"></param>
        /// <param name="isPubliclyLeaked">
        /// Default Value: false
        /// </param>
        /// <param name="isMultiRepo">
        /// Default Value: false
        /// </param>
        /// <param name="hideSecret">
        /// Default Value: false
        /// </param>
        /// <param name="isBypassed"></param>
        /// <param name="includedMetadata"></param>
        /// <param name="ownerEmailHash"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrganizationSecretScanningAlert>>> SecretScanningListAlertsForOrgAsResponseAsync(
            string org,
            global::tryAGI.GitHub.SecretScanningListAlertsForOrgState? state = default,
            string? secretType = default,
            string? excludeSecretTypes = default,
            string? excludeProviders = default,
            string? providers = default,
            string? resolution = default,
            string? assignee = default,
            global::tryAGI.GitHub.SecretScanningListAlertsForOrgSort? sort = default,
            global::tryAGI.GitHub.SecretScanningListAlertsForOrgDirection? direction = default,
            int? page = default,
            int? perPage = default,
            string? before = default,
            string? after = default,
            string? validity = default,
            bool? isPubliclyLeaked = default,
            bool? isMultiRepo = default,
            bool? hideSecret = default,
            bool? isBypassed = default,
            string? includedMetadata = default,
            string? ownerEmailHash = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareSecretScanningListAlertsForOrgArguments(
                httpClient: HttpClient,
                org: ref org,
                state: ref state,
                secretType: ref secretType,
                excludeSecretTypes: ref excludeSecretTypes,
                excludeProviders: ref excludeProviders,
                providers: ref providers,
                resolution: ref resolution,
                assignee: ref assignee,
                sort: ref sort,
                direction: ref direction,
                page: ref page,
                perPage: ref perPage,
                before: ref before,
                after: ref after,
                validity: ref validity,
                isPubliclyLeaked: ref isPubliclyLeaked,
                isMultiRepo: ref isMultiRepo,
                hideSecret: ref hideSecret,
                isBypassed: ref isBypassed,
                includedMetadata: ref includedMetadata,
                ownerEmailHash: ref ownerEmailHash);

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
                                path: $"/orgs/{org}/secret-scanning/alerts",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("state", state?.ToValueString())
                                .AddOptionalParameter("secret_type", secretType)
                                .AddOptionalParameter("exclude_secret_types", excludeSecretTypes)
                                .AddOptionalParameter("exclude_providers", excludeProviders)
                                .AddOptionalParameter("providers", providers)
                                .AddOptionalParameter("resolution", resolution)
                                .AddOptionalParameter("assignee", assignee)
                                .AddOptionalParameter("sort", sort?.ToValueString())
                                .AddOptionalParameter("direction", direction?.ToValueString())
                                .AddOptionalParameter("page", page?.ToString())
                                .AddOptionalParameter("per_page", perPage?.ToString())
                                .AddOptionalParameter("before", before)
                                .AddOptionalParameter("after", after)
                                .AddOptionalParameter("validity", validity)
                                .AddOptionalParameter("is_publicly_leaked", isPubliclyLeaked?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("is_multi_repo", isMultiRepo?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("hide_secret", hideSecret?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("is_bypassed", isBypassed?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("included_metadata", includedMetadata)
                                .AddOptionalParameter("owner_email_hash", ownerEmailHash)
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
                global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareSecretScanningListAlertsForOrgRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    org: org!,
                    state: state,
                    secretType: secretType,
                    excludeSecretTypes: excludeSecretTypes,
                    excludeProviders: excludeProviders,
                    providers: providers,
                    resolution: resolution,
                    assignee: assignee,
                    sort: sort,
                    direction: direction,
                    page: page,
                    perPage: perPage,
                    before: before,
                    after: after,
                    validity: validity,
                    isPubliclyLeaked: isPubliclyLeaked,
                    isMultiRepo: isMultiRepo,
                    hideSecret: hideSecret,
                    isBypassed: isBypassed,
                    includedMetadata: includedMetadata,
                    ownerEmailHash: ownerEmailHash);

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
                                operationId: "SecretScanningListAlertsForOrg",
                                methodName: "SecretScanningListAlertsForOrgAsync",
                                pathTemplate: "$\"/orgs/{org}/secret-scanning/alerts\"",
                                httpMethod: "GET",
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
                                operationId: "SecretScanningListAlertsForOrg",
                                methodName: "SecretScanningListAlertsForOrgAsync",
                                pathTemplate: "$\"/orgs/{org}/secret-scanning/alerts\"",
                                httpMethod: "GET",
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
                                operationId: "SecretScanningListAlertsForOrg",
                                methodName: "SecretScanningListAlertsForOrgAsync",
                                pathTemplate: "$\"/orgs/{org}/secret-scanning/alerts\"",
                                httpMethod: "GET",
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
                ProcessSecretScanningListAlertsForOrgResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SecretScanningListAlertsForOrg",
                                methodName: "SecretScanningListAlertsForOrgAsync",
                                pathTemplate: "$\"/orgs/{org}/secret-scanning/alerts\"",
                                httpMethod: "GET",
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
                                operationId: "SecretScanningListAlertsForOrg",
                                methodName: "SecretScanningListAlertsForOrgAsync",
                                pathTemplate: "$\"/orgs/{org}/secret-scanning/alerts\"",
                                httpMethod: "GET",
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
                            // Service unavailable
                            if ((int)__response.StatusCode == 503)
                            {
                                string? __content_503 = null;
                                global::System.Exception? __exception_503 = null;
                                global::tryAGI.GitHub.SecretScanningListAlertsForOrgResponse? __value_503 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_503 = global::tryAGI.GitHub.SecretScanningListAlertsForOrgResponse.FromJson(__content_503, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_503 = global::tryAGI.GitHub.SecretScanningListAlertsForOrgResponse.FromJson(__content_503, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_503 = __ex;
                                }


                                throw global::tryAGI.GitHub.ApiException<global::tryAGI.GitHub.SecretScanningListAlertsForOrgResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_503,
                                    responseBody: __content_503,
                                    responseObject: __value_503,
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
                                ProcessSecretScanningListAlertsForOrgResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = (global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrganizationSecretScanningAlert>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrganizationSecretScanningAlert>), JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrganizationSecretScanningAlert>>(
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
                                    var __value = await global::tryAGI.GitHub.AutoSdkPolyfills.ReadFromJsonAsync<global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrganizationSecretScanningAlert>>(__response.Content, JsonSerializerContext, __effectiveCancellationToken).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrganizationSecretScanningAlert>>(
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
    }
}