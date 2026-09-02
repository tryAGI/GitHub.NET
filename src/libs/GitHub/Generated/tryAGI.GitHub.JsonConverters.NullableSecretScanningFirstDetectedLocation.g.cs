#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.GitHub.JsonConverters
{
    /// <inheritdoc />
    public class NullableSecretScanningFirstDetectedLocationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.GitHub.NullableSecretScanningFirstDetectedLocation>
    {
        /// <inheritdoc />
        public override global::tryAGI.GitHub.NullableSecretScanningFirstDetectedLocation Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("blob_sha")) __score0++;
            if (__jsonProps.Contains("blob_url")) __score0++;
            if (__jsonProps.Contains("commit_sha")) __score0++;
            if (__jsonProps.Contains("commit_url")) __score0++;
            if (__jsonProps.Contains("end_column")) __score0++;
            if (__jsonProps.Contains("end_line")) __score0++;
            if (__jsonProps.Contains("html_url")) __score0++;
            if (__jsonProps.Contains("path")) __score0++;
            if (__jsonProps.Contains("start_column")) __score0++;
            if (__jsonProps.Contains("start_line")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("blob_sha")) __score1++;
            if (__jsonProps.Contains("commit_sha")) __score1++;
            if (__jsonProps.Contains("commit_url")) __score1++;
            if (__jsonProps.Contains("end_column")) __score1++;
            if (__jsonProps.Contains("end_line")) __score1++;
            if (__jsonProps.Contains("page_url")) __score1++;
            if (__jsonProps.Contains("path")) __score1++;
            if (__jsonProps.Contains("start_column")) __score1++;
            if (__jsonProps.Contains("start_line")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("html_url")) __score2++;
            if (__jsonProps.Contains("issue_title_url")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("html_url")) __score3++;
            if (__jsonProps.Contains("issue_body_url")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("html_url")) __score4++;
            if (__jsonProps.Contains("issue_comment_url")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("discussion_title_url")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("discussion_body_url")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("discussion_comment_url")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("html_url")) __score8++;
            if (__jsonProps.Contains("pull_request_title_url")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("html_url")) __score9++;
            if (__jsonProps.Contains("pull_request_body_url")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("html_url")) __score10++;
            if (__jsonProps.Contains("pull_request_comment_url")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("html_url")) __score11++;
            if (__jsonProps.Contains("pull_request_review_url")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("html_url")) __score12++;
            if (__jsonProps.Contains("pull_request_review_comment_url")) __score12++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }

            global::tryAGI.GitHub.SecretScanningLocationCommit? commit = default;
            global::tryAGI.GitHub.SecretScanningLocationWikiCommit? wikiCommit = default;
            global::tryAGI.GitHub.SecretScanningLocationIssueTitle? issueTitle = default;
            global::tryAGI.GitHub.SecretScanningLocationIssueBody? issueBody = default;
            global::tryAGI.GitHub.SecretScanningLocationIssueComment? issueComment = default;
            global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle? discussionTitle = default;
            global::tryAGI.GitHub.SecretScanningLocationDiscussionBody? discussionBody = default;
            global::tryAGI.GitHub.SecretScanningLocationDiscussionComment? discussionComment = default;
            global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle? pullRequestTitle = default;
            global::tryAGI.GitHub.SecretScanningLocationPullRequestBody? pullRequestBody = default;
            global::tryAGI.GitHub.SecretScanningLocationPullRequestComment? pullRequestComment = default;
            global::tryAGI.GitHub.SecretScanningLocationPullRequestReview? pullRequestReview = default;
            global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment? pullRequestReviewComment = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationCommit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationCommit> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationCommit).Name}");
                        commit = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationWikiCommit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationWikiCommit> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationWikiCommit).Name}");
                        wikiCommit = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationIssueTitle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationIssueTitle> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationIssueTitle).Name}");
                        issueTitle = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationIssueBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationIssueBody> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationIssueBody).Name}");
                        issueBody = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationIssueComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationIssueComment> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationIssueComment).Name}");
                        issueComment = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle).Name}");
                        discussionTitle = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationDiscussionBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationDiscussionBody> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationDiscussionBody).Name}");
                        discussionBody = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationDiscussionComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationDiscussionComment> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationDiscussionComment).Name}");
                        discussionComment = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle).Name}");
                        pullRequestTitle = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationPullRequestBody> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestBody).Name}");
                        pullRequestBody = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationPullRequestComment> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestComment).Name}");
                        pullRequestComment = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestReview), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationPullRequestReview> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestReview).Name}");
                        pullRequestReview = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment).Name}");
                        pullRequestReviewComment = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (commit == null && wikiCommit == null && issueTitle == null && issueBody == null && issueComment == null && discussionTitle == null && discussionBody == null && discussionComment == null && pullRequestTitle == null && pullRequestBody == null && pullRequestComment == null && pullRequestReview == null && pullRequestReviewComment == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationCommit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationCommit> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationCommit).Name}");
                    commit = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (commit == null && wikiCommit == null && issueTitle == null && issueBody == null && issueComment == null && discussionTitle == null && discussionBody == null && discussionComment == null && pullRequestTitle == null && pullRequestBody == null && pullRequestComment == null && pullRequestReview == null && pullRequestReviewComment == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationWikiCommit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationWikiCommit> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationWikiCommit).Name}");
                    wikiCommit = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (commit == null && wikiCommit == null && issueTitle == null && issueBody == null && issueComment == null && discussionTitle == null && discussionBody == null && discussionComment == null && pullRequestTitle == null && pullRequestBody == null && pullRequestComment == null && pullRequestReview == null && pullRequestReviewComment == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationIssueTitle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationIssueTitle> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationIssueTitle).Name}");
                    issueTitle = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (commit == null && wikiCommit == null && issueTitle == null && issueBody == null && issueComment == null && discussionTitle == null && discussionBody == null && discussionComment == null && pullRequestTitle == null && pullRequestBody == null && pullRequestComment == null && pullRequestReview == null && pullRequestReviewComment == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationIssueBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationIssueBody> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationIssueBody).Name}");
                    issueBody = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (commit == null && wikiCommit == null && issueTitle == null && issueBody == null && issueComment == null && discussionTitle == null && discussionBody == null && discussionComment == null && pullRequestTitle == null && pullRequestBody == null && pullRequestComment == null && pullRequestReview == null && pullRequestReviewComment == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationIssueComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationIssueComment> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationIssueComment).Name}");
                    issueComment = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (commit == null && wikiCommit == null && issueTitle == null && issueBody == null && issueComment == null && discussionTitle == null && discussionBody == null && discussionComment == null && pullRequestTitle == null && pullRequestBody == null && pullRequestComment == null && pullRequestReview == null && pullRequestReviewComment == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle).Name}");
                    discussionTitle = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (commit == null && wikiCommit == null && issueTitle == null && issueBody == null && issueComment == null && discussionTitle == null && discussionBody == null && discussionComment == null && pullRequestTitle == null && pullRequestBody == null && pullRequestComment == null && pullRequestReview == null && pullRequestReviewComment == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationDiscussionBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationDiscussionBody> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationDiscussionBody).Name}");
                    discussionBody = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (commit == null && wikiCommit == null && issueTitle == null && issueBody == null && issueComment == null && discussionTitle == null && discussionBody == null && discussionComment == null && pullRequestTitle == null && pullRequestBody == null && pullRequestComment == null && pullRequestReview == null && pullRequestReviewComment == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationDiscussionComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationDiscussionComment> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationDiscussionComment).Name}");
                    discussionComment = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (commit == null && wikiCommit == null && issueTitle == null && issueBody == null && issueComment == null && discussionTitle == null && discussionBody == null && discussionComment == null && pullRequestTitle == null && pullRequestBody == null && pullRequestComment == null && pullRequestReview == null && pullRequestReviewComment == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle).Name}");
                    pullRequestTitle = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (commit == null && wikiCommit == null && issueTitle == null && issueBody == null && issueComment == null && discussionTitle == null && discussionBody == null && discussionComment == null && pullRequestTitle == null && pullRequestBody == null && pullRequestComment == null && pullRequestReview == null && pullRequestReviewComment == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationPullRequestBody> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestBody).Name}");
                    pullRequestBody = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (commit == null && wikiCommit == null && issueTitle == null && issueBody == null && issueComment == null && discussionTitle == null && discussionBody == null && discussionComment == null && pullRequestTitle == null && pullRequestBody == null && pullRequestComment == null && pullRequestReview == null && pullRequestReviewComment == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationPullRequestComment> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestComment).Name}");
                    pullRequestComment = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (commit == null && wikiCommit == null && issueTitle == null && issueBody == null && issueComment == null && discussionTitle == null && discussionBody == null && discussionComment == null && pullRequestTitle == null && pullRequestBody == null && pullRequestComment == null && pullRequestReview == null && pullRequestReviewComment == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestReview), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationPullRequestReview> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestReview).Name}");
                    pullRequestReview = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (commit == null && wikiCommit == null && issueTitle == null && issueBody == null && issueComment == null && discussionTitle == null && discussionBody == null && discussionComment == null && pullRequestTitle == null && pullRequestBody == null && pullRequestComment == null && pullRequestReview == null && pullRequestReviewComment == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment).Name}");
                    pullRequestReviewComment = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.GitHub.NullableSecretScanningFirstDetectedLocation(
                commit,

                wikiCommit,

                issueTitle,

                issueBody,

                issueComment,

                discussionTitle,

                discussionBody,

                discussionComment,

                pullRequestTitle,

                pullRequestBody,

                pullRequestComment,

                pullRequestReview,

                pullRequestReviewComment
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.GitHub.NullableSecretScanningFirstDetectedLocation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCommit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationCommit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationCommit?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationCommit).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Commit!, typeInfo);
            }
            else if (value.IsWikiCommit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationWikiCommit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationWikiCommit?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationWikiCommit).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WikiCommit!, typeInfo);
            }
            else if (value.IsIssueTitle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationIssueTitle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationIssueTitle?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationIssueTitle).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IssueTitle!, typeInfo);
            }
            else if (value.IsIssueBody)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationIssueBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationIssueBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationIssueBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IssueBody!, typeInfo);
            }
            else if (value.IsIssueComment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationIssueComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationIssueComment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationIssueComment).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IssueComment!, typeInfo);
            }
            else if (value.IsDiscussionTitle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DiscussionTitle!, typeInfo);
            }
            else if (value.IsDiscussionBody)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationDiscussionBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationDiscussionBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationDiscussionBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DiscussionBody!, typeInfo);
            }
            else if (value.IsDiscussionComment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationDiscussionComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationDiscussionComment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationDiscussionComment).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DiscussionComment!, typeInfo);
            }
            else if (value.IsPullRequestTitle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PullRequestTitle!, typeInfo);
            }
            else if (value.IsPullRequestBody)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationPullRequestBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PullRequestBody!, typeInfo);
            }
            else if (value.IsPullRequestComment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationPullRequestComment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestComment).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PullRequestComment!, typeInfo);
            }
            else if (value.IsPullRequestReview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestReview), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationPullRequestReview?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestReview).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PullRequestReview!, typeInfo);
            }
            else if (value.IsPullRequestReviewComment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PullRequestReviewComment!, typeInfo);
            }
        }
    }
}