
#nullable enable

namespace tryAGI.GitHub
{
    public partial class ReposClient
    {

        private static readonly global::tryAGI.GitHub.AutoSDKServer[] s_ReposUpdateReleaseServers = new global::tryAGI.GitHub.AutoSDKServer[]
        {            new global::tryAGI.GitHub.AutoSDKServer(
                id: "https-api-github-com",
                name: "api.github.com",
                url: "https://api.github.com/",
                description: ""),
        };
        partial void PrepareReposUpdateReleaseArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int releaseId,
            global::tryAGI.GitHub.ReposUpdateReleaseRequest request);
        partial void PrepareReposUpdateReleaseRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int releaseId,
            global::tryAGI.GitHub.ReposUpdateReleaseRequest request);
        partial void ProcessReposUpdateReleaseResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposUpdateReleaseResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a release<br/>
        /// Users with push access to the repository can edit a release.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; If the resolved target commit (the new value of `target_commitish` if you are changing it, otherwise the existing target) adds or modifies any file under `.github/workflows/` relative to the repository's default branch, the authenticating token must be authorized to modify workflows. Otherwise, this endpoint returns `404 Not Found`; some authentication paths surface `403 Resource not accessible by integration` instead.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `workflow` scope when the resolved target commit modifies workflow files. Fine-grained access tokens and GitHub App installation tokens also need the "Workflows" repository permission (write). The `GITHUB_TOKEN` available to GitHub Actions cannot be authorized for this; for more information, see "[Automatic token authentication](https://docs.github.com/actions/security-guides/automatic-token-authentication#permissions-for-the-github_token)".
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="releaseId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.GitHub.Release> ReposUpdateReleaseAsync(
            string owner,
            string repo,
            int releaseId,

            global::tryAGI.GitHub.ReposUpdateReleaseRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ReposUpdateReleaseAsResponseAsync(
                owner: owner,
                repo: repo,
                releaseId: releaseId,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Update a release<br/>
        /// Users with push access to the repository can edit a release.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; If the resolved target commit (the new value of `target_commitish` if you are changing it, otherwise the existing target) adds or modifies any file under `.github/workflows/` relative to the repository's default branch, the authenticating token must be authorized to modify workflows. Otherwise, this endpoint returns `404 Not Found`; some authentication paths surface `403 Resource not accessible by integration` instead.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `workflow` scope when the resolved target commit modifies workflow files. Fine-grained access tokens and GitHub App installation tokens also need the "Workflows" repository permission (write). The `GITHUB_TOKEN` available to GitHub Actions cannot be authorized for this; for more information, see "[Automatic token authentication](https://docs.github.com/actions/security-guides/automatic-token-authentication#permissions-for-the-github_token)".
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="releaseId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.Release>> ReposUpdateReleaseAsResponseAsync(
            string owner,
            string repo,
            int releaseId,

            global::tryAGI.GitHub.ReposUpdateReleaseRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareReposUpdateReleaseArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                releaseId: ref releaseId,
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
                                path: $"/repos/{owner}/{repo}/releases/{releaseId}",
                                baseUri: ResolveBaseUri(
                                servers: s_ReposUpdateReleaseServers,
                                defaultBaseUrl: "https://api.github.com/"));
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
                PrepareReposUpdateReleaseRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    owner: owner!,
                    repo: repo!,
                    releaseId: releaseId!,
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
                                operationId: "ReposUpdateRelease",
                                methodName: "ReposUpdateReleaseAsync",
                                pathTemplate: "$\"/repos/{owner}/{repo}/releases/{releaseId}\"",
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
                                operationId: "ReposUpdateRelease",
                                methodName: "ReposUpdateReleaseAsync",
                                pathTemplate: "$\"/repos/{owner}/{repo}/releases/{releaseId}\"",
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
                                operationId: "ReposUpdateRelease",
                                methodName: "ReposUpdateReleaseAsync",
                                pathTemplate: "$\"/repos/{owner}/{repo}/releases/{releaseId}\"",
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
                ProcessReposUpdateReleaseResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ReposUpdateRelease",
                                methodName: "ReposUpdateReleaseAsync",
                                pathTemplate: "$\"/repos/{owner}/{repo}/releases/{releaseId}\"",
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
                                operationId: "ReposUpdateRelease",
                                methodName: "ReposUpdateReleaseAsync",
                                pathTemplate: "$\"/repos/{owner}/{repo}/releases/{releaseId}\"",
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
                            // Not Found if the discussion category name is invalid
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
                                ProcessReposUpdateReleaseResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::tryAGI.GitHub.Release.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.Release>(
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

                                    var __value = await global::tryAGI.GitHub.Release.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.Release>(
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
        /// Update a release<br/>
        /// Users with push access to the repository can edit a release.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; If the resolved target commit (the new value of `target_commitish` if you are changing it, otherwise the existing target) adds or modifies any file under `.github/workflows/` relative to the repository's default branch, the authenticating token must be authorized to modify workflows. Otherwise, this endpoint returns `404 Not Found`; some authentication paths surface `403 Resource not accessible by integration` instead.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `workflow` scope when the resolved target commit modifies workflow files. Fine-grained access tokens and GitHub App installation tokens also need the "Workflows" repository permission (write). The `GITHUB_TOKEN` available to GitHub Actions cannot be authorized for this; for more information, see "[Automatic token authentication](https://docs.github.com/actions/security-guides/automatic-token-authentication#permissions-for-the-github_token)".
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="releaseId"></param>
        /// <param name="tagName">
        /// The name of the tag.
        /// </param>
        /// <param name="targetCommitish">
        /// Specifies the commitish value that determines where the Git tag is created from. Can be any branch or commit SHA. Unused if the Git tag already exists. Default: the repository's default branch.
        /// </param>
        /// <param name="name">
        /// The name of the release.
        /// </param>
        /// <param name="body">
        /// Text describing the contents of the tag.
        /// </param>
        /// <param name="draft">
        /// `true` makes the release a draft, and `false` publishes the release.
        /// </param>
        /// <param name="prerelease">
        /// `true` to identify the release as a prerelease, `false` to identify the release as a full release.
        /// </param>
        /// <param name="makeLatest">
        /// Specifies whether this release should be set as the latest release for the repository. Drafts and prereleases cannot be set as latest. Defaults to `true` for newly published releases. `legacy` specifies that the latest release should be determined based on the release creation date and higher semantic version.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="discussionCategoryName">
        /// If specified, a discussion of the specified category is created and linked to the release. The value must be a category that already exists in the repository. If there is already a discussion linked to the release, this parameter is ignored. For more information, see "[Managing categories for discussions in your repository](https://docs.github.com/discussions/managing-discussions-for-your-community/managing-categories-for-discussions-in-your-repository)."
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.GitHub.Release> ReposUpdateReleaseAsync(
            string owner,
            string repo,
            int releaseId,
            string? tagName = default,
            string? targetCommitish = default,
            string? name = default,
            string? body = default,
            bool? draft = default,
            bool? prerelease = default,
            global::tryAGI.GitHub.ReposUpdateReleaseRequestMakeLatest? makeLatest = default,
            string? discussionCategoryName = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::tryAGI.GitHub.ReposUpdateReleaseRequest
            {
                TagName = tagName,
                TargetCommitish = targetCommitish,
                Name = name,
                Body = body,
                Draft = draft,
                Prerelease = prerelease,
                MakeLatest = makeLatest,
                DiscussionCategoryName = discussionCategoryName,
            };

            return await ReposUpdateReleaseAsync(
                owner: owner,
                repo: repo,
                releaseId: releaseId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}