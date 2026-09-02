#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Details on the location where the token was initially detected. This can be a commit, wiki commit, issue, discussion, pull request.
    /// </summary>
    public readonly partial struct NullableSecretScanningFirstDetectedLocation : global::System.IEquatable<NullableSecretScanningFirstDetectedLocation>
    {
        /// <summary>
        /// Represents a 'commit' secret scanning location type. This location type shows that a secret was detected inside a commit to a repository.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.SecretScanningLocationCommit? Commit { get; init; }
#else
        public global::tryAGI.GitHub.SecretScanningLocationCommit? Commit { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Commit))]
#endif
        public bool IsCommit => Commit != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCommit(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.SecretScanningLocationCommit? value)
        {
            value = Commit;
            return IsCommit;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.SecretScanningLocationCommit PickCommit() => IsCommit
            ? Commit!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Commit' but the value was {ToString()}.");

        /// <summary>
        /// Represents a 'wiki_commit' secret scanning location type. This location type shows that a secret was detected inside a commit to a repository wiki.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.SecretScanningLocationWikiCommit? WikiCommit { get; init; }
#else
        public global::tryAGI.GitHub.SecretScanningLocationWikiCommit? WikiCommit { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WikiCommit))]
#endif
        public bool IsWikiCommit => WikiCommit != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWikiCommit(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.SecretScanningLocationWikiCommit? value)
        {
            value = WikiCommit;
            return IsWikiCommit;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.SecretScanningLocationWikiCommit PickWikiCommit() => IsWikiCommit
            ? WikiCommit!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WikiCommit' but the value was {ToString()}.");

        /// <summary>
        /// Represents an 'issue_title' secret scanning location type. This location type shows that a secret was detected in the title of an issue.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.SecretScanningLocationIssueTitle? IssueTitle { get; init; }
#else
        public global::tryAGI.GitHub.SecretScanningLocationIssueTitle? IssueTitle { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IssueTitle))]
#endif
        public bool IsIssueTitle => IssueTitle != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickIssueTitle(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.SecretScanningLocationIssueTitle? value)
        {
            value = IssueTitle;
            return IsIssueTitle;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.SecretScanningLocationIssueTitle PickIssueTitle() => IsIssueTitle
            ? IssueTitle!
            : throw new global::System.InvalidOperationException($"Expected union variant 'IssueTitle' but the value was {ToString()}.");

        /// <summary>
        /// Represents an 'issue_body' secret scanning location type. This location type shows that a secret was detected in the body of an issue.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.SecretScanningLocationIssueBody? IssueBody { get; init; }
#else
        public global::tryAGI.GitHub.SecretScanningLocationIssueBody? IssueBody { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IssueBody))]
#endif
        public bool IsIssueBody => IssueBody != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickIssueBody(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.SecretScanningLocationIssueBody? value)
        {
            value = IssueBody;
            return IsIssueBody;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.SecretScanningLocationIssueBody PickIssueBody() => IsIssueBody
            ? IssueBody!
            : throw new global::System.InvalidOperationException($"Expected union variant 'IssueBody' but the value was {ToString()}.");

        /// <summary>
        /// Represents an 'issue_comment' secret scanning location type. This location type shows that a secret was detected in a comment on an issue.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.SecretScanningLocationIssueComment? IssueComment { get; init; }
#else
        public global::tryAGI.GitHub.SecretScanningLocationIssueComment? IssueComment { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IssueComment))]
#endif
        public bool IsIssueComment => IssueComment != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickIssueComment(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.SecretScanningLocationIssueComment? value)
        {
            value = IssueComment;
            return IsIssueComment;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.SecretScanningLocationIssueComment PickIssueComment() => IsIssueComment
            ? IssueComment!
            : throw new global::System.InvalidOperationException($"Expected union variant 'IssueComment' but the value was {ToString()}.");

        /// <summary>
        /// Represents a 'discussion_title' secret scanning location type. This location type shows that a secret was detected in the title of a discussion.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle? DiscussionTitle { get; init; }
#else
        public global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle? DiscussionTitle { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DiscussionTitle))]
#endif
        public bool IsDiscussionTitle => DiscussionTitle != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDiscussionTitle(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle? value)
        {
            value = DiscussionTitle;
            return IsDiscussionTitle;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle PickDiscussionTitle() => IsDiscussionTitle
            ? DiscussionTitle!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DiscussionTitle' but the value was {ToString()}.");

        /// <summary>
        /// Represents a 'discussion_body' secret scanning location type. This location type shows that a secret was detected in the body of a discussion.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.SecretScanningLocationDiscussionBody? DiscussionBody { get; init; }
#else
        public global::tryAGI.GitHub.SecretScanningLocationDiscussionBody? DiscussionBody { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DiscussionBody))]
#endif
        public bool IsDiscussionBody => DiscussionBody != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDiscussionBody(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.SecretScanningLocationDiscussionBody? value)
        {
            value = DiscussionBody;
            return IsDiscussionBody;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.SecretScanningLocationDiscussionBody PickDiscussionBody() => IsDiscussionBody
            ? DiscussionBody!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DiscussionBody' but the value was {ToString()}.");

        /// <summary>
        /// Represents a 'discussion_comment' secret scanning location type. This location type shows that a secret was detected in a comment on a discussion.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.SecretScanningLocationDiscussionComment? DiscussionComment { get; init; }
#else
        public global::tryAGI.GitHub.SecretScanningLocationDiscussionComment? DiscussionComment { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DiscussionComment))]
#endif
        public bool IsDiscussionComment => DiscussionComment != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDiscussionComment(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.SecretScanningLocationDiscussionComment? value)
        {
            value = DiscussionComment;
            return IsDiscussionComment;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.SecretScanningLocationDiscussionComment PickDiscussionComment() => IsDiscussionComment
            ? DiscussionComment!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DiscussionComment' but the value was {ToString()}.");

        /// <summary>
        /// Represents a 'pull_request_title' secret scanning location type. This location type shows that a secret was detected in the title of a pull request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle? PullRequestTitle { get; init; }
#else
        public global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle? PullRequestTitle { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PullRequestTitle))]
#endif
        public bool IsPullRequestTitle => PullRequestTitle != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPullRequestTitle(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle? value)
        {
            value = PullRequestTitle;
            return IsPullRequestTitle;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle PickPullRequestTitle() => IsPullRequestTitle
            ? PullRequestTitle!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PullRequestTitle' but the value was {ToString()}.");

        /// <summary>
        /// Represents a 'pull_request_body' secret scanning location type. This location type shows that a secret was detected in the body of a pull request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.SecretScanningLocationPullRequestBody? PullRequestBody { get; init; }
#else
        public global::tryAGI.GitHub.SecretScanningLocationPullRequestBody? PullRequestBody { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PullRequestBody))]
#endif
        public bool IsPullRequestBody => PullRequestBody != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPullRequestBody(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.SecretScanningLocationPullRequestBody? value)
        {
            value = PullRequestBody;
            return IsPullRequestBody;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.SecretScanningLocationPullRequestBody PickPullRequestBody() => IsPullRequestBody
            ? PullRequestBody!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PullRequestBody' but the value was {ToString()}.");

        /// <summary>
        /// Represents a 'pull_request_comment' secret scanning location type. This location type shows that a secret was detected in a comment on a pull request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.SecretScanningLocationPullRequestComment? PullRequestComment { get; init; }
#else
        public global::tryAGI.GitHub.SecretScanningLocationPullRequestComment? PullRequestComment { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PullRequestComment))]
#endif
        public bool IsPullRequestComment => PullRequestComment != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPullRequestComment(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.SecretScanningLocationPullRequestComment? value)
        {
            value = PullRequestComment;
            return IsPullRequestComment;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.SecretScanningLocationPullRequestComment PickPullRequestComment() => IsPullRequestComment
            ? PullRequestComment!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PullRequestComment' but the value was {ToString()}.");

        /// <summary>
        /// Represents a 'pull_request_review' secret scanning location type. This location type shows that a secret was detected in a review on a pull request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.SecretScanningLocationPullRequestReview? PullRequestReview { get; init; }
#else
        public global::tryAGI.GitHub.SecretScanningLocationPullRequestReview? PullRequestReview { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PullRequestReview))]
#endif
        public bool IsPullRequestReview => PullRequestReview != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPullRequestReview(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.SecretScanningLocationPullRequestReview? value)
        {
            value = PullRequestReview;
            return IsPullRequestReview;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.SecretScanningLocationPullRequestReview PickPullRequestReview() => IsPullRequestReview
            ? PullRequestReview!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PullRequestReview' but the value was {ToString()}.");

        /// <summary>
        /// Represents a 'pull_request_review_comment' secret scanning location type. This location type shows that a secret was detected in a review comment on a pull request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment? PullRequestReviewComment { get; init; }
#else
        public global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment? PullRequestReviewComment { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PullRequestReviewComment))]
#endif
        public bool IsPullRequestReviewComment => PullRequestReviewComment != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPullRequestReviewComment(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment? value)
        {
            value = PullRequestReviewComment;
            return IsPullRequestReviewComment;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment PickPullRequestReviewComment() => IsPullRequestReviewComment
            ? PullRequestReviewComment!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PullRequestReviewComment' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationCommit value) => new NullableSecretScanningFirstDetectedLocation((global::tryAGI.GitHub.SecretScanningLocationCommit?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.SecretScanningLocationCommit?(NullableSecretScanningFirstDetectedLocation @this) => @this.Commit;

        /// <summary>
        ///
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationCommit? value)
        {
            Commit = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NullableSecretScanningFirstDetectedLocation FromCommit(global::tryAGI.GitHub.SecretScanningLocationCommit? value) => new NullableSecretScanningFirstDetectedLocation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationWikiCommit value) => new NullableSecretScanningFirstDetectedLocation((global::tryAGI.GitHub.SecretScanningLocationWikiCommit?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.SecretScanningLocationWikiCommit?(NullableSecretScanningFirstDetectedLocation @this) => @this.WikiCommit;

        /// <summary>
        ///
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationWikiCommit? value)
        {
            WikiCommit = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NullableSecretScanningFirstDetectedLocation FromWikiCommit(global::tryAGI.GitHub.SecretScanningLocationWikiCommit? value) => new NullableSecretScanningFirstDetectedLocation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationIssueTitle value) => new NullableSecretScanningFirstDetectedLocation((global::tryAGI.GitHub.SecretScanningLocationIssueTitle?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.SecretScanningLocationIssueTitle?(NullableSecretScanningFirstDetectedLocation @this) => @this.IssueTitle;

        /// <summary>
        ///
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationIssueTitle? value)
        {
            IssueTitle = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NullableSecretScanningFirstDetectedLocation FromIssueTitle(global::tryAGI.GitHub.SecretScanningLocationIssueTitle? value) => new NullableSecretScanningFirstDetectedLocation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationIssueBody value) => new NullableSecretScanningFirstDetectedLocation((global::tryAGI.GitHub.SecretScanningLocationIssueBody?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.SecretScanningLocationIssueBody?(NullableSecretScanningFirstDetectedLocation @this) => @this.IssueBody;

        /// <summary>
        ///
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationIssueBody? value)
        {
            IssueBody = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NullableSecretScanningFirstDetectedLocation FromIssueBody(global::tryAGI.GitHub.SecretScanningLocationIssueBody? value) => new NullableSecretScanningFirstDetectedLocation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationIssueComment value) => new NullableSecretScanningFirstDetectedLocation((global::tryAGI.GitHub.SecretScanningLocationIssueComment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.SecretScanningLocationIssueComment?(NullableSecretScanningFirstDetectedLocation @this) => @this.IssueComment;

        /// <summary>
        ///
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationIssueComment? value)
        {
            IssueComment = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NullableSecretScanningFirstDetectedLocation FromIssueComment(global::tryAGI.GitHub.SecretScanningLocationIssueComment? value) => new NullableSecretScanningFirstDetectedLocation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle value) => new NullableSecretScanningFirstDetectedLocation((global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle?(NullableSecretScanningFirstDetectedLocation @this) => @this.DiscussionTitle;

        /// <summary>
        ///
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle? value)
        {
            DiscussionTitle = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NullableSecretScanningFirstDetectedLocation FromDiscussionTitle(global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle? value) => new NullableSecretScanningFirstDetectedLocation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationDiscussionBody value) => new NullableSecretScanningFirstDetectedLocation((global::tryAGI.GitHub.SecretScanningLocationDiscussionBody?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.SecretScanningLocationDiscussionBody?(NullableSecretScanningFirstDetectedLocation @this) => @this.DiscussionBody;

        /// <summary>
        ///
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationDiscussionBody? value)
        {
            DiscussionBody = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NullableSecretScanningFirstDetectedLocation FromDiscussionBody(global::tryAGI.GitHub.SecretScanningLocationDiscussionBody? value) => new NullableSecretScanningFirstDetectedLocation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationDiscussionComment value) => new NullableSecretScanningFirstDetectedLocation((global::tryAGI.GitHub.SecretScanningLocationDiscussionComment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.SecretScanningLocationDiscussionComment?(NullableSecretScanningFirstDetectedLocation @this) => @this.DiscussionComment;

        /// <summary>
        ///
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationDiscussionComment? value)
        {
            DiscussionComment = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NullableSecretScanningFirstDetectedLocation FromDiscussionComment(global::tryAGI.GitHub.SecretScanningLocationDiscussionComment? value) => new NullableSecretScanningFirstDetectedLocation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle value) => new NullableSecretScanningFirstDetectedLocation((global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle?(NullableSecretScanningFirstDetectedLocation @this) => @this.PullRequestTitle;

        /// <summary>
        ///
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle? value)
        {
            PullRequestTitle = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NullableSecretScanningFirstDetectedLocation FromPullRequestTitle(global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle? value) => new NullableSecretScanningFirstDetectedLocation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationPullRequestBody value) => new NullableSecretScanningFirstDetectedLocation((global::tryAGI.GitHub.SecretScanningLocationPullRequestBody?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.SecretScanningLocationPullRequestBody?(NullableSecretScanningFirstDetectedLocation @this) => @this.PullRequestBody;

        /// <summary>
        ///
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationPullRequestBody? value)
        {
            PullRequestBody = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NullableSecretScanningFirstDetectedLocation FromPullRequestBody(global::tryAGI.GitHub.SecretScanningLocationPullRequestBody? value) => new NullableSecretScanningFirstDetectedLocation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationPullRequestComment value) => new NullableSecretScanningFirstDetectedLocation((global::tryAGI.GitHub.SecretScanningLocationPullRequestComment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.SecretScanningLocationPullRequestComment?(NullableSecretScanningFirstDetectedLocation @this) => @this.PullRequestComment;

        /// <summary>
        ///
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationPullRequestComment? value)
        {
            PullRequestComment = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NullableSecretScanningFirstDetectedLocation FromPullRequestComment(global::tryAGI.GitHub.SecretScanningLocationPullRequestComment? value) => new NullableSecretScanningFirstDetectedLocation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationPullRequestReview value) => new NullableSecretScanningFirstDetectedLocation((global::tryAGI.GitHub.SecretScanningLocationPullRequestReview?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.SecretScanningLocationPullRequestReview?(NullableSecretScanningFirstDetectedLocation @this) => @this.PullRequestReview;

        /// <summary>
        ///
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationPullRequestReview? value)
        {
            PullRequestReview = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NullableSecretScanningFirstDetectedLocation FromPullRequestReview(global::tryAGI.GitHub.SecretScanningLocationPullRequestReview? value) => new NullableSecretScanningFirstDetectedLocation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment value) => new NullableSecretScanningFirstDetectedLocation((global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment?(NullableSecretScanningFirstDetectedLocation @this) => @this.PullRequestReviewComment;

        /// <summary>
        ///
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment? value)
        {
            PullRequestReviewComment = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NullableSecretScanningFirstDetectedLocation FromPullRequestReviewComment(global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment? value) => new NullableSecretScanningFirstDetectedLocation(value);

        /// <summary>
        ///
        /// </summary>
        public NullableSecretScanningFirstDetectedLocation(
            global::tryAGI.GitHub.SecretScanningLocationCommit? commit,
            global::tryAGI.GitHub.SecretScanningLocationWikiCommit? wikiCommit,
            global::tryAGI.GitHub.SecretScanningLocationIssueTitle? issueTitle,
            global::tryAGI.GitHub.SecretScanningLocationIssueBody? issueBody,
            global::tryAGI.GitHub.SecretScanningLocationIssueComment? issueComment,
            global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle? discussionTitle,
            global::tryAGI.GitHub.SecretScanningLocationDiscussionBody? discussionBody,
            global::tryAGI.GitHub.SecretScanningLocationDiscussionComment? discussionComment,
            global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle? pullRequestTitle,
            global::tryAGI.GitHub.SecretScanningLocationPullRequestBody? pullRequestBody,
            global::tryAGI.GitHub.SecretScanningLocationPullRequestComment? pullRequestComment,
            global::tryAGI.GitHub.SecretScanningLocationPullRequestReview? pullRequestReview,
            global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment? pullRequestReviewComment
            )
        {
            Commit = commit;
            WikiCommit = wikiCommit;
            IssueTitle = issueTitle;
            IssueBody = issueBody;
            IssueComment = issueComment;
            DiscussionTitle = discussionTitle;
            DiscussionBody = discussionBody;
            DiscussionComment = discussionComment;
            PullRequestTitle = pullRequestTitle;
            PullRequestBody = pullRequestBody;
            PullRequestComment = pullRequestComment;
            PullRequestReview = pullRequestReview;
            PullRequestReviewComment = pullRequestReviewComment;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PullRequestReviewComment as object ??
            PullRequestReview as object ??
            PullRequestComment as object ??
            PullRequestBody as object ??
            PullRequestTitle as object ??
            DiscussionComment as object ??
            DiscussionBody as object ??
            DiscussionTitle as object ??
            IssueComment as object ??
            IssueBody as object ??
            IssueTitle as object ??
            WikiCommit as object ??
            Commit as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Commit?.ToString() ??
            WikiCommit?.ToString() ??
            IssueTitle?.ToString() ??
            IssueBody?.ToString() ??
            IssueComment?.ToString() ??
            DiscussionTitle?.ToString() ??
            DiscussionBody?.ToString() ??
            DiscussionComment?.ToString() ??
            PullRequestTitle?.ToString() ??
            PullRequestBody?.ToString() ??
            PullRequestComment?.ToString() ??
            PullRequestReview?.ToString() ??
            PullRequestReviewComment?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCommit && !IsWikiCommit && !IsIssueTitle && !IsIssueBody && !IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && IsWikiCommit && !IsIssueTitle && !IsIssueBody && !IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && IsIssueTitle && !IsIssueBody && !IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && !IsIssueTitle && IsIssueBody && !IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && !IsIssueTitle && !IsIssueBody && IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && !IsIssueTitle && !IsIssueBody && !IsIssueComment && IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && !IsIssueTitle && !IsIssueBody && !IsIssueComment && !IsDiscussionTitle && IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && !IsIssueTitle && !IsIssueBody && !IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && !IsIssueTitle && !IsIssueBody && !IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && !IsIssueTitle && !IsIssueBody && !IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && !IsIssueTitle && !IsIssueBody && !IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && IsPullRequestComment && !IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && !IsIssueTitle && !IsIssueBody && !IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && IsPullRequestReview && !IsPullRequestReviewComment || !IsCommit && !IsWikiCommit && !IsIssueTitle && !IsIssueBody && !IsIssueComment && !IsDiscussionTitle && !IsDiscussionBody && !IsDiscussionComment && !IsPullRequestTitle && !IsPullRequestBody && !IsPullRequestComment && !IsPullRequestReview && IsPullRequestReviewComment;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.GitHub.SecretScanningLocationCommit, TResult>? commit = null,
            global::System.Func<global::tryAGI.GitHub.SecretScanningLocationWikiCommit, TResult>? wikiCommit = null,
            global::System.Func<global::tryAGI.GitHub.SecretScanningLocationIssueTitle, TResult>? issueTitle = null,
            global::System.Func<global::tryAGI.GitHub.SecretScanningLocationIssueBody, TResult>? issueBody = null,
            global::System.Func<global::tryAGI.GitHub.SecretScanningLocationIssueComment, TResult>? issueComment = null,
            global::System.Func<global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle, TResult>? discussionTitle = null,
            global::System.Func<global::tryAGI.GitHub.SecretScanningLocationDiscussionBody, TResult>? discussionBody = null,
            global::System.Func<global::tryAGI.GitHub.SecretScanningLocationDiscussionComment, TResult>? discussionComment = null,
            global::System.Func<global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle, TResult>? pullRequestTitle = null,
            global::System.Func<global::tryAGI.GitHub.SecretScanningLocationPullRequestBody, TResult>? pullRequestBody = null,
            global::System.Func<global::tryAGI.GitHub.SecretScanningLocationPullRequestComment, TResult>? pullRequestComment = null,
            global::System.Func<global::tryAGI.GitHub.SecretScanningLocationPullRequestReview, TResult>? pullRequestReview = null,
            global::System.Func<global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment, TResult>? pullRequestReviewComment = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCommit && commit != null)
            {
                return commit(Commit!);
            }
            else if (IsWikiCommit && wikiCommit != null)
            {
                return wikiCommit(WikiCommit!);
            }
            else if (IsIssueTitle && issueTitle != null)
            {
                return issueTitle(IssueTitle!);
            }
            else if (IsIssueBody && issueBody != null)
            {
                return issueBody(IssueBody!);
            }
            else if (IsIssueComment && issueComment != null)
            {
                return issueComment(IssueComment!);
            }
            else if (IsDiscussionTitle && discussionTitle != null)
            {
                return discussionTitle(DiscussionTitle!);
            }
            else if (IsDiscussionBody && discussionBody != null)
            {
                return discussionBody(DiscussionBody!);
            }
            else if (IsDiscussionComment && discussionComment != null)
            {
                return discussionComment(DiscussionComment!);
            }
            else if (IsPullRequestTitle && pullRequestTitle != null)
            {
                return pullRequestTitle(PullRequestTitle!);
            }
            else if (IsPullRequestBody && pullRequestBody != null)
            {
                return pullRequestBody(PullRequestBody!);
            }
            else if (IsPullRequestComment && pullRequestComment != null)
            {
                return pullRequestComment(PullRequestComment!);
            }
            else if (IsPullRequestReview && pullRequestReview != null)
            {
                return pullRequestReview(PullRequestReview!);
            }
            else if (IsPullRequestReviewComment && pullRequestReviewComment != null)
            {
                return pullRequestReviewComment(PullRequestReviewComment!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationCommit>? commit = null,

            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationWikiCommit>? wikiCommit = null,

            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationIssueTitle>? issueTitle = null,

            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationIssueBody>? issueBody = null,

            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationIssueComment>? issueComment = null,

            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle>? discussionTitle = null,

            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationDiscussionBody>? discussionBody = null,

            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationDiscussionComment>? discussionComment = null,

            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle>? pullRequestTitle = null,

            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationPullRequestBody>? pullRequestBody = null,

            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationPullRequestComment>? pullRequestComment = null,

            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationPullRequestReview>? pullRequestReview = null,

            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment>? pullRequestReviewComment = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCommit)
            {
                commit?.Invoke(Commit!);
            }
            else if (IsWikiCommit)
            {
                wikiCommit?.Invoke(WikiCommit!);
            }
            else if (IsIssueTitle)
            {
                issueTitle?.Invoke(IssueTitle!);
            }
            else if (IsIssueBody)
            {
                issueBody?.Invoke(IssueBody!);
            }
            else if (IsIssueComment)
            {
                issueComment?.Invoke(IssueComment!);
            }
            else if (IsDiscussionTitle)
            {
                discussionTitle?.Invoke(DiscussionTitle!);
            }
            else if (IsDiscussionBody)
            {
                discussionBody?.Invoke(DiscussionBody!);
            }
            else if (IsDiscussionComment)
            {
                discussionComment?.Invoke(DiscussionComment!);
            }
            else if (IsPullRequestTitle)
            {
                pullRequestTitle?.Invoke(PullRequestTitle!);
            }
            else if (IsPullRequestBody)
            {
                pullRequestBody?.Invoke(PullRequestBody!);
            }
            else if (IsPullRequestComment)
            {
                pullRequestComment?.Invoke(PullRequestComment!);
            }
            else if (IsPullRequestReview)
            {
                pullRequestReview?.Invoke(PullRequestReview!);
            }
            else if (IsPullRequestReviewComment)
            {
                pullRequestReviewComment?.Invoke(PullRequestReviewComment!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationCommit>? commit = null,
            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationWikiCommit>? wikiCommit = null,
            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationIssueTitle>? issueTitle = null,
            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationIssueBody>? issueBody = null,
            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationIssueComment>? issueComment = null,
            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle>? discussionTitle = null,
            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationDiscussionBody>? discussionBody = null,
            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationDiscussionComment>? discussionComment = null,
            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle>? pullRequestTitle = null,
            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationPullRequestBody>? pullRequestBody = null,
            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationPullRequestComment>? pullRequestComment = null,
            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationPullRequestReview>? pullRequestReview = null,
            global::System.Action<global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment>? pullRequestReviewComment = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCommit)
            {
                commit?.Invoke(Commit!);
            }
            else if (IsWikiCommit)
            {
                wikiCommit?.Invoke(WikiCommit!);
            }
            else if (IsIssueTitle)
            {
                issueTitle?.Invoke(IssueTitle!);
            }
            else if (IsIssueBody)
            {
                issueBody?.Invoke(IssueBody!);
            }
            else if (IsIssueComment)
            {
                issueComment?.Invoke(IssueComment!);
            }
            else if (IsDiscussionTitle)
            {
                discussionTitle?.Invoke(DiscussionTitle!);
            }
            else if (IsDiscussionBody)
            {
                discussionBody?.Invoke(DiscussionBody!);
            }
            else if (IsDiscussionComment)
            {
                discussionComment?.Invoke(DiscussionComment!);
            }
            else if (IsPullRequestTitle)
            {
                pullRequestTitle?.Invoke(PullRequestTitle!);
            }
            else if (IsPullRequestBody)
            {
                pullRequestBody?.Invoke(PullRequestBody!);
            }
            else if (IsPullRequestComment)
            {
                pullRequestComment?.Invoke(PullRequestComment!);
            }
            else if (IsPullRequestReview)
            {
                pullRequestReview?.Invoke(PullRequestReview!);
            }
            else if (IsPullRequestReviewComment)
            {
                pullRequestReviewComment?.Invoke(PullRequestReviewComment!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Commit,
                typeof(global::tryAGI.GitHub.SecretScanningLocationCommit),
                WikiCommit,
                typeof(global::tryAGI.GitHub.SecretScanningLocationWikiCommit),
                IssueTitle,
                typeof(global::tryAGI.GitHub.SecretScanningLocationIssueTitle),
                IssueBody,
                typeof(global::tryAGI.GitHub.SecretScanningLocationIssueBody),
                IssueComment,
                typeof(global::tryAGI.GitHub.SecretScanningLocationIssueComment),
                DiscussionTitle,
                typeof(global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle),
                DiscussionBody,
                typeof(global::tryAGI.GitHub.SecretScanningLocationDiscussionBody),
                DiscussionComment,
                typeof(global::tryAGI.GitHub.SecretScanningLocationDiscussionComment),
                PullRequestTitle,
                typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle),
                PullRequestBody,
                typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestBody),
                PullRequestComment,
                typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestComment),
                PullRequestReview,
                typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestReview),
                PullRequestReviewComment,
                typeof(global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment),
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
        public bool Equals(NullableSecretScanningFirstDetectedLocation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.SecretScanningLocationCommit?>.Default.Equals(Commit, other.Commit) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.SecretScanningLocationWikiCommit?>.Default.Equals(WikiCommit, other.WikiCommit) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.SecretScanningLocationIssueTitle?>.Default.Equals(IssueTitle, other.IssueTitle) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.SecretScanningLocationIssueBody?>.Default.Equals(IssueBody, other.IssueBody) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.SecretScanningLocationIssueComment?>.Default.Equals(IssueComment, other.IssueComment) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle?>.Default.Equals(DiscussionTitle, other.DiscussionTitle) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.SecretScanningLocationDiscussionBody?>.Default.Equals(DiscussionBody, other.DiscussionBody) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.SecretScanningLocationDiscussionComment?>.Default.Equals(DiscussionComment, other.DiscussionComment) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle?>.Default.Equals(PullRequestTitle, other.PullRequestTitle) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.SecretScanningLocationPullRequestBody?>.Default.Equals(PullRequestBody, other.PullRequestBody) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.SecretScanningLocationPullRequestComment?>.Default.Equals(PullRequestComment, other.PullRequestComment) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.SecretScanningLocationPullRequestReview?>.Default.Equals(PullRequestReview, other.PullRequestReview) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment?>.Default.Equals(PullRequestReviewComment, other.PullRequestReviewComment)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(NullableSecretScanningFirstDetectedLocation obj1, NullableSecretScanningFirstDetectedLocation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NullableSecretScanningFirstDetectedLocation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(NullableSecretScanningFirstDetectedLocation obj1, NullableSecretScanningFirstDetectedLocation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NullableSecretScanningFirstDetectedLocation o && Equals(o);
        }
    }
}
