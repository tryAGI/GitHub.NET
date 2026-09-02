#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.GitHub.JsonConverters
{
    /// <inheritdoc />
    public class RepositoryRuleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.GitHub.RepositoryRule>
    {
        /// <inheritdoc />
        public override global::tryAGI.GitHub.RepositoryRule Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("parameters")) __score1++;
            if (__jsonProps.Contains("parameters.update_allows_fetch_and_merge")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("parameters")) __score4++;
            if (__jsonProps.Contains("parameters.check_response_timeout_minutes")) __score4++;
            if (__jsonProps.Contains("parameters.grouping_strategy")) __score4++;
            if (__jsonProps.Contains("parameters.max_entries_to_build")) __score4++;
            if (__jsonProps.Contains("parameters.max_entries_to_merge")) __score4++;
            if (__jsonProps.Contains("parameters.merge_method")) __score4++;
            if (__jsonProps.Contains("parameters.min_entries_to_merge")) __score4++;
            if (__jsonProps.Contains("parameters.min_entries_to_merge_wait_minutes")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("parameters")) __score5++;
            if (__jsonProps.Contains("parameters.required_deployment_environments")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("parameters")) __score7++;
            if (__jsonProps.Contains("parameters.allowed_merge_methods")) __score7++;
            if (__jsonProps.Contains("parameters.dismiss_stale_reviews_on_push")) __score7++;
            if (__jsonProps.Contains("parameters.dismissal_restriction")) __score7++;
            if (__jsonProps.Contains("parameters.require_code_owner_review")) __score7++;
            if (__jsonProps.Contains("parameters.require_last_push_approval")) __score7++;
            if (__jsonProps.Contains("parameters.required_approving_review_count")) __score7++;
            if (__jsonProps.Contains("parameters.required_review_thread_resolution")) __score7++;
            if (__jsonProps.Contains("parameters.required_reviewers")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("parameters")) __score8++;
            if (__jsonProps.Contains("parameters.do_not_enforce_on_create")) __score8++;
            if (__jsonProps.Contains("parameters.required_status_checks")) __score8++;
            if (__jsonProps.Contains("parameters.strict_required_status_checks_policy")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("parameters")) __score10++;
            if (__jsonProps.Contains("parameters.name")) __score10++;
            if (__jsonProps.Contains("parameters.negate")) __score10++;
            if (__jsonProps.Contains("parameters.operator")) __score10++;
            if (__jsonProps.Contains("parameters.pattern")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("parameters")) __score11++;
            if (__jsonProps.Contains("parameters.name")) __score11++;
            if (__jsonProps.Contains("parameters.negate")) __score11++;
            if (__jsonProps.Contains("parameters.operator")) __score11++;
            if (__jsonProps.Contains("parameters.pattern")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("parameters")) __score12++;
            if (__jsonProps.Contains("parameters.name")) __score12++;
            if (__jsonProps.Contains("parameters.negate")) __score12++;
            if (__jsonProps.Contains("parameters.operator")) __score12++;
            if (__jsonProps.Contains("parameters.pattern")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("parameters")) __score13++;
            if (__jsonProps.Contains("parameters.name")) __score13++;
            if (__jsonProps.Contains("parameters.negate")) __score13++;
            if (__jsonProps.Contains("parameters.operator")) __score13++;
            if (__jsonProps.Contains("parameters.pattern")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("parameters")) __score14++;
            if (__jsonProps.Contains("parameters.name")) __score14++;
            if (__jsonProps.Contains("parameters.negate")) __score14++;
            if (__jsonProps.Contains("parameters.operator")) __score14++;
            if (__jsonProps.Contains("parameters.pattern")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("parameters")) __score15++;
            if (__jsonProps.Contains("parameters.do_not_enforce_on_create")) __score15++;
            if (__jsonProps.Contains("parameters.workflows")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("parameters")) __score16++;
            if (__jsonProps.Contains("parameters.code_scanning_tools")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("parameters")) __score17++;
            if (__jsonProps.Contains("parameters.review_draft_pull_requests")) __score17++;
            if (__jsonProps.Contains("parameters.review_on_push")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("type")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("parameters")) __score19++;
            if (__jsonProps.Contains("parameters.restricted_file_paths")) __score19++;
            if (__jsonProps.Contains("type")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("parameters")) __score20++;
            if (__jsonProps.Contains("parameters.max_file_path_length")) __score20++;
            if (__jsonProps.Contains("type")) __score20++;
            var __score21 = 0;
            if (__jsonProps.Contains("parameters")) __score21++;
            if (__jsonProps.Contains("parameters.restricted_file_extensions")) __score21++;
            if (__jsonProps.Contains("type")) __score21++;
            var __score22 = 0;
            if (__jsonProps.Contains("parameters")) __score22++;
            if (__jsonProps.Contains("parameters.max_file_size")) __score22++;
            if (__jsonProps.Contains("type")) __score22++;
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
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }
            if (__score16 > __bestScore) { __bestScore = __score16; __bestIndex = 16; }
            if (__score17 > __bestScore) { __bestScore = __score17; __bestIndex = 17; }
            if (__score18 > __bestScore) { __bestScore = __score18; __bestIndex = 18; }
            if (__score19 > __bestScore) { __bestScore = __score19; __bestIndex = 19; }
            if (__score20 > __bestScore) { __bestScore = __score20; __bestIndex = 20; }
            if (__score21 > __bestScore) { __bestScore = __score21; __bestIndex = 21; }
            if (__score22 > __bestScore) { __bestScore = __score22; __bestIndex = 22; }

            global::tryAGI.GitHub.RepositoryRuleCreation? creation = default;
            global::tryAGI.GitHub.RepositoryRuleUpdate? update = default;
            global::tryAGI.GitHub.RepositoryRuleDeletion? deletion = default;
            global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory? requiredLinearHistory = default;
            global::tryAGI.GitHub.RepositoryRuleMergeQueue? mergeQueue = default;
            global::tryAGI.GitHub.RepositoryRuleRequiredDeployments? requiredDeployments = default;
            global::tryAGI.GitHub.RepositoryRuleRequiredSignatures? requiredSignatures = default;
            global::tryAGI.GitHub.RepositoryRulePullRequest? pullRequest = default;
            global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks? requiredStatusChecks = default;
            global::tryAGI.GitHub.RepositoryRuleNonFastForward? nonFastForward = default;
            global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern? commitMessagePattern = default;
            global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern? commitAuthorEmailPattern = default;
            global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern? committerEmailPattern = default;
            global::tryAGI.GitHub.RepositoryRuleBranchNamePattern? branchNamePattern = default;
            global::tryAGI.GitHub.RepositoryRuleTagNamePattern? tagNamePattern = default;
            global::tryAGI.GitHub.RepositoryRuleWorkflows? workflows = default;
            global::tryAGI.GitHub.RepositoryRuleCodeScanning? codeScanning = default;
            global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview? copilotCodeReview = default;
            global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning? licenseComplianceScanning = default;
            global::tryAGI.GitHub.RepositoryRuleFilePathRestriction? filePathRestriction = default;
            global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength? maxFilePathLength = default;
            global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction? fileExtensionRestriction = default;
            global::tryAGI.GitHub.RepositoryRuleMaxFileSize? maxFileSize = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleCreation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleCreation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleCreation).Name}");
                        creation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleUpdate> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleUpdate).Name}");
                        update = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleDeletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleDeletion> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleDeletion).Name}");
                        deletion = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory).Name}");
                        requiredLinearHistory = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleMergeQueue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleMergeQueue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleMergeQueue).Name}");
                        mergeQueue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleRequiredDeployments), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleRequiredDeployments).Name}");
                        requiredDeployments = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleRequiredSignatures), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleRequiredSignatures).Name}");
                        requiredSignatures = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRulePullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRulePullRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRulePullRequest).Name}");
                        pullRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks).Name}");
                        requiredStatusChecks = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleNonFastForward), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleNonFastForward> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleNonFastForward).Name}");
                        nonFastForward = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern).Name}");
                        commitMessagePattern = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern).Name}");
                        commitAuthorEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern).Name}");
                        committerEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 13)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleBranchNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleBranchNamePattern).Name}");
                        branchNamePattern = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 14)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleTagNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleTagNamePattern> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleTagNamePattern).Name}");
                        tagNamePattern = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 15)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleWorkflows), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleWorkflows> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleWorkflows).Name}");
                        workflows = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 16)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleCodeScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleCodeScanning> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleCodeScanning).Name}");
                        codeScanning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 17)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview).Name}");
                        copilotCodeReview = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 18)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning).Name}");
                        licenseComplianceScanning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 19)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleFilePathRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleFilePathRestriction).Name}");
                        filePathRestriction = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 20)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength).Name}");
                        maxFilePathLength = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 21)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction).Name}");
                        fileExtensionRestriction = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 22)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleMaxFileSize), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleMaxFileSize> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleMaxFileSize).Name}");
                        maxFileSize = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleCreation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleCreation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleCreation).Name}");
                    creation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleUpdate> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleUpdate).Name}");
                    update = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleDeletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleDeletion> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleDeletion).Name}");
                    deletion = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory).Name}");
                    requiredLinearHistory = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleMergeQueue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleMergeQueue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleMergeQueue).Name}");
                    mergeQueue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleRequiredDeployments), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleRequiredDeployments).Name}");
                    requiredDeployments = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleRequiredSignatures), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleRequiredSignatures).Name}");
                    requiredSignatures = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRulePullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRulePullRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRulePullRequest).Name}");
                    pullRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks).Name}");
                    requiredStatusChecks = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleNonFastForward), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleNonFastForward> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleNonFastForward).Name}");
                    nonFastForward = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern).Name}");
                    commitMessagePattern = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern).Name}");
                    commitAuthorEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern).Name}");
                    committerEmailPattern = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleBranchNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleBranchNamePattern).Name}");
                    branchNamePattern = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleTagNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleTagNamePattern> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleTagNamePattern).Name}");
                    tagNamePattern = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleWorkflows), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleWorkflows> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleWorkflows).Name}");
                    workflows = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleCodeScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleCodeScanning> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleCodeScanning).Name}");
                    codeScanning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview).Name}");
                    copilotCodeReview = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning).Name}");
                    licenseComplianceScanning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleFilePathRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleFilePathRestriction).Name}");
                    filePathRestriction = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength).Name}");
                    maxFilePathLength = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction).Name}");
                    fileExtensionRestriction = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (creation == null && update == null && deletion == null && requiredLinearHistory == null && mergeQueue == null && requiredDeployments == null && requiredSignatures == null && pullRequest == null && requiredStatusChecks == null && nonFastForward == null && commitMessagePattern == null && commitAuthorEmailPattern == null && committerEmailPattern == null && branchNamePattern == null && tagNamePattern == null && workflows == null && codeScanning == null && copilotCodeReview == null && licenseComplianceScanning == null && filePathRestriction == null && maxFilePathLength == null && fileExtensionRestriction == null && maxFileSize == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleMaxFileSize), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleMaxFileSize> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleMaxFileSize).Name}");
                    maxFileSize = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.GitHub.RepositoryRule(
                creation,

                update,

                deletion,

                requiredLinearHistory,

                mergeQueue,

                requiredDeployments,

                requiredSignatures,

                pullRequest,

                requiredStatusChecks,

                nonFastForward,

                commitMessagePattern,

                commitAuthorEmailPattern,

                committerEmailPattern,

                branchNamePattern,

                tagNamePattern,

                workflows,

                codeScanning,

                copilotCodeReview,

                licenseComplianceScanning,

                filePathRestriction,

                maxFilePathLength,

                fileExtensionRestriction,

                maxFileSize
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.GitHub.RepositoryRule value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCreation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleCreation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleCreation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleCreation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Creation!, typeInfo);
            }
            else if (value.IsUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Update!, typeInfo);
            }
            else if (value.IsDeletion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleDeletion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleDeletion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleDeletion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deletion!, typeInfo);
            }
            else if (value.IsRequiredLinearHistory)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredLinearHistory!, typeInfo);
            }
            else if (value.IsMergeQueue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleMergeQueue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleMergeQueue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleMergeQueue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MergeQueue!, typeInfo);
            }
            else if (value.IsRequiredDeployments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleRequiredDeployments), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleRequiredDeployments).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredDeployments!, typeInfo);
            }
            else if (value.IsRequiredSignatures)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleRequiredSignatures), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleRequiredSignatures).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredSignatures!, typeInfo);
            }
            else if (value.IsPullRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRulePullRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRulePullRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRulePullRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PullRequest!, typeInfo);
            }
            else if (value.IsRequiredStatusChecks)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredStatusChecks!, typeInfo);
            }
            else if (value.IsNonFastForward)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleNonFastForward), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleNonFastForward?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleNonFastForward).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NonFastForward!, typeInfo);
            }
            else if (value.IsCommitMessagePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommitMessagePattern!, typeInfo);
            }
            else if (value.IsCommitAuthorEmailPattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommitAuthorEmailPattern!, typeInfo);
            }
            else if (value.IsCommitterEmailPattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommitterEmailPattern!, typeInfo);
            }
            else if (value.IsBranchNamePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleBranchNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleBranchNamePattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BranchNamePattern!, typeInfo);
            }
            else if (value.IsTagNamePattern)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleTagNamePattern), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleTagNamePattern?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleTagNamePattern).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TagNamePattern!, typeInfo);
            }
            else if (value.IsWorkflows)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleWorkflows), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleWorkflows?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleWorkflows).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Workflows!, typeInfo);
            }
            else if (value.IsCodeScanning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleCodeScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleCodeScanning?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleCodeScanning).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeScanning!, typeInfo);
            }
            else if (value.IsCopilotCodeReview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CopilotCodeReview!, typeInfo);
            }
            else if (value.IsLicenseComplianceScanning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LicenseComplianceScanning!, typeInfo);
            }
            else if (value.IsFilePathRestriction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleFilePathRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleFilePathRestriction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilePathRestriction!, typeInfo);
            }
            else if (value.IsMaxFilePathLength)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxFilePathLength!, typeInfo);
            }
            else if (value.IsFileExtensionRestriction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileExtensionRestriction!, typeInfo);
            }
            else if (value.IsMaxFileSize)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RepositoryRuleMaxFileSize), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RepositoryRuleMaxFileSize?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RepositoryRuleMaxFileSize).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxFileSize!, typeInfo);
            }
        }
    }
}