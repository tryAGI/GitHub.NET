
#nullable enable

namespace tryAGI.GitHub
{
    public partial class ActionsClient
    {
        partial void PrepareActionsListWorkflowRunsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref global::tryAGI.GitHub.OneOf<int?, string> workflowId,
            ref string? actor,
            ref string? branch,
            ref string? @event,
            ref global::tryAGI.GitHub.ActionsListWorkflowRunsStatus? status,
            ref int? perPage,
            ref int? page,
            ref global::System.DateTime? created,
            ref bool? excludePullRequests,
            ref long? checkSuiteId,
            ref string? headSha);
        partial void PrepareActionsListWorkflowRunsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::tryAGI.GitHub.OneOf<int?, string> workflowId,
            string? actor,
            string? branch,
            string? @event,
            global::tryAGI.GitHub.ActionsListWorkflowRunsStatus? status,
            int? perPage,
            int? page,
            global::System.DateTime? created,
            bool? excludePullRequests,
            long? checkSuiteId,
            string? headSha);
        partial void ProcessActionsListWorkflowRunsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActionsListWorkflowRunsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List workflow runs for a workflow<br/>
        /// List all workflow runs for a workflow. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#parameters).<br/>
        /// Anyone with read access to the repository can use this endpoint<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.<br/>
        /// This endpoint will return up to 1,000 results for each search when using the following parameters: `actor`, `branch`, `check_suite_id`, `created`, `event`, `head_sha`, `status`.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="workflowId"></param>
        /// <param name="actor"></param>
        /// <param name="branch"></param>
        /// <param name="event"></param>
        /// <param name="status"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="created"></param>
        /// <param name="excludePullRequests">
        /// Default Value: false
        /// </param>
        /// <param name="checkSuiteId"></param>
        /// <param name="headSha"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ActionsListWorkflowRunsResponse> ActionsListWorkflowRunsAsync(
            string owner,
            string repo,
            global::tryAGI.GitHub.OneOf<int?, string> workflowId,
            string? actor = default,
            string? branch = default,
            string? @event = default,
            global::tryAGI.GitHub.ActionsListWorkflowRunsStatus? status = default,
            int? perPage = default,
            int? page = default,
            global::System.DateTime? created = default,
            bool? excludePullRequests = default,
            long? checkSuiteId = default,
            string? headSha = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ActionsListWorkflowRunsAsResponseAsync(
                owner: owner,
                repo: repo,
                workflowId: workflowId,
                actor: actor,
                branch: branch,
                @event: @event,
                status: status,
                perPage: perPage,
                page: page,
                created: created,
                excludePullRequests: excludePullRequests,
                checkSuiteId: checkSuiteId,
                headSha: headSha,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List workflow runs for a workflow<br/>
        /// List all workflow runs for a workflow. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#parameters).<br/>
        /// Anyone with read access to the repository can use this endpoint<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.<br/>
        /// This endpoint will return up to 1,000 results for each search when using the following parameters: `actor`, `branch`, `check_suite_id`, `created`, `event`, `head_sha`, `status`.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="workflowId"></param>
        /// <param name="actor"></param>
        /// <param name="branch"></param>
        /// <param name="event"></param>
        /// <param name="status"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="created"></param>
        /// <param name="excludePullRequests">
        /// Default Value: false
        /// </param>
        /// <param name="checkSuiteId"></param>
        /// <param name="headSha"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ActionsListWorkflowRunsResponse>> ActionsListWorkflowRunsAsResponseAsync(
            string owner,
            string repo,
            global::tryAGI.GitHub.OneOf<int?, string> workflowId,
            string? actor = default,
            string? branch = default,
            string? @event = default,
            global::tryAGI.GitHub.ActionsListWorkflowRunsStatus? status = default,
            int? perPage = default,
            int? page = default,
            global::System.DateTime? created = default,
            bool? excludePullRequests = default,
            long? checkSuiteId = default,
            string? headSha = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareActionsListWorkflowRunsArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                workflowId: ref workflowId,
                actor: ref actor,
                branch: ref branch,
                @event: ref @event,
                status: ref status,
                perPage: ref perPage,
                page: ref page,
                created: ref created,
                excludePullRequests: ref excludePullRequests,
                checkSuiteId: ref checkSuiteId,
                headSha: ref headSha);

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
                                path: $"/repos/{owner}/{repo}/actions/workflows/{workflowId}/runs",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("actor", actor)
                                .AddOptionalParameter("branch", branch)
                                .AddOptionalParameter("event", @event)
                                .AddOptionalParameter("status", status?.ToValueString())
                                .AddOptionalParameter("per_page", perPage?.ToString())
                                .AddOptionalParameter("page", page?.ToString())
                                .AddOptionalParameter("created", created?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("exclude_pull_requests", excludePullRequests?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("check_suite_id", checkSuiteId?.ToString())
                                .AddOptionalParameter("head_sha", headSha)
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
                PrepareActionsListWorkflowRunsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    owner: owner!,
                    repo: repo!,
                    workflowId: workflowId!,
                    actor: actor,
                    branch: branch,
                    @event: @event,
                    status: status,
                    perPage: perPage,
                    page: page,
                    created: created,
                    excludePullRequests: excludePullRequests,
                    checkSuiteId: checkSuiteId,
                    headSha: headSha);

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
                                operationId: "ActionsListWorkflowRuns",
                                methodName: "ActionsListWorkflowRunsAsync",
                                pathTemplate: "$\"/repos/{owner}/{repo}/actions/workflows/{workflowId}/runs\"",
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
                                operationId: "ActionsListWorkflowRuns",
                                methodName: "ActionsListWorkflowRunsAsync",
                                pathTemplate: "$\"/repos/{owner}/{repo}/actions/workflows/{workflowId}/runs\"",
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
                                operationId: "ActionsListWorkflowRuns",
                                methodName: "ActionsListWorkflowRunsAsync",
                                pathTemplate: "$\"/repos/{owner}/{repo}/actions/workflows/{workflowId}/runs\"",
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
                ProcessActionsListWorkflowRunsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ActionsListWorkflowRuns",
                                methodName: "ActionsListWorkflowRunsAsync",
                                pathTemplate: "$\"/repos/{owner}/{repo}/actions/workflows/{workflowId}/runs\"",
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
                                operationId: "ActionsListWorkflowRuns",
                                methodName: "ActionsListWorkflowRunsAsync",
                                pathTemplate: "$\"/repos/{owner}/{repo}/actions/workflows/{workflowId}/runs\"",
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
                                ProcessActionsListWorkflowRunsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::tryAGI.GitHub.ActionsListWorkflowRunsResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ActionsListWorkflowRunsResponse>(
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

                                    var __value = await global::tryAGI.GitHub.ActionsListWorkflowRunsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ActionsListWorkflowRunsResponse>(
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
        /// Wraps ActionsListWorkflowRunsAsync as an IAsyncEnumerable&lt;global::tryAGI.GitHub.WorkflowRun&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="workflowId"></param>
        /// <param name="actor"></param>
        /// <param name="branch"></param>
        /// <param name="event"></param>
        /// <param name="status"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="created"></param>
        /// <param name="excludePullRequests">
        /// Default Value: false
        /// </param>
        /// <param name="checkSuiteId"></param>
        /// <param name="headSha"></param>
        /// <param name="page">Initial page number to start enumerating from. Defaults to 1.</param>
        /// <param name="cancellationToken"></param>
        public global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.GitHub.WorkflowRun> ActionsListWorkflowRunsAutoPagingAsync(
            string owner,
            string repo,
            global::tryAGI.GitHub.OneOf<int?, string> workflowId,             string? actor = default,
            string? branch = default,
            string? @event = default,
            global::tryAGI.GitHub.ActionsListWorkflowRunsStatus? status = default,
            int? perPage = default,
            global::System.DateTime? created = default,
            bool? excludePullRequests = default,
            long? checkSuiteId = default,
            string? headSha = default,
            int? page = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return global::tryAGI.GitHub.AutoSDKPager.OffsetAsync<global::tryAGI.GitHub.ActionsListWorkflowRunsResponse, global::tryAGI.GitHub.WorkflowRun>(
                fetchPage: (__page, __ct) => ActionsListWorkflowRunsAsync(
                    owner: owner,
                    repo: repo,
                    workflowId: workflowId,
                    actor: actor,
                    branch: branch,
                    @event: @event,
                    status: status,
                    perPage: perPage,
                    page: __page,
                    created: created,
                    excludePullRequests: excludePullRequests,
                    checkSuiteId: checkSuiteId,
                    headSha: headSha,
                    cancellationToken: __ct),
                extractItems: static __response => __response is null
                    ? null
                    : (global::System.Collections.Generic.IEnumerable<global::tryAGI.GitHub.WorkflowRun>?)__response.WorkflowRuns,
                initialPage: page ?? 1,
                cancellationToken: cancellationToken);
        }

    }
}