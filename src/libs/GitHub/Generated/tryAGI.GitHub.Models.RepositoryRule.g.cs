#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A repository rule.
    /// </summary>
    public readonly partial struct RepositoryRule : global::System.IEquatable<RepositoryRule>
    {
        /// <summary>
        /// Only allow users with bypass permission to create matching refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleCreation? Creation { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleCreation? Creation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Creation))]
#endif
        public bool IsCreation => Creation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleCreation? value)
        {
            value = Creation;
            return IsCreation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleCreation PickCreation() => IsCreation
            ? Creation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Creation' but the value was {ToString()}.");

        /// <summary>
        /// Only allow users with bypass permission to update matching refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleUpdate? Update { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleUpdate? Update { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Update))]
#endif
        public bool IsUpdate => Update != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUpdate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleUpdate? value)
        {
            value = Update;
            return IsUpdate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleUpdate PickUpdate() => IsUpdate
            ? Update!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Update' but the value was {ToString()}.");

        /// <summary>
        /// Only allow users with bypass permissions to delete matching refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleDeletion? Deletion { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleDeletion? Deletion { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Deletion))]
#endif
        public bool IsDeletion => Deletion != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDeletion(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleDeletion? value)
        {
            value = Deletion;
            return IsDeletion;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleDeletion PickDeletion() => IsDeletion
            ? Deletion!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Deletion' but the value was {ToString()}.");

        /// <summary>
        /// Prevent merge commits from being pushed to matching refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory? RequiredLinearHistory { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory? RequiredLinearHistory { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequiredLinearHistory))]
#endif
        public bool IsRequiredLinearHistory => RequiredLinearHistory != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRequiredLinearHistory(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory? value)
        {
            value = RequiredLinearHistory;
            return IsRequiredLinearHistory;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory PickRequiredLinearHistory() => IsRequiredLinearHistory
            ? RequiredLinearHistory!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequiredLinearHistory' but the value was {ToString()}.");

        /// <summary>
        /// Merges must be performed via a merge queue.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleMergeQueue? MergeQueue { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleMergeQueue? MergeQueue { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MergeQueue))]
#endif
        public bool IsMergeQueue => MergeQueue != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMergeQueue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleMergeQueue? value)
        {
            value = MergeQueue;
            return IsMergeQueue;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleMergeQueue PickMergeQueue() => IsMergeQueue
            ? MergeQueue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MergeQueue' but the value was {ToString()}.");

        /// <summary>
        /// Choose which environments must be successfully deployed to before refs can be pushed into a ref that matches this rule.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleRequiredDeployments? RequiredDeployments { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleRequiredDeployments? RequiredDeployments { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequiredDeployments))]
#endif
        public bool IsRequiredDeployments => RequiredDeployments != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRequiredDeployments(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleRequiredDeployments? value)
        {
            value = RequiredDeployments;
            return IsRequiredDeployments;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleRequiredDeployments PickRequiredDeployments() => IsRequiredDeployments
            ? RequiredDeployments!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequiredDeployments' but the value was {ToString()}.");

        /// <summary>
        /// Commits pushed to matching refs must have verified signatures.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleRequiredSignatures? RequiredSignatures { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleRequiredSignatures? RequiredSignatures { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequiredSignatures))]
#endif
        public bool IsRequiredSignatures => RequiredSignatures != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRequiredSignatures(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleRequiredSignatures? value)
        {
            value = RequiredSignatures;
            return IsRequiredSignatures;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleRequiredSignatures PickRequiredSignatures() => IsRequiredSignatures
            ? RequiredSignatures!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequiredSignatures' but the value was {ToString()}.");

        /// <summary>
        /// Require all commits be made to a non-target branch and submitted via a pull request before they can be merged.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRulePullRequest? PullRequest { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRulePullRequest? PullRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PullRequest))]
#endif
        public bool IsPullRequest => PullRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPullRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRulePullRequest? value)
        {
            value = PullRequest;
            return IsPullRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRulePullRequest PickPullRequest() => IsPullRequest
            ? PullRequest!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PullRequest' but the value was {ToString()}.");

        /// <summary>
        /// Choose which status checks must pass before the ref is updated. When enabled, commits must first be pushed to another ref where the checks pass.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks? RequiredStatusChecks { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks? RequiredStatusChecks { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequiredStatusChecks))]
#endif
        public bool IsRequiredStatusChecks => RequiredStatusChecks != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRequiredStatusChecks(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks? value)
        {
            value = RequiredStatusChecks;
            return IsRequiredStatusChecks;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks PickRequiredStatusChecks() => IsRequiredStatusChecks
            ? RequiredStatusChecks!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequiredStatusChecks' but the value was {ToString()}.");

        /// <summary>
        /// Prevent users with push access from force pushing to refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleNonFastForward? NonFastForward { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleNonFastForward? NonFastForward { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NonFastForward))]
#endif
        public bool IsNonFastForward => NonFastForward != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNonFastForward(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleNonFastForward? value)
        {
            value = NonFastForward;
            return IsNonFastForward;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleNonFastForward PickNonFastForward() => IsNonFastForward
            ? NonFastForward!
            : throw new global::System.InvalidOperationException($"Expected union variant 'NonFastForward' but the value was {ToString()}.");

        /// <summary>
        /// Parameters to be used for the commit_message_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern? CommitMessagePattern { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern? CommitMessagePattern { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommitMessagePattern))]
#endif
        public bool IsCommitMessagePattern => CommitMessagePattern != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCommitMessagePattern(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern? value)
        {
            value = CommitMessagePattern;
            return IsCommitMessagePattern;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern PickCommitMessagePattern() => IsCommitMessagePattern
            ? CommitMessagePattern!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CommitMessagePattern' but the value was {ToString()}.");

        /// <summary>
        /// Parameters to be used for the commit_author_email_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern? CommitAuthorEmailPattern { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern? CommitAuthorEmailPattern { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommitAuthorEmailPattern))]
#endif
        public bool IsCommitAuthorEmailPattern => CommitAuthorEmailPattern != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCommitAuthorEmailPattern(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern? value)
        {
            value = CommitAuthorEmailPattern;
            return IsCommitAuthorEmailPattern;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern PickCommitAuthorEmailPattern() => IsCommitAuthorEmailPattern
            ? CommitAuthorEmailPattern!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CommitAuthorEmailPattern' but the value was {ToString()}.");

        /// <summary>
        /// Parameters to be used for the committer_email_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern? CommitterEmailPattern { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern? CommitterEmailPattern { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommitterEmailPattern))]
#endif
        public bool IsCommitterEmailPattern => CommitterEmailPattern != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCommitterEmailPattern(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern? value)
        {
            value = CommitterEmailPattern;
            return IsCommitterEmailPattern;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern PickCommitterEmailPattern() => IsCommitterEmailPattern
            ? CommitterEmailPattern!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CommitterEmailPattern' but the value was {ToString()}.");

        /// <summary>
        /// Parameters to be used for the branch_name_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleBranchNamePattern? BranchNamePattern { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleBranchNamePattern? BranchNamePattern { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BranchNamePattern))]
#endif
        public bool IsBranchNamePattern => BranchNamePattern != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBranchNamePattern(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleBranchNamePattern? value)
        {
            value = BranchNamePattern;
            return IsBranchNamePattern;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleBranchNamePattern PickBranchNamePattern() => IsBranchNamePattern
            ? BranchNamePattern!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BranchNamePattern' but the value was {ToString()}.");

        /// <summary>
        /// Parameters to be used for the tag_name_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleTagNamePattern? TagNamePattern { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleTagNamePattern? TagNamePattern { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TagNamePattern))]
#endif
        public bool IsTagNamePattern => TagNamePattern != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTagNamePattern(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleTagNamePattern? value)
        {
            value = TagNamePattern;
            return IsTagNamePattern;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleTagNamePattern PickTagNamePattern() => IsTagNamePattern
            ? TagNamePattern!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TagNamePattern' but the value was {ToString()}.");

        /// <summary>
        /// Require all changes made to a targeted branch to pass the specified workflows before they can be merged.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleWorkflows? Workflows { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleWorkflows? Workflows { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Workflows))]
#endif
        public bool IsWorkflows => Workflows != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkflows(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleWorkflows? value)
        {
            value = Workflows;
            return IsWorkflows;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleWorkflows PickWorkflows() => IsWorkflows
            ? Workflows!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Workflows' but the value was {ToString()}.");

        /// <summary>
        /// Choose which tools must provide code scanning results before the reference is updated. When configured, code scanning must be enabled and have results for both the commit and the reference being updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleCodeScanning? CodeScanning { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleCodeScanning? CodeScanning { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeScanning))]
#endif
        public bool IsCodeScanning => CodeScanning != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeScanning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleCodeScanning? value)
        {
            value = CodeScanning;
            return IsCodeScanning;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleCodeScanning PickCodeScanning() => IsCodeScanning
            ? CodeScanning!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeScanning' but the value was {ToString()}.");

        /// <summary>
        /// Request Copilot code review for new pull requests automatically if the author has access to Copilot code review and their premium requests quota has not reached the limit.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview? CopilotCodeReview { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview? CopilotCodeReview { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CopilotCodeReview))]
#endif
        public bool IsCopilotCodeReview => CopilotCodeReview != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCopilotCodeReview(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview? value)
        {
            value = CopilotCodeReview;
            return IsCopilotCodeReview;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview PickCopilotCodeReview() => IsCopilotCodeReview
            ? CopilotCodeReview!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CopilotCodeReview' but the value was {ToString()}.");

        /// <summary>
        /// Enforce any added or changed dependencies to comply with the organization's license policy.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning? LicenseComplianceScanning { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning? LicenseComplianceScanning { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LicenseComplianceScanning))]
#endif
        public bool IsLicenseComplianceScanning => LicenseComplianceScanning != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLicenseComplianceScanning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning? value)
        {
            value = LicenseComplianceScanning;
            return IsLicenseComplianceScanning;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning PickLicenseComplianceScanning() => IsLicenseComplianceScanning
            ? LicenseComplianceScanning!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LicenseComplianceScanning' but the value was {ToString()}.");

        /// <summary>
        /// Prevent commits that include changes in specified file and folder paths from being pushed to the commit graph. This includes absolute paths that contain file names.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleFilePathRestriction? FilePathRestriction { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleFilePathRestriction? FilePathRestriction { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilePathRestriction))]
#endif
        public bool IsFilePathRestriction => FilePathRestriction != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFilePathRestriction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleFilePathRestriction? value)
        {
            value = FilePathRestriction;
            return IsFilePathRestriction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleFilePathRestriction PickFilePathRestriction() => IsFilePathRestriction
            ? FilePathRestriction!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FilePathRestriction' but the value was {ToString()}.");

        /// <summary>
        /// Prevent commits that include file paths that exceed the specified character limit from being pushed to the commit graph.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength? MaxFilePathLength { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength? MaxFilePathLength { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MaxFilePathLength))]
#endif
        public bool IsMaxFilePathLength => MaxFilePathLength != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMaxFilePathLength(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength? value)
        {
            value = MaxFilePathLength;
            return IsMaxFilePathLength;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength PickMaxFilePathLength() => IsMaxFilePathLength
            ? MaxFilePathLength!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MaxFilePathLength' but the value was {ToString()}.");

        /// <summary>
        /// Prevent commits that include files with specified file extensions from being pushed to the commit graph.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction? FileExtensionRestriction { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction? FileExtensionRestriction { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileExtensionRestriction))]
#endif
        public bool IsFileExtensionRestriction => FileExtensionRestriction != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFileExtensionRestriction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction? value)
        {
            value = FileExtensionRestriction;
            return IsFileExtensionRestriction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction PickFileExtensionRestriction() => IsFileExtensionRestriction
            ? FileExtensionRestriction!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileExtensionRestriction' but the value was {ToString()}.");

        /// <summary>
        /// Prevent commits with individual files that exceed the specified limit from being pushed to the commit graph.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RepositoryRuleMaxFileSize? MaxFileSize { get; init; }
#else
        public global::tryAGI.GitHub.RepositoryRuleMaxFileSize? MaxFileSize { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MaxFileSize))]
#endif
        public bool IsMaxFileSize => MaxFileSize != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMaxFileSize(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RepositoryRuleMaxFileSize? value)
        {
            value = MaxFileSize;
            return IsMaxFileSize;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RepositoryRuleMaxFileSize PickMaxFileSize() => IsMaxFileSize
            ? MaxFileSize!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MaxFileSize' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleCreation value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleCreation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleCreation?(RepositoryRule @this) => @this.Creation;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleCreation? value)
        {
            Creation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromCreation(global::tryAGI.GitHub.RepositoryRuleCreation? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleUpdate value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleUpdate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleUpdate?(RepositoryRule @this) => @this.Update;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleUpdate? value)
        {
            Update = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromUpdate(global::tryAGI.GitHub.RepositoryRuleUpdate? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleDeletion value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleDeletion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleDeletion?(RepositoryRule @this) => @this.Deletion;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleDeletion? value)
        {
            Deletion = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromDeletion(global::tryAGI.GitHub.RepositoryRuleDeletion? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory?(RepositoryRule @this) => @this.RequiredLinearHistory;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory? value)
        {
            RequiredLinearHistory = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromRequiredLinearHistory(global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleMergeQueue value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleMergeQueue?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleMergeQueue?(RepositoryRule @this) => @this.MergeQueue;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleMergeQueue? value)
        {
            MergeQueue = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromMergeQueue(global::tryAGI.GitHub.RepositoryRuleMergeQueue? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleRequiredDeployments value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleRequiredDeployments?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleRequiredDeployments?(RepositoryRule @this) => @this.RequiredDeployments;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleRequiredDeployments? value)
        {
            RequiredDeployments = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromRequiredDeployments(global::tryAGI.GitHub.RepositoryRuleRequiredDeployments? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleRequiredSignatures value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleRequiredSignatures?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleRequiredSignatures?(RepositoryRule @this) => @this.RequiredSignatures;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleRequiredSignatures? value)
        {
            RequiredSignatures = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromRequiredSignatures(global::tryAGI.GitHub.RepositoryRuleRequiredSignatures? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRulePullRequest value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRulePullRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRulePullRequest?(RepositoryRule @this) => @this.PullRequest;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRulePullRequest? value)
        {
            PullRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromPullRequest(global::tryAGI.GitHub.RepositoryRulePullRequest? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks?(RepositoryRule @this) => @this.RequiredStatusChecks;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks? value)
        {
            RequiredStatusChecks = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromRequiredStatusChecks(global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleNonFastForward value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleNonFastForward?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleNonFastForward?(RepositoryRule @this) => @this.NonFastForward;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleNonFastForward? value)
        {
            NonFastForward = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromNonFastForward(global::tryAGI.GitHub.RepositoryRuleNonFastForward? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern?(RepositoryRule @this) => @this.CommitMessagePattern;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern? value)
        {
            CommitMessagePattern = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromCommitMessagePattern(global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern?(RepositoryRule @this) => @this.CommitAuthorEmailPattern;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern? value)
        {
            CommitAuthorEmailPattern = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromCommitAuthorEmailPattern(global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern?(RepositoryRule @this) => @this.CommitterEmailPattern;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern? value)
        {
            CommitterEmailPattern = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromCommitterEmailPattern(global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleBranchNamePattern value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleBranchNamePattern?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleBranchNamePattern?(RepositoryRule @this) => @this.BranchNamePattern;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleBranchNamePattern? value)
        {
            BranchNamePattern = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromBranchNamePattern(global::tryAGI.GitHub.RepositoryRuleBranchNamePattern? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleTagNamePattern value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleTagNamePattern?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleTagNamePattern?(RepositoryRule @this) => @this.TagNamePattern;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleTagNamePattern? value)
        {
            TagNamePattern = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromTagNamePattern(global::tryAGI.GitHub.RepositoryRuleTagNamePattern? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleWorkflows value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleWorkflows?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleWorkflows?(RepositoryRule @this) => @this.Workflows;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleWorkflows? value)
        {
            Workflows = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromWorkflows(global::tryAGI.GitHub.RepositoryRuleWorkflows? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleCodeScanning value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleCodeScanning?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleCodeScanning?(RepositoryRule @this) => @this.CodeScanning;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleCodeScanning? value)
        {
            CodeScanning = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromCodeScanning(global::tryAGI.GitHub.RepositoryRuleCodeScanning? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview?(RepositoryRule @this) => @this.CopilotCodeReview;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview? value)
        {
            CopilotCodeReview = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromCopilotCodeReview(global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning?(RepositoryRule @this) => @this.LicenseComplianceScanning;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning? value)
        {
            LicenseComplianceScanning = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromLicenseComplianceScanning(global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleFilePathRestriction value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleFilePathRestriction?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleFilePathRestriction?(RepositoryRule @this) => @this.FilePathRestriction;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleFilePathRestriction? value)
        {
            FilePathRestriction = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromFilePathRestriction(global::tryAGI.GitHub.RepositoryRuleFilePathRestriction? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength?(RepositoryRule @this) => @this.MaxFilePathLength;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength? value)
        {
            MaxFilePathLength = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromMaxFilePathLength(global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction?(RepositoryRule @this) => @this.FileExtensionRestriction;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction? value)
        {
            FileExtensionRestriction = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromFileExtensionRestriction(global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRule(global::tryAGI.GitHub.RepositoryRuleMaxFileSize value) => new RepositoryRule((global::tryAGI.GitHub.RepositoryRuleMaxFileSize?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleMaxFileSize?(RepositoryRule @this) => @this.MaxFileSize;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(global::tryAGI.GitHub.RepositoryRuleMaxFileSize? value)
        {
            MaxFileSize = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRule FromMaxFileSize(global::tryAGI.GitHub.RepositoryRuleMaxFileSize? value) => new RepositoryRule(value);

        /// <summary>
        ///
        /// </summary>
        public RepositoryRule(
            global::tryAGI.GitHub.RepositoryRuleCreation? creation,
            global::tryAGI.GitHub.RepositoryRuleUpdate? update,
            global::tryAGI.GitHub.RepositoryRuleDeletion? deletion,
            global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory? requiredLinearHistory,
            global::tryAGI.GitHub.RepositoryRuleMergeQueue? mergeQueue,
            global::tryAGI.GitHub.RepositoryRuleRequiredDeployments? requiredDeployments,
            global::tryAGI.GitHub.RepositoryRuleRequiredSignatures? requiredSignatures,
            global::tryAGI.GitHub.RepositoryRulePullRequest? pullRequest,
            global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks? requiredStatusChecks,
            global::tryAGI.GitHub.RepositoryRuleNonFastForward? nonFastForward,
            global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern? commitMessagePattern,
            global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern? commitAuthorEmailPattern,
            global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern? committerEmailPattern,
            global::tryAGI.GitHub.RepositoryRuleBranchNamePattern? branchNamePattern,
            global::tryAGI.GitHub.RepositoryRuleTagNamePattern? tagNamePattern,
            global::tryAGI.GitHub.RepositoryRuleWorkflows? workflows,
            global::tryAGI.GitHub.RepositoryRuleCodeScanning? codeScanning,
            global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview? copilotCodeReview,
            global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning? licenseComplianceScanning,
            global::tryAGI.GitHub.RepositoryRuleFilePathRestriction? filePathRestriction,
            global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength? maxFilePathLength,
            global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction? fileExtensionRestriction,
            global::tryAGI.GitHub.RepositoryRuleMaxFileSize? maxFileSize
            )
        {
            Creation = creation;
            Update = update;
            Deletion = deletion;
            RequiredLinearHistory = requiredLinearHistory;
            MergeQueue = mergeQueue;
            RequiredDeployments = requiredDeployments;
            RequiredSignatures = requiredSignatures;
            PullRequest = pullRequest;
            RequiredStatusChecks = requiredStatusChecks;
            NonFastForward = nonFastForward;
            CommitMessagePattern = commitMessagePattern;
            CommitAuthorEmailPattern = commitAuthorEmailPattern;
            CommitterEmailPattern = committerEmailPattern;
            BranchNamePattern = branchNamePattern;
            TagNamePattern = tagNamePattern;
            Workflows = workflows;
            CodeScanning = codeScanning;
            CopilotCodeReview = copilotCodeReview;
            LicenseComplianceScanning = licenseComplianceScanning;
            FilePathRestriction = filePathRestriction;
            MaxFilePathLength = maxFilePathLength;
            FileExtensionRestriction = fileExtensionRestriction;
            MaxFileSize = maxFileSize;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            MaxFileSize as object ??
            FileExtensionRestriction as object ??
            MaxFilePathLength as object ??
            FilePathRestriction as object ??
            LicenseComplianceScanning as object ??
            CopilotCodeReview as object ??
            CodeScanning as object ??
            Workflows as object ??
            TagNamePattern as object ??
            BranchNamePattern as object ??
            CommitterEmailPattern as object ??
            CommitAuthorEmailPattern as object ??
            CommitMessagePattern as object ??
            NonFastForward as object ??
            RequiredStatusChecks as object ??
            PullRequest as object ??
            RequiredSignatures as object ??
            RequiredDeployments as object ??
            MergeQueue as object ??
            RequiredLinearHistory as object ??
            Deletion as object ??
            Update as object ??
            Creation as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Creation?.ToString() ??
            Update?.ToString() ??
            Deletion?.ToString() ??
            RequiredLinearHistory?.ToString() ??
            MergeQueue?.ToString() ??
            RequiredDeployments?.ToString() ??
            RequiredSignatures?.ToString() ??
            PullRequest?.ToString() ??
            RequiredStatusChecks?.ToString() ??
            NonFastForward?.ToString() ??
            CommitMessagePattern?.ToString() ??
            CommitAuthorEmailPattern?.ToString() ??
            CommitterEmailPattern?.ToString() ??
            BranchNamePattern?.ToString() ??
            TagNamePattern?.ToString() ??
            Workflows?.ToString() ??
            CodeScanning?.ToString() ??
            CopilotCodeReview?.ToString() ??
            LicenseComplianceScanning?.ToString() ??
            FilePathRestriction?.ToString() ??
            MaxFilePathLength?.ToString() ??
            FileExtensionRestriction?.ToString() ??
            MaxFileSize?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview && !IsLicenseComplianceScanning && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview && !IsLicenseComplianceScanning && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && !IsUpdate && IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview && !IsLicenseComplianceScanning && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && !IsUpdate && !IsDeletion && IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview && !IsLicenseComplianceScanning && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview && !IsLicenseComplianceScanning && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview && !IsLicenseComplianceScanning && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview && !IsLicenseComplianceScanning && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview && !IsLicenseComplianceScanning && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview && !IsLicenseComplianceScanning && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview && !IsLicenseComplianceScanning && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview && !IsLicenseComplianceScanning && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview && !IsLicenseComplianceScanning && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview && !IsLicenseComplianceScanning && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && IsBranchNamePattern && !IsTagNamePattern && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview && !IsLicenseComplianceScanning && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && IsTagNamePattern && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview && !IsLicenseComplianceScanning && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview && !IsLicenseComplianceScanning && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsWorkflows && IsCodeScanning && !IsCopilotCodeReview && !IsLicenseComplianceScanning && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsWorkflows && !IsCodeScanning && IsCopilotCodeReview && !IsLicenseComplianceScanning && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview && IsLicenseComplianceScanning && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview && !IsLicenseComplianceScanning && IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview && !IsLicenseComplianceScanning && !IsFilePathRestriction && IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview && !IsLicenseComplianceScanning && !IsFilePathRestriction && !IsMaxFilePathLength && IsFileExtensionRestriction && !IsMaxFileSize || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview && !IsLicenseComplianceScanning && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && IsMaxFileSize;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleCreation, TResult>? creation = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleUpdate, TResult>? update = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleDeletion, TResult>? deletion = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory, TResult>? requiredLinearHistory = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleMergeQueue, TResult>? mergeQueue = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments, TResult>? requiredDeployments = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures, TResult>? requiredSignatures = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRulePullRequest, TResult>? pullRequest = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks, TResult>? requiredStatusChecks = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleNonFastForward, TResult>? nonFastForward = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern, TResult>? commitMessagePattern = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern, TResult>? commitAuthorEmailPattern = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern, TResult>? committerEmailPattern = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern, TResult>? branchNamePattern = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleTagNamePattern, TResult>? tagNamePattern = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleWorkflows, TResult>? workflows = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleCodeScanning, TResult>? codeScanning = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview, TResult>? copilotCodeReview = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning, TResult>? licenseComplianceScanning = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction, TResult>? filePathRestriction = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength, TResult>? maxFilePathLength = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction, TResult>? fileExtensionRestriction = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleMaxFileSize, TResult>? maxFileSize = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreation && creation != null)
            {
                return creation(Creation!);
            }
            else if (IsUpdate && update != null)
            {
                return update(Update!);
            }
            else if (IsDeletion && deletion != null)
            {
                return deletion(Deletion!);
            }
            else if (IsRequiredLinearHistory && requiredLinearHistory != null)
            {
                return requiredLinearHistory(RequiredLinearHistory!);
            }
            else if (IsMergeQueue && mergeQueue != null)
            {
                return mergeQueue(MergeQueue!);
            }
            else if (IsRequiredDeployments && requiredDeployments != null)
            {
                return requiredDeployments(RequiredDeployments!);
            }
            else if (IsRequiredSignatures && requiredSignatures != null)
            {
                return requiredSignatures(RequiredSignatures!);
            }
            else if (IsPullRequest && pullRequest != null)
            {
                return pullRequest(PullRequest!);
            }
            else if (IsRequiredStatusChecks && requiredStatusChecks != null)
            {
                return requiredStatusChecks(RequiredStatusChecks!);
            }
            else if (IsNonFastForward && nonFastForward != null)
            {
                return nonFastForward(NonFastForward!);
            }
            else if (IsCommitMessagePattern && commitMessagePattern != null)
            {
                return commitMessagePattern(CommitMessagePattern!);
            }
            else if (IsCommitAuthorEmailPattern && commitAuthorEmailPattern != null)
            {
                return commitAuthorEmailPattern(CommitAuthorEmailPattern!);
            }
            else if (IsCommitterEmailPattern && committerEmailPattern != null)
            {
                return committerEmailPattern(CommitterEmailPattern!);
            }
            else if (IsBranchNamePattern && branchNamePattern != null)
            {
                return branchNamePattern(BranchNamePattern!);
            }
            else if (IsTagNamePattern && tagNamePattern != null)
            {
                return tagNamePattern(TagNamePattern!);
            }
            else if (IsWorkflows && workflows != null)
            {
                return workflows(Workflows!);
            }
            else if (IsCodeScanning && codeScanning != null)
            {
                return codeScanning(CodeScanning!);
            }
            else if (IsCopilotCodeReview && copilotCodeReview != null)
            {
                return copilotCodeReview(CopilotCodeReview!);
            }
            else if (IsLicenseComplianceScanning && licenseComplianceScanning != null)
            {
                return licenseComplianceScanning(LicenseComplianceScanning!);
            }
            else if (IsFilePathRestriction && filePathRestriction != null)
            {
                return filePathRestriction(FilePathRestriction!);
            }
            else if (IsMaxFilePathLength && maxFilePathLength != null)
            {
                return maxFilePathLength(MaxFilePathLength!);
            }
            else if (IsFileExtensionRestriction && fileExtensionRestriction != null)
            {
                return fileExtensionRestriction(FileExtensionRestriction!);
            }
            else if (IsMaxFileSize && maxFileSize != null)
            {
                return maxFileSize(MaxFileSize!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleCreation>? creation = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleUpdate>? update = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleDeletion>? deletion = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory>? requiredLinearHistory = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleMergeQueue>? mergeQueue = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments>? requiredDeployments = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures>? requiredSignatures = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRulePullRequest>? pullRequest = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks>? requiredStatusChecks = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleNonFastForward>? nonFastForward = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern>? commitMessagePattern = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern>? commitAuthorEmailPattern = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern>? committerEmailPattern = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern>? branchNamePattern = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleTagNamePattern>? tagNamePattern = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleWorkflows>? workflows = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleCodeScanning>? codeScanning = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview>? copilotCodeReview = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning>? licenseComplianceScanning = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction>? filePathRestriction = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength>? maxFilePathLength = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction>? fileExtensionRestriction = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleMaxFileSize>? maxFileSize = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreation)
            {
                creation?.Invoke(Creation!);
            }
            else if (IsUpdate)
            {
                update?.Invoke(Update!);
            }
            else if (IsDeletion)
            {
                deletion?.Invoke(Deletion!);
            }
            else if (IsRequiredLinearHistory)
            {
                requiredLinearHistory?.Invoke(RequiredLinearHistory!);
            }
            else if (IsMergeQueue)
            {
                mergeQueue?.Invoke(MergeQueue!);
            }
            else if (IsRequiredDeployments)
            {
                requiredDeployments?.Invoke(RequiredDeployments!);
            }
            else if (IsRequiredSignatures)
            {
                requiredSignatures?.Invoke(RequiredSignatures!);
            }
            else if (IsPullRequest)
            {
                pullRequest?.Invoke(PullRequest!);
            }
            else if (IsRequiredStatusChecks)
            {
                requiredStatusChecks?.Invoke(RequiredStatusChecks!);
            }
            else if (IsNonFastForward)
            {
                nonFastForward?.Invoke(NonFastForward!);
            }
            else if (IsCommitMessagePattern)
            {
                commitMessagePattern?.Invoke(CommitMessagePattern!);
            }
            else if (IsCommitAuthorEmailPattern)
            {
                commitAuthorEmailPattern?.Invoke(CommitAuthorEmailPattern!);
            }
            else if (IsCommitterEmailPattern)
            {
                committerEmailPattern?.Invoke(CommitterEmailPattern!);
            }
            else if (IsBranchNamePattern)
            {
                branchNamePattern?.Invoke(BranchNamePattern!);
            }
            else if (IsTagNamePattern)
            {
                tagNamePattern?.Invoke(TagNamePattern!);
            }
            else if (IsWorkflows)
            {
                workflows?.Invoke(Workflows!);
            }
            else if (IsCodeScanning)
            {
                codeScanning?.Invoke(CodeScanning!);
            }
            else if (IsCopilotCodeReview)
            {
                copilotCodeReview?.Invoke(CopilotCodeReview!);
            }
            else if (IsLicenseComplianceScanning)
            {
                licenseComplianceScanning?.Invoke(LicenseComplianceScanning!);
            }
            else if (IsFilePathRestriction)
            {
                filePathRestriction?.Invoke(FilePathRestriction!);
            }
            else if (IsMaxFilePathLength)
            {
                maxFilePathLength?.Invoke(MaxFilePathLength!);
            }
            else if (IsFileExtensionRestriction)
            {
                fileExtensionRestriction?.Invoke(FileExtensionRestriction!);
            }
            else if (IsMaxFileSize)
            {
                maxFileSize?.Invoke(MaxFileSize!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleCreation>? creation = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleUpdate>? update = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleDeletion>? deletion = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory>? requiredLinearHistory = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleMergeQueue>? mergeQueue = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments>? requiredDeployments = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures>? requiredSignatures = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRulePullRequest>? pullRequest = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks>? requiredStatusChecks = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleNonFastForward>? nonFastForward = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern>? commitMessagePattern = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern>? commitAuthorEmailPattern = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern>? committerEmailPattern = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern>? branchNamePattern = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleTagNamePattern>? tagNamePattern = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleWorkflows>? workflows = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleCodeScanning>? codeScanning = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview>? copilotCodeReview = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning>? licenseComplianceScanning = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction>? filePathRestriction = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength>? maxFilePathLength = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction>? fileExtensionRestriction = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleMaxFileSize>? maxFileSize = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreation)
            {
                creation?.Invoke(Creation!);
            }
            else if (IsUpdate)
            {
                update?.Invoke(Update!);
            }
            else if (IsDeletion)
            {
                deletion?.Invoke(Deletion!);
            }
            else if (IsRequiredLinearHistory)
            {
                requiredLinearHistory?.Invoke(RequiredLinearHistory!);
            }
            else if (IsMergeQueue)
            {
                mergeQueue?.Invoke(MergeQueue!);
            }
            else if (IsRequiredDeployments)
            {
                requiredDeployments?.Invoke(RequiredDeployments!);
            }
            else if (IsRequiredSignatures)
            {
                requiredSignatures?.Invoke(RequiredSignatures!);
            }
            else if (IsPullRequest)
            {
                pullRequest?.Invoke(PullRequest!);
            }
            else if (IsRequiredStatusChecks)
            {
                requiredStatusChecks?.Invoke(RequiredStatusChecks!);
            }
            else if (IsNonFastForward)
            {
                nonFastForward?.Invoke(NonFastForward!);
            }
            else if (IsCommitMessagePattern)
            {
                commitMessagePattern?.Invoke(CommitMessagePattern!);
            }
            else if (IsCommitAuthorEmailPattern)
            {
                commitAuthorEmailPattern?.Invoke(CommitAuthorEmailPattern!);
            }
            else if (IsCommitterEmailPattern)
            {
                committerEmailPattern?.Invoke(CommitterEmailPattern!);
            }
            else if (IsBranchNamePattern)
            {
                branchNamePattern?.Invoke(BranchNamePattern!);
            }
            else if (IsTagNamePattern)
            {
                tagNamePattern?.Invoke(TagNamePattern!);
            }
            else if (IsWorkflows)
            {
                workflows?.Invoke(Workflows!);
            }
            else if (IsCodeScanning)
            {
                codeScanning?.Invoke(CodeScanning!);
            }
            else if (IsCopilotCodeReview)
            {
                copilotCodeReview?.Invoke(CopilotCodeReview!);
            }
            else if (IsLicenseComplianceScanning)
            {
                licenseComplianceScanning?.Invoke(LicenseComplianceScanning!);
            }
            else if (IsFilePathRestriction)
            {
                filePathRestriction?.Invoke(FilePathRestriction!);
            }
            else if (IsMaxFilePathLength)
            {
                maxFilePathLength?.Invoke(MaxFilePathLength!);
            }
            else if (IsFileExtensionRestriction)
            {
                fileExtensionRestriction?.Invoke(FileExtensionRestriction!);
            }
            else if (IsMaxFileSize)
            {
                maxFileSize?.Invoke(MaxFileSize!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Creation,
                typeof(global::tryAGI.GitHub.RepositoryRuleCreation),
                Update,
                typeof(global::tryAGI.GitHub.RepositoryRuleUpdate),
                Deletion,
                typeof(global::tryAGI.GitHub.RepositoryRuleDeletion),
                RequiredLinearHistory,
                typeof(global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory),
                MergeQueue,
                typeof(global::tryAGI.GitHub.RepositoryRuleMergeQueue),
                RequiredDeployments,
                typeof(global::tryAGI.GitHub.RepositoryRuleRequiredDeployments),
                RequiredSignatures,
                typeof(global::tryAGI.GitHub.RepositoryRuleRequiredSignatures),
                PullRequest,
                typeof(global::tryAGI.GitHub.RepositoryRulePullRequest),
                RequiredStatusChecks,
                typeof(global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks),
                NonFastForward,
                typeof(global::tryAGI.GitHub.RepositoryRuleNonFastForward),
                CommitMessagePattern,
                typeof(global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern),
                CommitAuthorEmailPattern,
                typeof(global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern),
                CommitterEmailPattern,
                typeof(global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern),
                BranchNamePattern,
                typeof(global::tryAGI.GitHub.RepositoryRuleBranchNamePattern),
                TagNamePattern,
                typeof(global::tryAGI.GitHub.RepositoryRuleTagNamePattern),
                Workflows,
                typeof(global::tryAGI.GitHub.RepositoryRuleWorkflows),
                CodeScanning,
                typeof(global::tryAGI.GitHub.RepositoryRuleCodeScanning),
                CopilotCodeReview,
                typeof(global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview),
                LicenseComplianceScanning,
                typeof(global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning),
                FilePathRestriction,
                typeof(global::tryAGI.GitHub.RepositoryRuleFilePathRestriction),
                MaxFilePathLength,
                typeof(global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength),
                FileExtensionRestriction,
                typeof(global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction),
                MaxFileSize,
                typeof(global::tryAGI.GitHub.RepositoryRuleMaxFileSize),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(RepositoryRule other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleCreation?>.Default.Equals(Creation, other.Creation) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleUpdate?>.Default.Equals(Update, other.Update) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleDeletion?>.Default.Equals(Deletion, other.Deletion) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory?>.Default.Equals(RequiredLinearHistory, other.RequiredLinearHistory) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleMergeQueue?>.Default.Equals(MergeQueue, other.MergeQueue) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments?>.Default.Equals(RequiredDeployments, other.RequiredDeployments) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures?>.Default.Equals(RequiredSignatures, other.RequiredSignatures) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRulePullRequest?>.Default.Equals(PullRequest, other.PullRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks?>.Default.Equals(RequiredStatusChecks, other.RequiredStatusChecks) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleNonFastForward?>.Default.Equals(NonFastForward, other.NonFastForward) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern?>.Default.Equals(CommitMessagePattern, other.CommitMessagePattern) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern?>.Default.Equals(CommitAuthorEmailPattern, other.CommitAuthorEmailPattern) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern?>.Default.Equals(CommitterEmailPattern, other.CommitterEmailPattern) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern?>.Default.Equals(BranchNamePattern, other.BranchNamePattern) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleTagNamePattern?>.Default.Equals(TagNamePattern, other.TagNamePattern) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleWorkflows?>.Default.Equals(Workflows, other.Workflows) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleCodeScanning?>.Default.Equals(CodeScanning, other.CodeScanning) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview?>.Default.Equals(CopilotCodeReview, other.CopilotCodeReview) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning?>.Default.Equals(LicenseComplianceScanning, other.LicenseComplianceScanning) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction?>.Default.Equals(FilePathRestriction, other.FilePathRestriction) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength?>.Default.Equals(MaxFilePathLength, other.MaxFilePathLength) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction?>.Default.Equals(FileExtensionRestriction, other.FileExtensionRestriction) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleMaxFileSize?>.Default.Equals(MaxFileSize, other.MaxFileSize)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RepositoryRule obj1, RepositoryRule obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RepositoryRule>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RepositoryRule obj1, RepositoryRule obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RepositoryRule o && Equals(o);
        }
    }
}
