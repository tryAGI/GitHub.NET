
#nullable enable

namespace tryAGI.GitHub
{
    public partial class DependabotClient
    {
        partial void PrepareDependabotListAlertsForEnterpriseArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string enterprise,
            ref string? classification,
            ref string? state,
            ref string? severity,
            ref string? ecosystem,
            ref string? package,
            ref string? epssPercentage,
            ref global::tryAGI.GitHub.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotListAlertsForEnterpriseHasVariant2Item>>? has,
            ref string? assignee,
            ref global::tryAGI.GitHub.DependabotListAlertsForEnterpriseScope? scope,
            ref string? relationship,
            ref global::tryAGI.GitHub.DependabotListAlertsForEnterpriseSort? sort,
            ref global::tryAGI.GitHub.DependabotListAlertsForEnterpriseDirection? direction,
            ref string? before,
            ref string? after,
            ref int? perPage);
        partial void PrepareDependabotListAlertsForEnterpriseRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string enterprise,
            string? classification,
            string? state,
            string? severity,
            string? ecosystem,
            string? package,
            string? epssPercentage,
            global::tryAGI.GitHub.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotListAlertsForEnterpriseHasVariant2Item>>? has,
            string? assignee,
            global::tryAGI.GitHub.DependabotListAlertsForEnterpriseScope? scope,
            string? relationship,
            global::tryAGI.GitHub.DependabotListAlertsForEnterpriseSort? sort,
            global::tryAGI.GitHub.DependabotListAlertsForEnterpriseDirection? direction,
            string? before,
            string? after,
            int? perPage);
        partial void ProcessDependabotListAlertsForEnterpriseResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDependabotListAlertsForEnterpriseResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Dependabot alerts for an enterprise<br/>
        /// Lists Dependabot alerts for repositories that are owned by the specified enterprise.<br/>
        /// The authenticated user must be a member of the enterprise to use this endpoint.<br/>
        /// Alerts are only returned for organizations in the enterprise for which you are an organization owner or a security manager. For more information about security managers, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="classification"></param>
        /// <param name="state"></param>
        /// <param name="severity"></param>
        /// <param name="ecosystem"></param>
        /// <param name="package"></param>
        /// <param name="epssPercentage"></param>
        /// <param name="has"></param>
        /// <param name="assignee"></param>
        /// <param name="scope"></param>
        /// <param name="relationship"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotAlertWithRepository>> DependabotListAlertsForEnterpriseAsync(
            string enterprise,
            string? classification = default,
            string? state = default,
            string? severity = default,
            string? ecosystem = default,
            string? package = default,
            string? epssPercentage = default,
            global::tryAGI.GitHub.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotListAlertsForEnterpriseHasVariant2Item>>? has = default,
            string? assignee = default,
            global::tryAGI.GitHub.DependabotListAlertsForEnterpriseScope? scope = default,
            string? relationship = default,
            global::tryAGI.GitHub.DependabotListAlertsForEnterpriseSort? sort = default,
            global::tryAGI.GitHub.DependabotListAlertsForEnterpriseDirection? direction = default,
            string? before = default,
            string? after = default,
            int? perPage = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await DependabotListAlertsForEnterpriseAsResponseAsync(
                enterprise: enterprise,
                classification: classification,
                state: state,
                severity: severity,
                ecosystem: ecosystem,
                package: package,
                epssPercentage: epssPercentage,
                has: has,
                assignee: assignee,
                scope: scope,
                relationship: relationship,
                sort: sort,
                direction: direction,
                before: before,
                after: after,
                perPage: perPage,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List Dependabot alerts for an enterprise<br/>
        /// Lists Dependabot alerts for repositories that are owned by the specified enterprise.<br/>
        /// The authenticated user must be a member of the enterprise to use this endpoint.<br/>
        /// Alerts are only returned for organizations in the enterprise for which you are an organization owner or a security manager. For more information about security managers, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="classification"></param>
        /// <param name="state"></param>
        /// <param name="severity"></param>
        /// <param name="ecosystem"></param>
        /// <param name="package"></param>
        /// <param name="epssPercentage"></param>
        /// <param name="has"></param>
        /// <param name="assignee"></param>
        /// <param name="scope"></param>
        /// <param name="relationship"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotAlertWithRepository>>> DependabotListAlertsForEnterpriseAsResponseAsync(
            string enterprise,
            string? classification = default,
            string? state = default,
            string? severity = default,
            string? ecosystem = default,
            string? package = default,
            string? epssPercentage = default,
            global::tryAGI.GitHub.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotListAlertsForEnterpriseHasVariant2Item>>? has = default,
            string? assignee = default,
            global::tryAGI.GitHub.DependabotListAlertsForEnterpriseScope? scope = default,
            string? relationship = default,
            global::tryAGI.GitHub.DependabotListAlertsForEnterpriseSort? sort = default,
            global::tryAGI.GitHub.DependabotListAlertsForEnterpriseDirection? direction = default,
            string? before = default,
            string? after = default,
            int? perPage = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareDependabotListAlertsForEnterpriseArguments(
                httpClient: HttpClient,
                enterprise: ref enterprise,
                classification: ref classification,
                state: ref state,
                severity: ref severity,
                ecosystem: ref ecosystem,
                package: ref package,
                epssPercentage: ref epssPercentage,
                has: ref has,
                assignee: ref assignee,
                scope: ref scope,
                relationship: ref relationship,
                sort: ref sort,
                direction: ref direction,
                before: ref before,
                after: ref after,
                perPage: ref perPage);

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
                                path: $"/enterprises/{enterprise}/dependabot/alerts",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("classification", classification)
                                .AddOptionalParameter("state", state)
                                .AddOptionalParameter("severity", severity)
                                .AddOptionalParameter("ecosystem", ecosystem)
                                .AddOptionalParameter("package", package)
                                .AddOptionalParameter("epss_percentage", epssPercentage)
                                .AddOptionalParameter("has", has?.Match(
                static x => (global::System.Collections.Generic.IEnumerable<string?>)new string?[] { x },
                static x => (global::System.Collections.Generic.IEnumerable<string?>)global::System.Linq.Enumerable.Select(x, static item => item.ToValueString()),
                validate: false), delimiter: ",", explode: true)
                                .AddOptionalParameter("assignee", assignee)
                                .AddOptionalParameter("scope", scope?.ToValueString())
                                .AddOptionalParameter("relationship", relationship)
                                .AddOptionalParameter("sort", sort?.ToValueString())
                                .AddOptionalParameter("direction", direction?.ToValueString())
                                .AddOptionalParameter("before", before)
                                .AddOptionalParameter("after", after)
                                .AddOptionalParameter("per_page", perPage?.ToString())
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
                PrepareDependabotListAlertsForEnterpriseRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    enterprise: enterprise!,
                    classification: classification,
                    state: state,
                    severity: severity,
                    ecosystem: ecosystem,
                    package: package,
                    epssPercentage: epssPercentage,
                    has: has,
                    assignee: assignee,
                    scope: scope,
                    relationship: relationship,
                    sort: sort,
                    direction: direction,
                    before: before,
                    after: after,
                    perPage: perPage);

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
                                operationId: "DependabotListAlertsForEnterprise",
                                methodName: "DependabotListAlertsForEnterpriseAsync",
                                pathTemplate: "$\"/enterprises/{enterprise}/dependabot/alerts\"",
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
                                operationId: "DependabotListAlertsForEnterprise",
                                methodName: "DependabotListAlertsForEnterpriseAsync",
                                pathTemplate: "$\"/enterprises/{enterprise}/dependabot/alerts\"",
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
                                operationId: "DependabotListAlertsForEnterprise",
                                methodName: "DependabotListAlertsForEnterpriseAsync",
                                pathTemplate: "$\"/enterprises/{enterprise}/dependabot/alerts\"",
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
                ProcessDependabotListAlertsForEnterpriseResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "DependabotListAlertsForEnterprise",
                                methodName: "DependabotListAlertsForEnterpriseAsync",
                                pathTemplate: "$\"/enterprises/{enterprise}/dependabot/alerts\"",
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
                                operationId: "DependabotListAlertsForEnterprise",
                                methodName: "DependabotListAlertsForEnterpriseAsync",
                                pathTemplate: "$\"/enterprises/{enterprise}/dependabot/alerts\"",
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
                            //
                            if ((int)__response.StatusCode == 304)
                            {
                                string? __content_304 = null;
                                global::System.Exception? __exception_304 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_304 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_304 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_304 = __ex;
                                }


                                throw global::tryAGI.GitHub.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_304 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_304,
                                    responseBody: __content_304,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Forbidden
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::tryAGI.GitHub.BasicError? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::tryAGI.GitHub.BasicError.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::tryAGI.GitHub.BasicError.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::tryAGI.GitHub.ApiException<global::tryAGI.GitHub.BasicError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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
                                global::tryAGI.GitHub.ValidationErrorSimple? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::tryAGI.GitHub.ValidationErrorSimple.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::tryAGI.GitHub.ValidationErrorSimple.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::tryAGI.GitHub.ApiException<global::tryAGI.GitHub.ValidationErrorSimple>.Create(
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
                                ProcessDependabotListAlertsForEnterpriseResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = (global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotAlertWithRepository>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotAlertWithRepository>), JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotAlertWithRepository>>(
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
                                    var __value = await global::tryAGI.GitHub.AutoSdkPolyfills.ReadFromJsonAsync<global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotAlertWithRepository>>(__response.Content, JsonSerializerContext, __effectiveCancellationToken).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotAlertWithRepository>>(
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