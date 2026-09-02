#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A repository rule.
    /// </summary>
    public readonly partial struct OrgRules : global::System.IEquatable<OrgRules>
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
        ///
        /// </summary>
        public static implicit operator OrgRules(global::tryAGI.GitHub.RepositoryRuleCreation value) => new OrgRules((global::tryAGI.GitHub.RepositoryRuleCreation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleCreation?(OrgRules @this) => @this.Creation;

        /// <summary>
        ///
        /// </summary>
        public OrgRules(global::tryAGI.GitHub.RepositoryRuleCreation? value)
        {
            Creation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRules FromCreation(global::tryAGI.GitHub.RepositoryRuleCreation? value) => new OrgRules(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRules(global::tryAGI.GitHub.RepositoryRuleUpdate value) => new OrgRules((global::tryAGI.GitHub.RepositoryRuleUpdate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleUpdate?(OrgRules @this) => @this.Update;

        /// <summary>
        ///
        /// </summary>
        public OrgRules(global::tryAGI.GitHub.RepositoryRuleUpdate? value)
        {
            Update = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRules FromUpdate(global::tryAGI.GitHub.RepositoryRuleUpdate? value) => new OrgRules(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRules(global::tryAGI.GitHub.RepositoryRuleDeletion value) => new OrgRules((global::tryAGI.GitHub.RepositoryRuleDeletion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleDeletion?(OrgRules @this) => @this.Deletion;

        /// <summary>
        ///
        /// </summary>
        public OrgRules(global::tryAGI.GitHub.RepositoryRuleDeletion? value)
        {
            Deletion = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRules FromDeletion(global::tryAGI.GitHub.RepositoryRuleDeletion? value) => new OrgRules(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRules(global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory value) => new OrgRules((global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory?(OrgRules @this) => @this.RequiredLinearHistory;

        /// <summary>
        ///
        /// </summary>
        public OrgRules(global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory? value)
        {
            RequiredLinearHistory = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRules FromRequiredLinearHistory(global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory? value) => new OrgRules(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRules(global::tryAGI.GitHub.RepositoryRuleRequiredDeployments value) => new OrgRules((global::tryAGI.GitHub.RepositoryRuleRequiredDeployments?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleRequiredDeployments?(OrgRules @this) => @this.RequiredDeployments;

        /// <summary>
        ///
        /// </summary>
        public OrgRules(global::tryAGI.GitHub.RepositoryRuleRequiredDeployments? value)
        {
            RequiredDeployments = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRules FromRequiredDeployments(global::tryAGI.GitHub.RepositoryRuleRequiredDeployments? value) => new OrgRules(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRules(global::tryAGI.GitHub.RepositoryRuleRequiredSignatures value) => new OrgRules((global::tryAGI.GitHub.RepositoryRuleRequiredSignatures?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleRequiredSignatures?(OrgRules @this) => @this.RequiredSignatures;

        /// <summary>
        ///
        /// </summary>
        public OrgRules(global::tryAGI.GitHub.RepositoryRuleRequiredSignatures? value)
        {
            RequiredSignatures = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRules FromRequiredSignatures(global::tryAGI.GitHub.RepositoryRuleRequiredSignatures? value) => new OrgRules(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRules(global::tryAGI.GitHub.RepositoryRulePullRequest value) => new OrgRules((global::tryAGI.GitHub.RepositoryRulePullRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRulePullRequest?(OrgRules @this) => @this.PullRequest;

        /// <summary>
        ///
        /// </summary>
        public OrgRules(global::tryAGI.GitHub.RepositoryRulePullRequest? value)
        {
            PullRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRules FromPullRequest(global::tryAGI.GitHub.RepositoryRulePullRequest? value) => new OrgRules(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRules(global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks value) => new OrgRules((global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks?(OrgRules @this) => @this.RequiredStatusChecks;

        /// <summary>
        ///
        /// </summary>
        public OrgRules(global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks? value)
        {
            RequiredStatusChecks = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRules FromRequiredStatusChecks(global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks? value) => new OrgRules(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRules(global::tryAGI.GitHub.RepositoryRuleNonFastForward value) => new OrgRules((global::tryAGI.GitHub.RepositoryRuleNonFastForward?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleNonFastForward?(OrgRules @this) => @this.NonFastForward;

        /// <summary>
        ///
        /// </summary>
        public OrgRules(global::tryAGI.GitHub.RepositoryRuleNonFastForward? value)
        {
            NonFastForward = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRules FromNonFastForward(global::tryAGI.GitHub.RepositoryRuleNonFastForward? value) => new OrgRules(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRules(global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern value) => new OrgRules((global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern?(OrgRules @this) => @this.CommitMessagePattern;

        /// <summary>
        ///
        /// </summary>
        public OrgRules(global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern? value)
        {
            CommitMessagePattern = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRules FromCommitMessagePattern(global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern? value) => new OrgRules(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRules(global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern value) => new OrgRules((global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern?(OrgRules @this) => @this.CommitAuthorEmailPattern;

        /// <summary>
        ///
        /// </summary>
        public OrgRules(global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern? value)
        {
            CommitAuthorEmailPattern = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRules FromCommitAuthorEmailPattern(global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern? value) => new OrgRules(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRules(global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern value) => new OrgRules((global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern?(OrgRules @this) => @this.CommitterEmailPattern;

        /// <summary>
        ///
        /// </summary>
        public OrgRules(global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern? value)
        {
            CommitterEmailPattern = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRules FromCommitterEmailPattern(global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern? value) => new OrgRules(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRules(global::tryAGI.GitHub.RepositoryRuleBranchNamePattern value) => new OrgRules((global::tryAGI.GitHub.RepositoryRuleBranchNamePattern?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleBranchNamePattern?(OrgRules @this) => @this.BranchNamePattern;

        /// <summary>
        ///
        /// </summary>
        public OrgRules(global::tryAGI.GitHub.RepositoryRuleBranchNamePattern? value)
        {
            BranchNamePattern = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRules FromBranchNamePattern(global::tryAGI.GitHub.RepositoryRuleBranchNamePattern? value) => new OrgRules(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRules(global::tryAGI.GitHub.RepositoryRuleTagNamePattern value) => new OrgRules((global::tryAGI.GitHub.RepositoryRuleTagNamePattern?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleTagNamePattern?(OrgRules @this) => @this.TagNamePattern;

        /// <summary>
        ///
        /// </summary>
        public OrgRules(global::tryAGI.GitHub.RepositoryRuleTagNamePattern? value)
        {
            TagNamePattern = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRules FromTagNamePattern(global::tryAGI.GitHub.RepositoryRuleTagNamePattern? value) => new OrgRules(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRules(global::tryAGI.GitHub.RepositoryRuleFilePathRestriction value) => new OrgRules((global::tryAGI.GitHub.RepositoryRuleFilePathRestriction?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleFilePathRestriction?(OrgRules @this) => @this.FilePathRestriction;

        /// <summary>
        ///
        /// </summary>
        public OrgRules(global::tryAGI.GitHub.RepositoryRuleFilePathRestriction? value)
        {
            FilePathRestriction = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRules FromFilePathRestriction(global::tryAGI.GitHub.RepositoryRuleFilePathRestriction? value) => new OrgRules(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRules(global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength value) => new OrgRules((global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength?(OrgRules @this) => @this.MaxFilePathLength;

        /// <summary>
        ///
        /// </summary>
        public OrgRules(global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength? value)
        {
            MaxFilePathLength = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRules FromMaxFilePathLength(global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength? value) => new OrgRules(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRules(global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction value) => new OrgRules((global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction?(OrgRules @this) => @this.FileExtensionRestriction;

        /// <summary>
        ///
        /// </summary>
        public OrgRules(global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction? value)
        {
            FileExtensionRestriction = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRules FromFileExtensionRestriction(global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction? value) => new OrgRules(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRules(global::tryAGI.GitHub.RepositoryRuleMaxFileSize value) => new OrgRules((global::tryAGI.GitHub.RepositoryRuleMaxFileSize?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleMaxFileSize?(OrgRules @this) => @this.MaxFileSize;

        /// <summary>
        ///
        /// </summary>
        public OrgRules(global::tryAGI.GitHub.RepositoryRuleMaxFileSize? value)
        {
            MaxFileSize = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRules FromMaxFileSize(global::tryAGI.GitHub.RepositoryRuleMaxFileSize? value) => new OrgRules(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRules(global::tryAGI.GitHub.RepositoryRuleWorkflows value) => new OrgRules((global::tryAGI.GitHub.RepositoryRuleWorkflows?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleWorkflows?(OrgRules @this) => @this.Workflows;

        /// <summary>
        ///
        /// </summary>
        public OrgRules(global::tryAGI.GitHub.RepositoryRuleWorkflows? value)
        {
            Workflows = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRules FromWorkflows(global::tryAGI.GitHub.RepositoryRuleWorkflows? value) => new OrgRules(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRules(global::tryAGI.GitHub.RepositoryRuleCodeScanning value) => new OrgRules((global::tryAGI.GitHub.RepositoryRuleCodeScanning?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleCodeScanning?(OrgRules @this) => @this.CodeScanning;

        /// <summary>
        ///
        /// </summary>
        public OrgRules(global::tryAGI.GitHub.RepositoryRuleCodeScanning? value)
        {
            CodeScanning = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRules FromCodeScanning(global::tryAGI.GitHub.RepositoryRuleCodeScanning? value) => new OrgRules(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRules(global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview value) => new OrgRules((global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview?(OrgRules @this) => @this.CopilotCodeReview;

        /// <summary>
        ///
        /// </summary>
        public OrgRules(global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview? value)
        {
            CopilotCodeReview = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRules FromCopilotCodeReview(global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview? value) => new OrgRules(value);

        /// <summary>
        ///
        /// </summary>
        public OrgRules(
            global::tryAGI.GitHub.RepositoryRuleCreation? creation,
            global::tryAGI.GitHub.RepositoryRuleUpdate? update,
            global::tryAGI.GitHub.RepositoryRuleDeletion? deletion,
            global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory? requiredLinearHistory,
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
            global::tryAGI.GitHub.RepositoryRuleFilePathRestriction? filePathRestriction,
            global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength? maxFilePathLength,
            global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction? fileExtensionRestriction,
            global::tryAGI.GitHub.RepositoryRuleMaxFileSize? maxFileSize,
            global::tryAGI.GitHub.RepositoryRuleWorkflows? workflows,
            global::tryAGI.GitHub.RepositoryRuleCodeScanning? codeScanning,
            global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview? copilotCodeReview
            )
        {
            Creation = creation;
            Update = update;
            Deletion = deletion;
            RequiredLinearHistory = requiredLinearHistory;
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
            FilePathRestriction = filePathRestriction;
            MaxFilePathLength = maxFilePathLength;
            FileExtensionRestriction = fileExtensionRestriction;
            MaxFileSize = maxFileSize;
            Workflows = workflows;
            CodeScanning = codeScanning;
            CopilotCodeReview = copilotCodeReview;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CopilotCodeReview as object ??
            CodeScanning as object ??
            Workflows as object ??
            MaxFileSize as object ??
            FileExtensionRestriction as object ??
            MaxFilePathLength as object ??
            FilePathRestriction as object ??
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
            FilePathRestriction?.ToString() ??
            MaxFilePathLength?.ToString() ??
            FileExtensionRestriction?.ToString() ??
            MaxFileSize?.ToString() ??
            Workflows?.ToString() ??
            CodeScanning?.ToString() ??
            CopilotCodeReview?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview || !IsCreation && IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview || !IsCreation && !IsUpdate && IsDeletion && !IsRequiredLinearHistory && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview || !IsCreation && !IsUpdate && !IsDeletion && IsRequiredLinearHistory && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsRequiredDeployments && IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsRequiredDeployments && !IsRequiredSignatures && IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && IsMaxFileSize && !IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && IsWorkflows && !IsCodeScanning && !IsCopilotCodeReview || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && IsCodeScanning && !IsCopilotCodeReview || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning && IsCopilotCodeReview;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleCreation, TResult>? creation = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleUpdate, TResult>? update = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleDeletion, TResult>? deletion = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory, TResult>? requiredLinearHistory = null,
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
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction, TResult>? filePathRestriction = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength, TResult>? maxFilePathLength = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction, TResult>? fileExtensionRestriction = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleMaxFileSize, TResult>? maxFileSize = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleWorkflows, TResult>? workflows = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleCodeScanning, TResult>? codeScanning = null,
            global::System.Func<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview, TResult>? copilotCodeReview = null,
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

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction>? filePathRestriction = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength>? maxFilePathLength = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction>? fileExtensionRestriction = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleMaxFileSize>? maxFileSize = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleWorkflows>? workflows = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleCodeScanning>? codeScanning = null,

            global::System.Action<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview>? copilotCodeReview = null,
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
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleCreation>? creation = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleUpdate>? update = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleDeletion>? deletion = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory>? requiredLinearHistory = null,
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
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction>? filePathRestriction = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength>? maxFilePathLength = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction>? fileExtensionRestriction = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleMaxFileSize>? maxFileSize = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleWorkflows>? workflows = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleCodeScanning>? codeScanning = null,
            global::System.Action<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview>? copilotCodeReview = null,
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
                FilePathRestriction,
                typeof(global::tryAGI.GitHub.RepositoryRuleFilePathRestriction),
                MaxFilePathLength,
                typeof(global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength),
                FileExtensionRestriction,
                typeof(global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction),
                MaxFileSize,
                typeof(global::tryAGI.GitHub.RepositoryRuleMaxFileSize),
                Workflows,
                typeof(global::tryAGI.GitHub.RepositoryRuleWorkflows),
                CodeScanning,
                typeof(global::tryAGI.GitHub.RepositoryRuleCodeScanning),
                CopilotCodeReview,
                typeof(global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview),
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
        public bool Equals(OrgRules other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleCreation?>.Default.Equals(Creation, other.Creation) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleUpdate?>.Default.Equals(Update, other.Update) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleDeletion?>.Default.Equals(Deletion, other.Deletion) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory?>.Default.Equals(RequiredLinearHistory, other.RequiredLinearHistory) &&
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction?>.Default.Equals(FilePathRestriction, other.FilePathRestriction) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength?>.Default.Equals(MaxFilePathLength, other.MaxFilePathLength) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction?>.Default.Equals(FileExtensionRestriction, other.FileExtensionRestriction) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleMaxFileSize?>.Default.Equals(MaxFileSize, other.MaxFileSize) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleWorkflows?>.Default.Equals(Workflows, other.Workflows) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleCodeScanning?>.Default.Equals(CodeScanning, other.CodeScanning) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview?>.Default.Equals(CopilotCodeReview, other.CopilotCodeReview)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OrgRules obj1, OrgRules obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OrgRules>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OrgRules obj1, OrgRules obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OrgRules o && Equals(o);
        }
    }
}
