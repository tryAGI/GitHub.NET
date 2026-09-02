
#nullable enable

namespace tryAGI.GitHub
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsCreateArtifactDeploymentRecordArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordRequest request);
        partial void PrepareOrgsCreateArtifactDeploymentRecordRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordRequest request);
        partial void ProcessOrgsCreateArtifactDeploymentRecordResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsCreateArtifactDeploymentRecordResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create an artifact deployment record<br/>
        /// Create or update deployment records for an artifact associated<br/>
        /// with an organization.<br/>
        /// This endpoint allows you to record information about a specific<br/>
        /// artifact, such as its name, digest, environments, cluster, and<br/>
        /// deployment.<br/>
        /// The deployment name has to be uniqe within a cluster (i.e a<br/>
        /// combination of logical, physical environment and cluster) as it<br/>
        /// identifies unique deployment.<br/>
        /// Multiple requests for the same combination of logical, physical<br/>
        /// environment, cluster and deployment name will only create one<br/>
        /// record, successive request will update the existing record.<br/>
        /// This allows for a stable tracking of a deployment where the actual<br/>
        /// deployed artifact can change over time.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordResponse> OrgsCreateArtifactDeploymentRecordAsync(
            string org,

            global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await OrgsCreateArtifactDeploymentRecordAsResponseAsync(
                org: org,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Create an artifact deployment record<br/>
        /// Create or update deployment records for an artifact associated<br/>
        /// with an organization.<br/>
        /// This endpoint allows you to record information about a specific<br/>
        /// artifact, such as its name, digest, environments, cluster, and<br/>
        /// deployment.<br/>
        /// The deployment name has to be uniqe within a cluster (i.e a<br/>
        /// combination of logical, physical environment and cluster) as it<br/>
        /// identifies unique deployment.<br/>
        /// Multiple requests for the same combination of logical, physical<br/>
        /// environment, cluster and deployment name will only create one<br/>
        /// record, successive request will update the existing record.<br/>
        /// This allows for a stable tracking of a deployment where the actual<br/>
        /// deployed artifact can change over time.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordResponse>> OrgsCreateArtifactDeploymentRecordAsResponseAsync(
            string org,

            global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOrgsCreateArtifactDeploymentRecordArguments(
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
                                path: $"/orgs/{org}/artifacts/metadata/deployment-record",
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
                PrepareOrgsCreateArtifactDeploymentRecordRequest(
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
                                operationId: "OrgsCreateArtifactDeploymentRecord",
                                methodName: "OrgsCreateArtifactDeploymentRecordAsync",
                                pathTemplate: "$\"/orgs/{org}/artifacts/metadata/deployment-record\"",
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
                                operationId: "OrgsCreateArtifactDeploymentRecord",
                                methodName: "OrgsCreateArtifactDeploymentRecordAsync",
                                pathTemplate: "$\"/orgs/{org}/artifacts/metadata/deployment-record\"",
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
                                operationId: "OrgsCreateArtifactDeploymentRecord",
                                methodName: "OrgsCreateArtifactDeploymentRecordAsync",
                                pathTemplate: "$\"/orgs/{org}/artifacts/metadata/deployment-record\"",
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
                ProcessOrgsCreateArtifactDeploymentRecordResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::tryAGI.GitHub.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "OrgsCreateArtifactDeploymentRecord",
                                methodName: "OrgsCreateArtifactDeploymentRecordAsync",
                                pathTemplate: "$\"/orgs/{org}/artifacts/metadata/deployment-record\"",
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
                                operationId: "OrgsCreateArtifactDeploymentRecord",
                                methodName: "OrgsCreateArtifactDeploymentRecordAsync",
                                pathTemplate: "$\"/orgs/{org}/artifacts/metadata/deployment-record\"",
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
                                ProcessOrgsCreateArtifactDeploymentRecordResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordResponse>(
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

                                    var __value = await global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordResponse>(
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
        /// Create an artifact deployment record<br/>
        /// Create or update deployment records for an artifact associated<br/>
        /// with an organization.<br/>
        /// This endpoint allows you to record information about a specific<br/>
        /// artifact, such as its name, digest, environments, cluster, and<br/>
        /// deployment.<br/>
        /// The deployment name has to be uniqe within a cluster (i.e a<br/>
        /// combination of logical, physical environment and cluster) as it<br/>
        /// identifies unique deployment.<br/>
        /// Multiple requests for the same combination of logical, physical<br/>
        /// environment, cluster and deployment name will only create one<br/>
        /// record, successive request will update the existing record.<br/>
        /// This allows for a stable tracking of a deployment where the actual<br/>
        /// deployed artifact can change over time.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name">
        /// The name of the artifact.<br/>
        /// Example: libfoo
        /// </param>
        /// <param name="digest">
        /// The hex encoded digest of the artifact.
        /// </param>
        /// <param name="version">
        /// The artifact version.<br/>
        /// Example: 1.2.3
        /// </param>
        /// <param name="status">
        /// The status of the artifact. Can be either deployed or decommissioned.
        /// </param>
        /// <param name="logicalEnvironment">
        /// The stage of the deployment.
        /// </param>
        /// <param name="physicalEnvironment">
        /// The physical region of the deployment.
        /// </param>
        /// <param name="cluster">
        /// The deployment cluster.
        /// </param>
        /// <param name="deploymentName">
        /// The unique identifier for the deployment represented by the new record. To accommodate differing<br/>
        /// containers and namespaces within a cluster, the following format is recommended:<br/>
        /// {namespaceName}-{deploymentName}-{containerName}.
        /// </param>
        /// <param name="tags">
        /// The tags associated with the deployment.
        /// </param>
        /// <param name="runtimeRisks">
        /// A list of runtime risks associated with the deployment.
        /// </param>
        /// <param name="githubRepository">
        /// The name of the GitHub repository associated with the artifact. This should be used<br/>
        /// when there are no provenance attestations available for the artifact. The repository<br/>
        /// must belong to the organization specified in the path parameter.<br/>
        /// If a provenance attestation is available for the artifact, the API will use<br/>
        /// the repository information from the attestation instead of this parameter.<br/>
        /// Example: my-github-repo
        /// </param>
        /// <param name="returnRecords">
        /// If true, the endpoint will return the created or updated record in the response body.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordResponse> OrgsCreateArtifactDeploymentRecordAsync(
            string org,
            string name,
            string digest,
            global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordRequestStatus status,
            string logicalEnvironment,
            string deploymentName,
            string? version = default,
            string? physicalEnvironment = default,
            string? cluster = default,
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordRequestRuntimeRisk>? runtimeRisks = default,
            string? githubRepository = default,
            bool? returnRecords = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordRequest
            {
                Name = name,
                Digest = digest,
                Version = version,
                Status = status,
                LogicalEnvironment = logicalEnvironment,
                PhysicalEnvironment = physicalEnvironment,
                Cluster = cluster,
                DeploymentName = deploymentName,
                Tags = tags,
                RuntimeRisks = runtimeRisks,
                GithubRepository = githubRepository,
                ReturnRecords = returnRecords,
            };

            return await OrgsCreateArtifactDeploymentRecordAsync(
                org: org,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}