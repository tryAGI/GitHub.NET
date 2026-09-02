#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Timeline Event
    /// </summary>
    public readonly partial struct TimelineIssueEvents : global::System.IEquatable<TimelineIssueEvents>
    {
        /// <summary>
        /// Labeled Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.LabeledIssueEvent? LabeledIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.LabeledIssueEvent? LabeledIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LabeledIssueEvent))]
#endif
        public bool IsLabeledIssueEvent => LabeledIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLabeledIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.LabeledIssueEvent? value)
        {
            value = LabeledIssueEvent;
            return IsLabeledIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.LabeledIssueEvent PickLabeledIssueEvent() => IsLabeledIssueEvent
            ? LabeledIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LabeledIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Unlabeled Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.UnlabeledIssueEvent? UnlabeledIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.UnlabeledIssueEvent? UnlabeledIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnlabeledIssueEvent))]
#endif
        public bool IsUnlabeledIssueEvent => UnlabeledIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnlabeledIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.UnlabeledIssueEvent? value)
        {
            value = UnlabeledIssueEvent;
            return IsUnlabeledIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.UnlabeledIssueEvent PickUnlabeledIssueEvent() => IsUnlabeledIssueEvent
            ? UnlabeledIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnlabeledIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Milestoned Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.MilestonedIssueEvent? MilestonedIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.MilestonedIssueEvent? MilestonedIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MilestonedIssueEvent))]
#endif
        public bool IsMilestonedIssueEvent => MilestonedIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMilestonedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.MilestonedIssueEvent? value)
        {
            value = MilestonedIssueEvent;
            return IsMilestonedIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.MilestonedIssueEvent PickMilestonedIssueEvent() => IsMilestonedIssueEvent
            ? MilestonedIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MilestonedIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Demilestoned Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.DemilestonedIssueEvent? DemilestonedIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.DemilestonedIssueEvent? DemilestonedIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DemilestonedIssueEvent))]
#endif
        public bool IsDemilestonedIssueEvent => DemilestonedIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDemilestonedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.DemilestonedIssueEvent? value)
        {
            value = DemilestonedIssueEvent;
            return IsDemilestonedIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.DemilestonedIssueEvent PickDemilestonedIssueEvent() => IsDemilestonedIssueEvent
            ? DemilestonedIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DemilestonedIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Renamed Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RenamedIssueEvent? RenamedIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.RenamedIssueEvent? RenamedIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RenamedIssueEvent))]
#endif
        public bool IsRenamedIssueEvent => RenamedIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRenamedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RenamedIssueEvent? value)
        {
            value = RenamedIssueEvent;
            return IsRenamedIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RenamedIssueEvent PickRenamedIssueEvent() => IsRenamedIssueEvent
            ? RenamedIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RenamedIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Review Requested Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.ReviewRequestedIssueEvent? ReviewRequestedIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.ReviewRequestedIssueEvent? ReviewRequestedIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewRequestedIssueEvent))]
#endif
        public bool IsReviewRequestedIssueEvent => ReviewRequestedIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReviewRequestedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.ReviewRequestedIssueEvent? value)
        {
            value = ReviewRequestedIssueEvent;
            return IsReviewRequestedIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.ReviewRequestedIssueEvent PickReviewRequestedIssueEvent() => IsReviewRequestedIssueEvent
            ? ReviewRequestedIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReviewRequestedIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Review Request Removed Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent? ReviewRequestRemovedIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent? ReviewRequestRemovedIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewRequestRemovedIssueEvent))]
#endif
        public bool IsReviewRequestRemovedIssueEvent => ReviewRequestRemovedIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReviewRequestRemovedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent? value)
        {
            value = ReviewRequestRemovedIssueEvent;
            return IsReviewRequestRemovedIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent PickReviewRequestRemovedIssueEvent() => IsReviewRequestRemovedIssueEvent
            ? ReviewRequestRemovedIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReviewRequestRemovedIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Review Dismissed Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.ReviewDismissedIssueEvent? ReviewDismissedIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.ReviewDismissedIssueEvent? ReviewDismissedIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewDismissedIssueEvent))]
#endif
        public bool IsReviewDismissedIssueEvent => ReviewDismissedIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReviewDismissedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.ReviewDismissedIssueEvent? value)
        {
            value = ReviewDismissedIssueEvent;
            return IsReviewDismissedIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.ReviewDismissedIssueEvent PickReviewDismissedIssueEvent() => IsReviewDismissedIssueEvent
            ? ReviewDismissedIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReviewDismissedIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Locked Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.LockedIssueEvent? LockedIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.LockedIssueEvent? LockedIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LockedIssueEvent))]
#endif
        public bool IsLockedIssueEvent => LockedIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLockedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.LockedIssueEvent? value)
        {
            value = LockedIssueEvent;
            return IsLockedIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.LockedIssueEvent PickLockedIssueEvent() => IsLockedIssueEvent
            ? LockedIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LockedIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Added to Project Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AddedToProjectIssueEvent? AddedToProjectIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.AddedToProjectIssueEvent? AddedToProjectIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AddedToProjectIssueEvent))]
#endif
        public bool IsAddedToProjectIssueEvent => AddedToProjectIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAddedToProjectIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AddedToProjectIssueEvent? value)
        {
            value = AddedToProjectIssueEvent;
            return IsAddedToProjectIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AddedToProjectIssueEvent PickAddedToProjectIssueEvent() => IsAddedToProjectIssueEvent
            ? AddedToProjectIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AddedToProjectIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Moved Column in Project Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.MovedColumnInProjectIssueEvent? MovedColumnInProjectIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.MovedColumnInProjectIssueEvent? MovedColumnInProjectIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MovedColumnInProjectIssueEvent))]
#endif
        public bool IsMovedColumnInProjectIssueEvent => MovedColumnInProjectIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMovedColumnInProjectIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.MovedColumnInProjectIssueEvent? value)
        {
            value = MovedColumnInProjectIssueEvent;
            return IsMovedColumnInProjectIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.MovedColumnInProjectIssueEvent PickMovedColumnInProjectIssueEvent() => IsMovedColumnInProjectIssueEvent
            ? MovedColumnInProjectIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MovedColumnInProjectIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Removed from Project Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RemovedFromProjectIssueEvent? RemovedFromProjectIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.RemovedFromProjectIssueEvent? RemovedFromProjectIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RemovedFromProjectIssueEvent))]
#endif
        public bool IsRemovedFromProjectIssueEvent => RemovedFromProjectIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRemovedFromProjectIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RemovedFromProjectIssueEvent? value)
        {
            value = RemovedFromProjectIssueEvent;
            return IsRemovedFromProjectIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RemovedFromProjectIssueEvent PickRemovedFromProjectIssueEvent() => IsRemovedFromProjectIssueEvent
            ? RemovedFromProjectIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RemovedFromProjectIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Converted Note to Issue Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent? ConvertedNoteToIssueIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent? ConvertedNoteToIssueIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConvertedNoteToIssueIssueEvent))]
#endif
        public bool IsConvertedNoteToIssueIssueEvent => ConvertedNoteToIssueIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConvertedNoteToIssueIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent? value)
        {
            value = ConvertedNoteToIssueIssueEvent;
            return IsConvertedNoteToIssueIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent PickConvertedNoteToIssueIssueEvent() => IsConvertedNoteToIssueIssueEvent
            ? ConvertedNoteToIssueIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConvertedNoteToIssueIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Timeline Comment Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.TimelineCommentEvent? TimelineCommentEvent { get; init; }
#else
        public global::tryAGI.GitHub.TimelineCommentEvent? TimelineCommentEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimelineCommentEvent))]
#endif
        public bool IsTimelineCommentEvent => TimelineCommentEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTimelineCommentEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.TimelineCommentEvent? value)
        {
            value = TimelineCommentEvent;
            return IsTimelineCommentEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.TimelineCommentEvent PickTimelineCommentEvent() => IsTimelineCommentEvent
            ? TimelineCommentEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TimelineCommentEvent' but the value was {ToString()}.");

        /// <summary>
        /// Timeline Cross Referenced Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.TimelineCrossReferencedEvent? TimelineCrossReferencedEvent { get; init; }
#else
        public global::tryAGI.GitHub.TimelineCrossReferencedEvent? TimelineCrossReferencedEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimelineCrossReferencedEvent))]
#endif
        public bool IsTimelineCrossReferencedEvent => TimelineCrossReferencedEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTimelineCrossReferencedEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.TimelineCrossReferencedEvent? value)
        {
            value = TimelineCrossReferencedEvent;
            return IsTimelineCrossReferencedEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.TimelineCrossReferencedEvent PickTimelineCrossReferencedEvent() => IsTimelineCrossReferencedEvent
            ? TimelineCrossReferencedEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TimelineCrossReferencedEvent' but the value was {ToString()}.");

        /// <summary>
        /// Timeline Committed Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.TimelineCommittedEvent? TimelineCommittedEvent { get; init; }
#else
        public global::tryAGI.GitHub.TimelineCommittedEvent? TimelineCommittedEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimelineCommittedEvent))]
#endif
        public bool IsTimelineCommittedEvent => TimelineCommittedEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTimelineCommittedEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.TimelineCommittedEvent? value)
        {
            value = TimelineCommittedEvent;
            return IsTimelineCommittedEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.TimelineCommittedEvent PickTimelineCommittedEvent() => IsTimelineCommittedEvent
            ? TimelineCommittedEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TimelineCommittedEvent' but the value was {ToString()}.");

        /// <summary>
        /// Timeline Reviewed Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.TimelineReviewedEvent? TimelineReviewedEvent { get; init; }
#else
        public global::tryAGI.GitHub.TimelineReviewedEvent? TimelineReviewedEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimelineReviewedEvent))]
#endif
        public bool IsTimelineReviewedEvent => TimelineReviewedEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTimelineReviewedEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.TimelineReviewedEvent? value)
        {
            value = TimelineReviewedEvent;
            return IsTimelineReviewedEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.TimelineReviewedEvent PickTimelineReviewedEvent() => IsTimelineReviewedEvent
            ? TimelineReviewedEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TimelineReviewedEvent' but the value was {ToString()}.");

        /// <summary>
        /// Timeline Line Commented Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.TimelineLineCommentedEvent? TimelineLineCommentedEvent { get; init; }
#else
        public global::tryAGI.GitHub.TimelineLineCommentedEvent? TimelineLineCommentedEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimelineLineCommentedEvent))]
#endif
        public bool IsTimelineLineCommentedEvent => TimelineLineCommentedEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTimelineLineCommentedEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.TimelineLineCommentedEvent? value)
        {
            value = TimelineLineCommentedEvent;
            return IsTimelineLineCommentedEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.TimelineLineCommentedEvent PickTimelineLineCommentedEvent() => IsTimelineLineCommentedEvent
            ? TimelineLineCommentedEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TimelineLineCommentedEvent' but the value was {ToString()}.");

        /// <summary>
        /// Timeline Commit Commented Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.TimelineCommitCommentedEvent? TimelineCommitCommentedEvent { get; init; }
#else
        public global::tryAGI.GitHub.TimelineCommitCommentedEvent? TimelineCommitCommentedEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimelineCommitCommentedEvent))]
#endif
        public bool IsTimelineCommitCommentedEvent => TimelineCommitCommentedEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTimelineCommitCommentedEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.TimelineCommitCommentedEvent? value)
        {
            value = TimelineCommitCommentedEvent;
            return IsTimelineCommitCommentedEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.TimelineCommitCommentedEvent PickTimelineCommitCommentedEvent() => IsTimelineCommitCommentedEvent
            ? TimelineCommitCommentedEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TimelineCommitCommentedEvent' but the value was {ToString()}.");

        /// <summary>
        /// Timeline Assigned Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.TimelineAssignedIssueEvent? TimelineAssignedIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.TimelineAssignedIssueEvent? TimelineAssignedIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimelineAssignedIssueEvent))]
#endif
        public bool IsTimelineAssignedIssueEvent => TimelineAssignedIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTimelineAssignedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.TimelineAssignedIssueEvent? value)
        {
            value = TimelineAssignedIssueEvent;
            return IsTimelineAssignedIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.TimelineAssignedIssueEvent PickTimelineAssignedIssueEvent() => IsTimelineAssignedIssueEvent
            ? TimelineAssignedIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TimelineAssignedIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Timeline Unassigned Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.TimelineUnassignedIssueEvent? TimelineUnassignedIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.TimelineUnassignedIssueEvent? TimelineUnassignedIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimelineUnassignedIssueEvent))]
#endif
        public bool IsTimelineUnassignedIssueEvent => TimelineUnassignedIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTimelineUnassignedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.TimelineUnassignedIssueEvent? value)
        {
            value = TimelineUnassignedIssueEvent;
            return IsTimelineUnassignedIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.TimelineUnassignedIssueEvent PickTimelineUnassignedIssueEvent() => IsTimelineUnassignedIssueEvent
            ? TimelineUnassignedIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TimelineUnassignedIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// State Change Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.StateChangeIssueEvent? StateChangeIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.StateChangeIssueEvent? StateChangeIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StateChangeIssueEvent))]
#endif
        public bool IsStateChangeIssueEvent => StateChangeIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStateChangeIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.StateChangeIssueEvent? value)
        {
            value = StateChangeIssueEvent;
            return IsStateChangeIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.StateChangeIssueEvent PickStateChangeIssueEvent() => IsStateChangeIssueEvent
            ? StateChangeIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StateChangeIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Issue Type Added Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.IssueTypeAddedIssueEvent? IssueTypeAddedIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.IssueTypeAddedIssueEvent? IssueTypeAddedIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IssueTypeAddedIssueEvent))]
#endif
        public bool IsIssueTypeAddedIssueEvent => IssueTypeAddedIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickIssueTypeAddedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.IssueTypeAddedIssueEvent? value)
        {
            value = IssueTypeAddedIssueEvent;
            return IsIssueTypeAddedIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.IssueTypeAddedIssueEvent PickIssueTypeAddedIssueEvent() => IsIssueTypeAddedIssueEvent
            ? IssueTypeAddedIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'IssueTypeAddedIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Issue Type Removed Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.IssueTypeRemovedIssueEvent? IssueTypeRemovedIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.IssueTypeRemovedIssueEvent? IssueTypeRemovedIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IssueTypeRemovedIssueEvent))]
#endif
        public bool IsIssueTypeRemovedIssueEvent => IssueTypeRemovedIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickIssueTypeRemovedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.IssueTypeRemovedIssueEvent? value)
        {
            value = IssueTypeRemovedIssueEvent;
            return IsIssueTypeRemovedIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.IssueTypeRemovedIssueEvent PickIssueTypeRemovedIssueEvent() => IsIssueTypeRemovedIssueEvent
            ? IssueTypeRemovedIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'IssueTypeRemovedIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Issue Type Changed Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.IssueTypeChangedIssueEvent? IssueTypeChangedIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.IssueTypeChangedIssueEvent? IssueTypeChangedIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IssueTypeChangedIssueEvent))]
#endif
        public bool IsIssueTypeChangedIssueEvent => IssueTypeChangedIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickIssueTypeChangedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.IssueTypeChangedIssueEvent? value)
        {
            value = IssueTypeChangedIssueEvent;
            return IsIssueTypeChangedIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.IssueTypeChangedIssueEvent PickIssueTypeChangedIssueEvent() => IsIssueTypeChangedIssueEvent
            ? IssueTypeChangedIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'IssueTypeChangedIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Sub-issue Added Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.SubIssueAddedIssueEvent? SubIssueAddedIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.SubIssueAddedIssueEvent? SubIssueAddedIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubIssueAddedIssueEvent))]
#endif
        public bool IsSubIssueAddedIssueEvent => SubIssueAddedIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubIssueAddedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.SubIssueAddedIssueEvent? value)
        {
            value = SubIssueAddedIssueEvent;
            return IsSubIssueAddedIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.SubIssueAddedIssueEvent PickSubIssueAddedIssueEvent() => IsSubIssueAddedIssueEvent
            ? SubIssueAddedIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubIssueAddedIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Sub-issue Removed Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.SubIssueRemovedIssueEvent? SubIssueRemovedIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.SubIssueRemovedIssueEvent? SubIssueRemovedIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubIssueRemovedIssueEvent))]
#endif
        public bool IsSubIssueRemovedIssueEvent => SubIssueRemovedIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubIssueRemovedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.SubIssueRemovedIssueEvent? value)
        {
            value = SubIssueRemovedIssueEvent;
            return IsSubIssueRemovedIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.SubIssueRemovedIssueEvent PickSubIssueRemovedIssueEvent() => IsSubIssueRemovedIssueEvent
            ? SubIssueRemovedIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubIssueRemovedIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Parent-issue Added Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.ParentIssueAddedIssueEvent? ParentIssueAddedIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.ParentIssueAddedIssueEvent? ParentIssueAddedIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ParentIssueAddedIssueEvent))]
#endif
        public bool IsParentIssueAddedIssueEvent => ParentIssueAddedIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickParentIssueAddedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.ParentIssueAddedIssueEvent? value)
        {
            value = ParentIssueAddedIssueEvent;
            return IsParentIssueAddedIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.ParentIssueAddedIssueEvent PickParentIssueAddedIssueEvent() => IsParentIssueAddedIssueEvent
            ? ParentIssueAddedIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ParentIssueAddedIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Parent-issue Removed Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.ParentIssueRemovedIssueEvent? ParentIssueRemovedIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.ParentIssueRemovedIssueEvent? ParentIssueRemovedIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ParentIssueRemovedIssueEvent))]
#endif
        public bool IsParentIssueRemovedIssueEvent => ParentIssueRemovedIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickParentIssueRemovedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.ParentIssueRemovedIssueEvent? value)
        {
            value = ParentIssueRemovedIssueEvent;
            return IsParentIssueRemovedIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.ParentIssueRemovedIssueEvent PickParentIssueRemovedIssueEvent() => IsParentIssueRemovedIssueEvent
            ? ParentIssueRemovedIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ParentIssueRemovedIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Blocked-by Added Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.BlockedByAddedIssueEvent? BlockedByAddedIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.BlockedByAddedIssueEvent? BlockedByAddedIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BlockedByAddedIssueEvent))]
#endif
        public bool IsBlockedByAddedIssueEvent => BlockedByAddedIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBlockedByAddedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.BlockedByAddedIssueEvent? value)
        {
            value = BlockedByAddedIssueEvent;
            return IsBlockedByAddedIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.BlockedByAddedIssueEvent PickBlockedByAddedIssueEvent() => IsBlockedByAddedIssueEvent
            ? BlockedByAddedIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BlockedByAddedIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Blocked-by Removed Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.BlockedByRemovedIssueEvent? BlockedByRemovedIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.BlockedByRemovedIssueEvent? BlockedByRemovedIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BlockedByRemovedIssueEvent))]
#endif
        public bool IsBlockedByRemovedIssueEvent => BlockedByRemovedIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBlockedByRemovedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.BlockedByRemovedIssueEvent? value)
        {
            value = BlockedByRemovedIssueEvent;
            return IsBlockedByRemovedIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.BlockedByRemovedIssueEvent PickBlockedByRemovedIssueEvent() => IsBlockedByRemovedIssueEvent
            ? BlockedByRemovedIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BlockedByRemovedIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Blocking Added Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.BlockingAddedIssueEvent? BlockingAddedIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.BlockingAddedIssueEvent? BlockingAddedIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BlockingAddedIssueEvent))]
#endif
        public bool IsBlockingAddedIssueEvent => BlockingAddedIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBlockingAddedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.BlockingAddedIssueEvent? value)
        {
            value = BlockingAddedIssueEvent;
            return IsBlockingAddedIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.BlockingAddedIssueEvent PickBlockingAddedIssueEvent() => IsBlockingAddedIssueEvent
            ? BlockingAddedIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BlockingAddedIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Blocking Removed Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.BlockingRemovedIssueEvent? BlockingRemovedIssueEvent { get; init; }
#else
        public global::tryAGI.GitHub.BlockingRemovedIssueEvent? BlockingRemovedIssueEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BlockingRemovedIssueEvent))]
#endif
        public bool IsBlockingRemovedIssueEvent => BlockingRemovedIssueEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBlockingRemovedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.BlockingRemovedIssueEvent? value)
        {
            value = BlockingRemovedIssueEvent;
            return IsBlockingRemovedIssueEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.BlockingRemovedIssueEvent PickBlockingRemovedIssueEvent() => IsBlockingRemovedIssueEvent
            ? BlockingRemovedIssueEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BlockingRemovedIssueEvent' but the value was {ToString()}.");

        /// <summary>
        /// Timeline Connected Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.TimelineConnectedEvent? TimelineConnectedEvent { get; init; }
#else
        public global::tryAGI.GitHub.TimelineConnectedEvent? TimelineConnectedEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimelineConnectedEvent))]
#endif
        public bool IsTimelineConnectedEvent => TimelineConnectedEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTimelineConnectedEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.TimelineConnectedEvent? value)
        {
            value = TimelineConnectedEvent;
            return IsTimelineConnectedEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.TimelineConnectedEvent PickTimelineConnectedEvent() => IsTimelineConnectedEvent
            ? TimelineConnectedEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TimelineConnectedEvent' but the value was {ToString()}.");

        /// <summary>
        /// Timeline Disconnected Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.TimelineDisconnectedEvent? TimelineDisconnectedEvent { get; init; }
#else
        public global::tryAGI.GitHub.TimelineDisconnectedEvent? TimelineDisconnectedEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimelineDisconnectedEvent))]
#endif
        public bool IsTimelineDisconnectedEvent => TimelineDisconnectedEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTimelineDisconnectedEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.TimelineDisconnectedEvent? value)
        {
            value = TimelineDisconnectedEvent;
            return IsTimelineDisconnectedEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.TimelineDisconnectedEvent PickTimelineDisconnectedEvent() => IsTimelineDisconnectedEvent
            ? TimelineDisconnectedEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TimelineDisconnectedEvent' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.LabeledIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.LabeledIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.LabeledIssueEvent?(TimelineIssueEvents @this) => @this.LabeledIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.LabeledIssueEvent? value)
        {
            LabeledIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromLabeledIssueEvent(global::tryAGI.GitHub.LabeledIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.UnlabeledIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.UnlabeledIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.UnlabeledIssueEvent?(TimelineIssueEvents @this) => @this.UnlabeledIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.UnlabeledIssueEvent? value)
        {
            UnlabeledIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromUnlabeledIssueEvent(global::tryAGI.GitHub.UnlabeledIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.MilestonedIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.MilestonedIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.MilestonedIssueEvent?(TimelineIssueEvents @this) => @this.MilestonedIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.MilestonedIssueEvent? value)
        {
            MilestonedIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromMilestonedIssueEvent(global::tryAGI.GitHub.MilestonedIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.DemilestonedIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.DemilestonedIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.DemilestonedIssueEvent?(TimelineIssueEvents @this) => @this.DemilestonedIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.DemilestonedIssueEvent? value)
        {
            DemilestonedIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromDemilestonedIssueEvent(global::tryAGI.GitHub.DemilestonedIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.RenamedIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.RenamedIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RenamedIssueEvent?(TimelineIssueEvents @this) => @this.RenamedIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.RenamedIssueEvent? value)
        {
            RenamedIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromRenamedIssueEvent(global::tryAGI.GitHub.RenamedIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.ReviewRequestedIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.ReviewRequestedIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.ReviewRequestedIssueEvent?(TimelineIssueEvents @this) => @this.ReviewRequestedIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.ReviewRequestedIssueEvent? value)
        {
            ReviewRequestedIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromReviewRequestedIssueEvent(global::tryAGI.GitHub.ReviewRequestedIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent?(TimelineIssueEvents @this) => @this.ReviewRequestRemovedIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent? value)
        {
            ReviewRequestRemovedIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromReviewRequestRemovedIssueEvent(global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.ReviewDismissedIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.ReviewDismissedIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.ReviewDismissedIssueEvent?(TimelineIssueEvents @this) => @this.ReviewDismissedIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.ReviewDismissedIssueEvent? value)
        {
            ReviewDismissedIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromReviewDismissedIssueEvent(global::tryAGI.GitHub.ReviewDismissedIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.LockedIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.LockedIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.LockedIssueEvent?(TimelineIssueEvents @this) => @this.LockedIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.LockedIssueEvent? value)
        {
            LockedIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromLockedIssueEvent(global::tryAGI.GitHub.LockedIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.AddedToProjectIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.AddedToProjectIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AddedToProjectIssueEvent?(TimelineIssueEvents @this) => @this.AddedToProjectIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.AddedToProjectIssueEvent? value)
        {
            AddedToProjectIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromAddedToProjectIssueEvent(global::tryAGI.GitHub.AddedToProjectIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.MovedColumnInProjectIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.MovedColumnInProjectIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.MovedColumnInProjectIssueEvent?(TimelineIssueEvents @this) => @this.MovedColumnInProjectIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.MovedColumnInProjectIssueEvent? value)
        {
            MovedColumnInProjectIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromMovedColumnInProjectIssueEvent(global::tryAGI.GitHub.MovedColumnInProjectIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.RemovedFromProjectIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.RemovedFromProjectIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RemovedFromProjectIssueEvent?(TimelineIssueEvents @this) => @this.RemovedFromProjectIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.RemovedFromProjectIssueEvent? value)
        {
            RemovedFromProjectIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromRemovedFromProjectIssueEvent(global::tryAGI.GitHub.RemovedFromProjectIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent?(TimelineIssueEvents @this) => @this.ConvertedNoteToIssueIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent? value)
        {
            ConvertedNoteToIssueIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromConvertedNoteToIssueIssueEvent(global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.TimelineCommentEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.TimelineCommentEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.TimelineCommentEvent?(TimelineIssueEvents @this) => @this.TimelineCommentEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.TimelineCommentEvent? value)
        {
            TimelineCommentEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromTimelineCommentEvent(global::tryAGI.GitHub.TimelineCommentEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.TimelineCrossReferencedEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.TimelineCrossReferencedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.TimelineCrossReferencedEvent?(TimelineIssueEvents @this) => @this.TimelineCrossReferencedEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.TimelineCrossReferencedEvent? value)
        {
            TimelineCrossReferencedEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromTimelineCrossReferencedEvent(global::tryAGI.GitHub.TimelineCrossReferencedEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.TimelineCommittedEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.TimelineCommittedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.TimelineCommittedEvent?(TimelineIssueEvents @this) => @this.TimelineCommittedEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.TimelineCommittedEvent? value)
        {
            TimelineCommittedEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromTimelineCommittedEvent(global::tryAGI.GitHub.TimelineCommittedEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.TimelineReviewedEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.TimelineReviewedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.TimelineReviewedEvent?(TimelineIssueEvents @this) => @this.TimelineReviewedEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.TimelineReviewedEvent? value)
        {
            TimelineReviewedEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromTimelineReviewedEvent(global::tryAGI.GitHub.TimelineReviewedEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.TimelineLineCommentedEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.TimelineLineCommentedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.TimelineLineCommentedEvent?(TimelineIssueEvents @this) => @this.TimelineLineCommentedEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.TimelineLineCommentedEvent? value)
        {
            TimelineLineCommentedEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromTimelineLineCommentedEvent(global::tryAGI.GitHub.TimelineLineCommentedEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.TimelineCommitCommentedEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.TimelineCommitCommentedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.TimelineCommitCommentedEvent?(TimelineIssueEvents @this) => @this.TimelineCommitCommentedEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.TimelineCommitCommentedEvent? value)
        {
            TimelineCommitCommentedEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromTimelineCommitCommentedEvent(global::tryAGI.GitHub.TimelineCommitCommentedEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.TimelineAssignedIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.TimelineAssignedIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.TimelineAssignedIssueEvent?(TimelineIssueEvents @this) => @this.TimelineAssignedIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.TimelineAssignedIssueEvent? value)
        {
            TimelineAssignedIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromTimelineAssignedIssueEvent(global::tryAGI.GitHub.TimelineAssignedIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.TimelineUnassignedIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.TimelineUnassignedIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.TimelineUnassignedIssueEvent?(TimelineIssueEvents @this) => @this.TimelineUnassignedIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.TimelineUnassignedIssueEvent? value)
        {
            TimelineUnassignedIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromTimelineUnassignedIssueEvent(global::tryAGI.GitHub.TimelineUnassignedIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.StateChangeIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.StateChangeIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.StateChangeIssueEvent?(TimelineIssueEvents @this) => @this.StateChangeIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.StateChangeIssueEvent? value)
        {
            StateChangeIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromStateChangeIssueEvent(global::tryAGI.GitHub.StateChangeIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.IssueTypeAddedIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.IssueTypeAddedIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.IssueTypeAddedIssueEvent?(TimelineIssueEvents @this) => @this.IssueTypeAddedIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.IssueTypeAddedIssueEvent? value)
        {
            IssueTypeAddedIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromIssueTypeAddedIssueEvent(global::tryAGI.GitHub.IssueTypeAddedIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.IssueTypeRemovedIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.IssueTypeRemovedIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.IssueTypeRemovedIssueEvent?(TimelineIssueEvents @this) => @this.IssueTypeRemovedIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.IssueTypeRemovedIssueEvent? value)
        {
            IssueTypeRemovedIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromIssueTypeRemovedIssueEvent(global::tryAGI.GitHub.IssueTypeRemovedIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.IssueTypeChangedIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.IssueTypeChangedIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.IssueTypeChangedIssueEvent?(TimelineIssueEvents @this) => @this.IssueTypeChangedIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.IssueTypeChangedIssueEvent? value)
        {
            IssueTypeChangedIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromIssueTypeChangedIssueEvent(global::tryAGI.GitHub.IssueTypeChangedIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.SubIssueAddedIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.SubIssueAddedIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.SubIssueAddedIssueEvent?(TimelineIssueEvents @this) => @this.SubIssueAddedIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.SubIssueAddedIssueEvent? value)
        {
            SubIssueAddedIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromSubIssueAddedIssueEvent(global::tryAGI.GitHub.SubIssueAddedIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.SubIssueRemovedIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.SubIssueRemovedIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.SubIssueRemovedIssueEvent?(TimelineIssueEvents @this) => @this.SubIssueRemovedIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.SubIssueRemovedIssueEvent? value)
        {
            SubIssueRemovedIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromSubIssueRemovedIssueEvent(global::tryAGI.GitHub.SubIssueRemovedIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.ParentIssueAddedIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.ParentIssueAddedIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.ParentIssueAddedIssueEvent?(TimelineIssueEvents @this) => @this.ParentIssueAddedIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.ParentIssueAddedIssueEvent? value)
        {
            ParentIssueAddedIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromParentIssueAddedIssueEvent(global::tryAGI.GitHub.ParentIssueAddedIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.ParentIssueRemovedIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.ParentIssueRemovedIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.ParentIssueRemovedIssueEvent?(TimelineIssueEvents @this) => @this.ParentIssueRemovedIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.ParentIssueRemovedIssueEvent? value)
        {
            ParentIssueRemovedIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromParentIssueRemovedIssueEvent(global::tryAGI.GitHub.ParentIssueRemovedIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.BlockedByAddedIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.BlockedByAddedIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.BlockedByAddedIssueEvent?(TimelineIssueEvents @this) => @this.BlockedByAddedIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.BlockedByAddedIssueEvent? value)
        {
            BlockedByAddedIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromBlockedByAddedIssueEvent(global::tryAGI.GitHub.BlockedByAddedIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.BlockedByRemovedIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.BlockedByRemovedIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.BlockedByRemovedIssueEvent?(TimelineIssueEvents @this) => @this.BlockedByRemovedIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.BlockedByRemovedIssueEvent? value)
        {
            BlockedByRemovedIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromBlockedByRemovedIssueEvent(global::tryAGI.GitHub.BlockedByRemovedIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.BlockingAddedIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.BlockingAddedIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.BlockingAddedIssueEvent?(TimelineIssueEvents @this) => @this.BlockingAddedIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.BlockingAddedIssueEvent? value)
        {
            BlockingAddedIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromBlockingAddedIssueEvent(global::tryAGI.GitHub.BlockingAddedIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.BlockingRemovedIssueEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.BlockingRemovedIssueEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.BlockingRemovedIssueEvent?(TimelineIssueEvents @this) => @this.BlockingRemovedIssueEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.BlockingRemovedIssueEvent? value)
        {
            BlockingRemovedIssueEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromBlockingRemovedIssueEvent(global::tryAGI.GitHub.BlockingRemovedIssueEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.TimelineConnectedEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.TimelineConnectedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.TimelineConnectedEvent?(TimelineIssueEvents @this) => @this.TimelineConnectedEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.TimelineConnectedEvent? value)
        {
            TimelineConnectedEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromTimelineConnectedEvent(global::tryAGI.GitHub.TimelineConnectedEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::tryAGI.GitHub.TimelineDisconnectedEvent value) => new TimelineIssueEvents((global::tryAGI.GitHub.TimelineDisconnectedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.TimelineDisconnectedEvent?(TimelineIssueEvents @this) => @this.TimelineDisconnectedEvent;

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(global::tryAGI.GitHub.TimelineDisconnectedEvent? value)
        {
            TimelineDisconnectedEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TimelineIssueEvents FromTimelineDisconnectedEvent(global::tryAGI.GitHub.TimelineDisconnectedEvent? value) => new TimelineIssueEvents(value);

        /// <summary>
        ///
        /// </summary>
        public TimelineIssueEvents(
            global::tryAGI.GitHub.LabeledIssueEvent? labeledIssueEvent,
            global::tryAGI.GitHub.UnlabeledIssueEvent? unlabeledIssueEvent,
            global::tryAGI.GitHub.MilestonedIssueEvent? milestonedIssueEvent,
            global::tryAGI.GitHub.DemilestonedIssueEvent? demilestonedIssueEvent,
            global::tryAGI.GitHub.RenamedIssueEvent? renamedIssueEvent,
            global::tryAGI.GitHub.ReviewRequestedIssueEvent? reviewRequestedIssueEvent,
            global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent? reviewRequestRemovedIssueEvent,
            global::tryAGI.GitHub.ReviewDismissedIssueEvent? reviewDismissedIssueEvent,
            global::tryAGI.GitHub.LockedIssueEvent? lockedIssueEvent,
            global::tryAGI.GitHub.AddedToProjectIssueEvent? addedToProjectIssueEvent,
            global::tryAGI.GitHub.MovedColumnInProjectIssueEvent? movedColumnInProjectIssueEvent,
            global::tryAGI.GitHub.RemovedFromProjectIssueEvent? removedFromProjectIssueEvent,
            global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent? convertedNoteToIssueIssueEvent,
            global::tryAGI.GitHub.TimelineCommentEvent? timelineCommentEvent,
            global::tryAGI.GitHub.TimelineCrossReferencedEvent? timelineCrossReferencedEvent,
            global::tryAGI.GitHub.TimelineCommittedEvent? timelineCommittedEvent,
            global::tryAGI.GitHub.TimelineReviewedEvent? timelineReviewedEvent,
            global::tryAGI.GitHub.TimelineLineCommentedEvent? timelineLineCommentedEvent,
            global::tryAGI.GitHub.TimelineCommitCommentedEvent? timelineCommitCommentedEvent,
            global::tryAGI.GitHub.TimelineAssignedIssueEvent? timelineAssignedIssueEvent,
            global::tryAGI.GitHub.TimelineUnassignedIssueEvent? timelineUnassignedIssueEvent,
            global::tryAGI.GitHub.StateChangeIssueEvent? stateChangeIssueEvent,
            global::tryAGI.GitHub.IssueTypeAddedIssueEvent? issueTypeAddedIssueEvent,
            global::tryAGI.GitHub.IssueTypeRemovedIssueEvent? issueTypeRemovedIssueEvent,
            global::tryAGI.GitHub.IssueTypeChangedIssueEvent? issueTypeChangedIssueEvent,
            global::tryAGI.GitHub.SubIssueAddedIssueEvent? subIssueAddedIssueEvent,
            global::tryAGI.GitHub.SubIssueRemovedIssueEvent? subIssueRemovedIssueEvent,
            global::tryAGI.GitHub.ParentIssueAddedIssueEvent? parentIssueAddedIssueEvent,
            global::tryAGI.GitHub.ParentIssueRemovedIssueEvent? parentIssueRemovedIssueEvent,
            global::tryAGI.GitHub.BlockedByAddedIssueEvent? blockedByAddedIssueEvent,
            global::tryAGI.GitHub.BlockedByRemovedIssueEvent? blockedByRemovedIssueEvent,
            global::tryAGI.GitHub.BlockingAddedIssueEvent? blockingAddedIssueEvent,
            global::tryAGI.GitHub.BlockingRemovedIssueEvent? blockingRemovedIssueEvent,
            global::tryAGI.GitHub.TimelineConnectedEvent? timelineConnectedEvent,
            global::tryAGI.GitHub.TimelineDisconnectedEvent? timelineDisconnectedEvent
            )
        {
            LabeledIssueEvent = labeledIssueEvent;
            UnlabeledIssueEvent = unlabeledIssueEvent;
            MilestonedIssueEvent = milestonedIssueEvent;
            DemilestonedIssueEvent = demilestonedIssueEvent;
            RenamedIssueEvent = renamedIssueEvent;
            ReviewRequestedIssueEvent = reviewRequestedIssueEvent;
            ReviewRequestRemovedIssueEvent = reviewRequestRemovedIssueEvent;
            ReviewDismissedIssueEvent = reviewDismissedIssueEvent;
            LockedIssueEvent = lockedIssueEvent;
            AddedToProjectIssueEvent = addedToProjectIssueEvent;
            MovedColumnInProjectIssueEvent = movedColumnInProjectIssueEvent;
            RemovedFromProjectIssueEvent = removedFromProjectIssueEvent;
            ConvertedNoteToIssueIssueEvent = convertedNoteToIssueIssueEvent;
            TimelineCommentEvent = timelineCommentEvent;
            TimelineCrossReferencedEvent = timelineCrossReferencedEvent;
            TimelineCommittedEvent = timelineCommittedEvent;
            TimelineReviewedEvent = timelineReviewedEvent;
            TimelineLineCommentedEvent = timelineLineCommentedEvent;
            TimelineCommitCommentedEvent = timelineCommitCommentedEvent;
            TimelineAssignedIssueEvent = timelineAssignedIssueEvent;
            TimelineUnassignedIssueEvent = timelineUnassignedIssueEvent;
            StateChangeIssueEvent = stateChangeIssueEvent;
            IssueTypeAddedIssueEvent = issueTypeAddedIssueEvent;
            IssueTypeRemovedIssueEvent = issueTypeRemovedIssueEvent;
            IssueTypeChangedIssueEvent = issueTypeChangedIssueEvent;
            SubIssueAddedIssueEvent = subIssueAddedIssueEvent;
            SubIssueRemovedIssueEvent = subIssueRemovedIssueEvent;
            ParentIssueAddedIssueEvent = parentIssueAddedIssueEvent;
            ParentIssueRemovedIssueEvent = parentIssueRemovedIssueEvent;
            BlockedByAddedIssueEvent = blockedByAddedIssueEvent;
            BlockedByRemovedIssueEvent = blockedByRemovedIssueEvent;
            BlockingAddedIssueEvent = blockingAddedIssueEvent;
            BlockingRemovedIssueEvent = blockingRemovedIssueEvent;
            TimelineConnectedEvent = timelineConnectedEvent;
            TimelineDisconnectedEvent = timelineDisconnectedEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TimelineDisconnectedEvent as object ??
            TimelineConnectedEvent as object ??
            BlockingRemovedIssueEvent as object ??
            BlockingAddedIssueEvent as object ??
            BlockedByRemovedIssueEvent as object ??
            BlockedByAddedIssueEvent as object ??
            ParentIssueRemovedIssueEvent as object ??
            ParentIssueAddedIssueEvent as object ??
            SubIssueRemovedIssueEvent as object ??
            SubIssueAddedIssueEvent as object ??
            IssueTypeChangedIssueEvent as object ??
            IssueTypeRemovedIssueEvent as object ??
            IssueTypeAddedIssueEvent as object ??
            StateChangeIssueEvent as object ??
            TimelineUnassignedIssueEvent as object ??
            TimelineAssignedIssueEvent as object ??
            TimelineCommitCommentedEvent as object ??
            TimelineLineCommentedEvent as object ??
            TimelineReviewedEvent as object ??
            TimelineCommittedEvent as object ??
            TimelineCrossReferencedEvent as object ??
            TimelineCommentEvent as object ??
            ConvertedNoteToIssueIssueEvent as object ??
            RemovedFromProjectIssueEvent as object ??
            MovedColumnInProjectIssueEvent as object ??
            AddedToProjectIssueEvent as object ??
            LockedIssueEvent as object ??
            ReviewDismissedIssueEvent as object ??
            ReviewRequestRemovedIssueEvent as object ??
            ReviewRequestedIssueEvent as object ??
            RenamedIssueEvent as object ??
            DemilestonedIssueEvent as object ??
            MilestonedIssueEvent as object ??
            UnlabeledIssueEvent as object ??
            LabeledIssueEvent as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            LabeledIssueEvent?.ToString() ??
            UnlabeledIssueEvent?.ToString() ??
            MilestonedIssueEvent?.ToString() ??
            DemilestonedIssueEvent?.ToString() ??
            RenamedIssueEvent?.ToString() ??
            ReviewRequestedIssueEvent?.ToString() ??
            ReviewRequestRemovedIssueEvent?.ToString() ??
            ReviewDismissedIssueEvent?.ToString() ??
            LockedIssueEvent?.ToString() ??
            AddedToProjectIssueEvent?.ToString() ??
            MovedColumnInProjectIssueEvent?.ToString() ??
            RemovedFromProjectIssueEvent?.ToString() ??
            ConvertedNoteToIssueIssueEvent?.ToString() ??
            TimelineCommentEvent?.ToString() ??
            TimelineCrossReferencedEvent?.ToString() ??
            TimelineCommittedEvent?.ToString() ??
            TimelineReviewedEvent?.ToString() ??
            TimelineLineCommentedEvent?.ToString() ??
            TimelineCommitCommentedEvent?.ToString() ??
            TimelineAssignedIssueEvent?.ToString() ??
            TimelineUnassignedIssueEvent?.ToString() ??
            StateChangeIssueEvent?.ToString() ??
            IssueTypeAddedIssueEvent?.ToString() ??
            IssueTypeRemovedIssueEvent?.ToString() ??
            IssueTypeChangedIssueEvent?.ToString() ??
            SubIssueAddedIssueEvent?.ToString() ??
            SubIssueRemovedIssueEvent?.ToString() ??
            ParentIssueAddedIssueEvent?.ToString() ??
            ParentIssueRemovedIssueEvent?.ToString() ??
            BlockedByAddedIssueEvent?.ToString() ??
            BlockedByRemovedIssueEvent?.ToString() ??
            BlockingAddedIssueEvent?.ToString() ??
            BlockingRemovedIssueEvent?.ToString() ??
            TimelineConnectedEvent?.ToString() ??
            TimelineDisconnectedEvent?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsLabeledIssueEvent || IsUnlabeledIssueEvent || IsMilestonedIssueEvent || IsDemilestonedIssueEvent || IsRenamedIssueEvent || IsReviewRequestedIssueEvent || IsReviewRequestRemovedIssueEvent || IsReviewDismissedIssueEvent || IsLockedIssueEvent || IsAddedToProjectIssueEvent || IsMovedColumnInProjectIssueEvent || IsRemovedFromProjectIssueEvent || IsConvertedNoteToIssueIssueEvent || IsTimelineCommentEvent || IsTimelineCrossReferencedEvent || IsTimelineCommittedEvent || IsTimelineReviewedEvent || IsTimelineLineCommentedEvent || IsTimelineCommitCommentedEvent || IsTimelineAssignedIssueEvent || IsTimelineUnassignedIssueEvent || IsStateChangeIssueEvent || IsIssueTypeAddedIssueEvent || IsIssueTypeRemovedIssueEvent || IsIssueTypeChangedIssueEvent || IsSubIssueAddedIssueEvent || IsSubIssueRemovedIssueEvent || IsParentIssueAddedIssueEvent || IsParentIssueRemovedIssueEvent || IsBlockedByAddedIssueEvent || IsBlockedByRemovedIssueEvent || IsBlockingAddedIssueEvent || IsBlockingRemovedIssueEvent || IsTimelineConnectedEvent || IsTimelineDisconnectedEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.GitHub.LabeledIssueEvent, TResult>? labeledIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.UnlabeledIssueEvent, TResult>? unlabeledIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.MilestonedIssueEvent, TResult>? milestonedIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.DemilestonedIssueEvent, TResult>? demilestonedIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.RenamedIssueEvent, TResult>? renamedIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.ReviewRequestedIssueEvent, TResult>? reviewRequestedIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent, TResult>? reviewRequestRemovedIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.ReviewDismissedIssueEvent, TResult>? reviewDismissedIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.LockedIssueEvent, TResult>? lockedIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.AddedToProjectIssueEvent, TResult>? addedToProjectIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.MovedColumnInProjectIssueEvent, TResult>? movedColumnInProjectIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.RemovedFromProjectIssueEvent, TResult>? removedFromProjectIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent, TResult>? convertedNoteToIssueIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.TimelineCommentEvent, TResult>? timelineCommentEvent = null,
            global::System.Func<global::tryAGI.GitHub.TimelineCrossReferencedEvent, TResult>? timelineCrossReferencedEvent = null,
            global::System.Func<global::tryAGI.GitHub.TimelineCommittedEvent, TResult>? timelineCommittedEvent = null,
            global::System.Func<global::tryAGI.GitHub.TimelineReviewedEvent, TResult>? timelineReviewedEvent = null,
            global::System.Func<global::tryAGI.GitHub.TimelineLineCommentedEvent, TResult>? timelineLineCommentedEvent = null,
            global::System.Func<global::tryAGI.GitHub.TimelineCommitCommentedEvent, TResult>? timelineCommitCommentedEvent = null,
            global::System.Func<global::tryAGI.GitHub.TimelineAssignedIssueEvent, TResult>? timelineAssignedIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.TimelineUnassignedIssueEvent, TResult>? timelineUnassignedIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.StateChangeIssueEvent, TResult>? stateChangeIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.IssueTypeAddedIssueEvent, TResult>? issueTypeAddedIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.IssueTypeRemovedIssueEvent, TResult>? issueTypeRemovedIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.IssueTypeChangedIssueEvent, TResult>? issueTypeChangedIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.SubIssueAddedIssueEvent, TResult>? subIssueAddedIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.SubIssueRemovedIssueEvent, TResult>? subIssueRemovedIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.ParentIssueAddedIssueEvent, TResult>? parentIssueAddedIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.ParentIssueRemovedIssueEvent, TResult>? parentIssueRemovedIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.BlockedByAddedIssueEvent, TResult>? blockedByAddedIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.BlockedByRemovedIssueEvent, TResult>? blockedByRemovedIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.BlockingAddedIssueEvent, TResult>? blockingAddedIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.BlockingRemovedIssueEvent, TResult>? blockingRemovedIssueEvent = null,
            global::System.Func<global::tryAGI.GitHub.TimelineConnectedEvent, TResult>? timelineConnectedEvent = null,
            global::System.Func<global::tryAGI.GitHub.TimelineDisconnectedEvent, TResult>? timelineDisconnectedEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLabeledIssueEvent && labeledIssueEvent != null)
            {
                return labeledIssueEvent(LabeledIssueEvent!);
            }
            else if (IsUnlabeledIssueEvent && unlabeledIssueEvent != null)
            {
                return unlabeledIssueEvent(UnlabeledIssueEvent!);
            }
            else if (IsMilestonedIssueEvent && milestonedIssueEvent != null)
            {
                return milestonedIssueEvent(MilestonedIssueEvent!);
            }
            else if (IsDemilestonedIssueEvent && demilestonedIssueEvent != null)
            {
                return demilestonedIssueEvent(DemilestonedIssueEvent!);
            }
            else if (IsRenamedIssueEvent && renamedIssueEvent != null)
            {
                return renamedIssueEvent(RenamedIssueEvent!);
            }
            else if (IsReviewRequestedIssueEvent && reviewRequestedIssueEvent != null)
            {
                return reviewRequestedIssueEvent(ReviewRequestedIssueEvent!);
            }
            else if (IsReviewRequestRemovedIssueEvent && reviewRequestRemovedIssueEvent != null)
            {
                return reviewRequestRemovedIssueEvent(ReviewRequestRemovedIssueEvent!);
            }
            else if (IsReviewDismissedIssueEvent && reviewDismissedIssueEvent != null)
            {
                return reviewDismissedIssueEvent(ReviewDismissedIssueEvent!);
            }
            else if (IsLockedIssueEvent && lockedIssueEvent != null)
            {
                return lockedIssueEvent(LockedIssueEvent!);
            }
            else if (IsAddedToProjectIssueEvent && addedToProjectIssueEvent != null)
            {
                return addedToProjectIssueEvent(AddedToProjectIssueEvent!);
            }
            else if (IsMovedColumnInProjectIssueEvent && movedColumnInProjectIssueEvent != null)
            {
                return movedColumnInProjectIssueEvent(MovedColumnInProjectIssueEvent!);
            }
            else if (IsRemovedFromProjectIssueEvent && removedFromProjectIssueEvent != null)
            {
                return removedFromProjectIssueEvent(RemovedFromProjectIssueEvent!);
            }
            else if (IsConvertedNoteToIssueIssueEvent && convertedNoteToIssueIssueEvent != null)
            {
                return convertedNoteToIssueIssueEvent(ConvertedNoteToIssueIssueEvent!);
            }
            else if (IsTimelineCommentEvent && timelineCommentEvent != null)
            {
                return timelineCommentEvent(TimelineCommentEvent!);
            }
            else if (IsTimelineCrossReferencedEvent && timelineCrossReferencedEvent != null)
            {
                return timelineCrossReferencedEvent(TimelineCrossReferencedEvent!);
            }
            else if (IsTimelineCommittedEvent && timelineCommittedEvent != null)
            {
                return timelineCommittedEvent(TimelineCommittedEvent!);
            }
            else if (IsTimelineReviewedEvent && timelineReviewedEvent != null)
            {
                return timelineReviewedEvent(TimelineReviewedEvent!);
            }
            else if (IsTimelineLineCommentedEvent && timelineLineCommentedEvent != null)
            {
                return timelineLineCommentedEvent(TimelineLineCommentedEvent!);
            }
            else if (IsTimelineCommitCommentedEvent && timelineCommitCommentedEvent != null)
            {
                return timelineCommitCommentedEvent(TimelineCommitCommentedEvent!);
            }
            else if (IsTimelineAssignedIssueEvent && timelineAssignedIssueEvent != null)
            {
                return timelineAssignedIssueEvent(TimelineAssignedIssueEvent!);
            }
            else if (IsTimelineUnassignedIssueEvent && timelineUnassignedIssueEvent != null)
            {
                return timelineUnassignedIssueEvent(TimelineUnassignedIssueEvent!);
            }
            else if (IsStateChangeIssueEvent && stateChangeIssueEvent != null)
            {
                return stateChangeIssueEvent(StateChangeIssueEvent!);
            }
            else if (IsIssueTypeAddedIssueEvent && issueTypeAddedIssueEvent != null)
            {
                return issueTypeAddedIssueEvent(IssueTypeAddedIssueEvent!);
            }
            else if (IsIssueTypeRemovedIssueEvent && issueTypeRemovedIssueEvent != null)
            {
                return issueTypeRemovedIssueEvent(IssueTypeRemovedIssueEvent!);
            }
            else if (IsIssueTypeChangedIssueEvent && issueTypeChangedIssueEvent != null)
            {
                return issueTypeChangedIssueEvent(IssueTypeChangedIssueEvent!);
            }
            else if (IsSubIssueAddedIssueEvent && subIssueAddedIssueEvent != null)
            {
                return subIssueAddedIssueEvent(SubIssueAddedIssueEvent!);
            }
            else if (IsSubIssueRemovedIssueEvent && subIssueRemovedIssueEvent != null)
            {
                return subIssueRemovedIssueEvent(SubIssueRemovedIssueEvent!);
            }
            else if (IsParentIssueAddedIssueEvent && parentIssueAddedIssueEvent != null)
            {
                return parentIssueAddedIssueEvent(ParentIssueAddedIssueEvent!);
            }
            else if (IsParentIssueRemovedIssueEvent && parentIssueRemovedIssueEvent != null)
            {
                return parentIssueRemovedIssueEvent(ParentIssueRemovedIssueEvent!);
            }
            else if (IsBlockedByAddedIssueEvent && blockedByAddedIssueEvent != null)
            {
                return blockedByAddedIssueEvent(BlockedByAddedIssueEvent!);
            }
            else if (IsBlockedByRemovedIssueEvent && blockedByRemovedIssueEvent != null)
            {
                return blockedByRemovedIssueEvent(BlockedByRemovedIssueEvent!);
            }
            else if (IsBlockingAddedIssueEvent && blockingAddedIssueEvent != null)
            {
                return blockingAddedIssueEvent(BlockingAddedIssueEvent!);
            }
            else if (IsBlockingRemovedIssueEvent && blockingRemovedIssueEvent != null)
            {
                return blockingRemovedIssueEvent(BlockingRemovedIssueEvent!);
            }
            else if (IsTimelineConnectedEvent && timelineConnectedEvent != null)
            {
                return timelineConnectedEvent(TimelineConnectedEvent!);
            }
            else if (IsTimelineDisconnectedEvent && timelineDisconnectedEvent != null)
            {
                return timelineDisconnectedEvent(TimelineDisconnectedEvent!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.GitHub.LabeledIssueEvent>? labeledIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.UnlabeledIssueEvent>? unlabeledIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.MilestonedIssueEvent>? milestonedIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.DemilestonedIssueEvent>? demilestonedIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.RenamedIssueEvent>? renamedIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.ReviewRequestedIssueEvent>? reviewRequestedIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent>? reviewRequestRemovedIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.ReviewDismissedIssueEvent>? reviewDismissedIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.LockedIssueEvent>? lockedIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.AddedToProjectIssueEvent>? addedToProjectIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.MovedColumnInProjectIssueEvent>? movedColumnInProjectIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.RemovedFromProjectIssueEvent>? removedFromProjectIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent>? convertedNoteToIssueIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.TimelineCommentEvent>? timelineCommentEvent = null,

            global::System.Action<global::tryAGI.GitHub.TimelineCrossReferencedEvent>? timelineCrossReferencedEvent = null,

            global::System.Action<global::tryAGI.GitHub.TimelineCommittedEvent>? timelineCommittedEvent = null,

            global::System.Action<global::tryAGI.GitHub.TimelineReviewedEvent>? timelineReviewedEvent = null,

            global::System.Action<global::tryAGI.GitHub.TimelineLineCommentedEvent>? timelineLineCommentedEvent = null,

            global::System.Action<global::tryAGI.GitHub.TimelineCommitCommentedEvent>? timelineCommitCommentedEvent = null,

            global::System.Action<global::tryAGI.GitHub.TimelineAssignedIssueEvent>? timelineAssignedIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.TimelineUnassignedIssueEvent>? timelineUnassignedIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.StateChangeIssueEvent>? stateChangeIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.IssueTypeAddedIssueEvent>? issueTypeAddedIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.IssueTypeRemovedIssueEvent>? issueTypeRemovedIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.IssueTypeChangedIssueEvent>? issueTypeChangedIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.SubIssueAddedIssueEvent>? subIssueAddedIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.SubIssueRemovedIssueEvent>? subIssueRemovedIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.ParentIssueAddedIssueEvent>? parentIssueAddedIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.ParentIssueRemovedIssueEvent>? parentIssueRemovedIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.BlockedByAddedIssueEvent>? blockedByAddedIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.BlockedByRemovedIssueEvent>? blockedByRemovedIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.BlockingAddedIssueEvent>? blockingAddedIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.BlockingRemovedIssueEvent>? blockingRemovedIssueEvent = null,

            global::System.Action<global::tryAGI.GitHub.TimelineConnectedEvent>? timelineConnectedEvent = null,

            global::System.Action<global::tryAGI.GitHub.TimelineDisconnectedEvent>? timelineDisconnectedEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLabeledIssueEvent)
            {
                labeledIssueEvent?.Invoke(LabeledIssueEvent!);
            }
            else if (IsUnlabeledIssueEvent)
            {
                unlabeledIssueEvent?.Invoke(UnlabeledIssueEvent!);
            }
            else if (IsMilestonedIssueEvent)
            {
                milestonedIssueEvent?.Invoke(MilestonedIssueEvent!);
            }
            else if (IsDemilestonedIssueEvent)
            {
                demilestonedIssueEvent?.Invoke(DemilestonedIssueEvent!);
            }
            else if (IsRenamedIssueEvent)
            {
                renamedIssueEvent?.Invoke(RenamedIssueEvent!);
            }
            else if (IsReviewRequestedIssueEvent)
            {
                reviewRequestedIssueEvent?.Invoke(ReviewRequestedIssueEvent!);
            }
            else if (IsReviewRequestRemovedIssueEvent)
            {
                reviewRequestRemovedIssueEvent?.Invoke(ReviewRequestRemovedIssueEvent!);
            }
            else if (IsReviewDismissedIssueEvent)
            {
                reviewDismissedIssueEvent?.Invoke(ReviewDismissedIssueEvent!);
            }
            else if (IsLockedIssueEvent)
            {
                lockedIssueEvent?.Invoke(LockedIssueEvent!);
            }
            else if (IsAddedToProjectIssueEvent)
            {
                addedToProjectIssueEvent?.Invoke(AddedToProjectIssueEvent!);
            }
            else if (IsMovedColumnInProjectIssueEvent)
            {
                movedColumnInProjectIssueEvent?.Invoke(MovedColumnInProjectIssueEvent!);
            }
            else if (IsRemovedFromProjectIssueEvent)
            {
                removedFromProjectIssueEvent?.Invoke(RemovedFromProjectIssueEvent!);
            }
            else if (IsConvertedNoteToIssueIssueEvent)
            {
                convertedNoteToIssueIssueEvent?.Invoke(ConvertedNoteToIssueIssueEvent!);
            }
            else if (IsTimelineCommentEvent)
            {
                timelineCommentEvent?.Invoke(TimelineCommentEvent!);
            }
            else if (IsTimelineCrossReferencedEvent)
            {
                timelineCrossReferencedEvent?.Invoke(TimelineCrossReferencedEvent!);
            }
            else if (IsTimelineCommittedEvent)
            {
                timelineCommittedEvent?.Invoke(TimelineCommittedEvent!);
            }
            else if (IsTimelineReviewedEvent)
            {
                timelineReviewedEvent?.Invoke(TimelineReviewedEvent!);
            }
            else if (IsTimelineLineCommentedEvent)
            {
                timelineLineCommentedEvent?.Invoke(TimelineLineCommentedEvent!);
            }
            else if (IsTimelineCommitCommentedEvent)
            {
                timelineCommitCommentedEvent?.Invoke(TimelineCommitCommentedEvent!);
            }
            else if (IsTimelineAssignedIssueEvent)
            {
                timelineAssignedIssueEvent?.Invoke(TimelineAssignedIssueEvent!);
            }
            else if (IsTimelineUnassignedIssueEvent)
            {
                timelineUnassignedIssueEvent?.Invoke(TimelineUnassignedIssueEvent!);
            }
            else if (IsStateChangeIssueEvent)
            {
                stateChangeIssueEvent?.Invoke(StateChangeIssueEvent!);
            }
            else if (IsIssueTypeAddedIssueEvent)
            {
                issueTypeAddedIssueEvent?.Invoke(IssueTypeAddedIssueEvent!);
            }
            else if (IsIssueTypeRemovedIssueEvent)
            {
                issueTypeRemovedIssueEvent?.Invoke(IssueTypeRemovedIssueEvent!);
            }
            else if (IsIssueTypeChangedIssueEvent)
            {
                issueTypeChangedIssueEvent?.Invoke(IssueTypeChangedIssueEvent!);
            }
            else if (IsSubIssueAddedIssueEvent)
            {
                subIssueAddedIssueEvent?.Invoke(SubIssueAddedIssueEvent!);
            }
            else if (IsSubIssueRemovedIssueEvent)
            {
                subIssueRemovedIssueEvent?.Invoke(SubIssueRemovedIssueEvent!);
            }
            else if (IsParentIssueAddedIssueEvent)
            {
                parentIssueAddedIssueEvent?.Invoke(ParentIssueAddedIssueEvent!);
            }
            else if (IsParentIssueRemovedIssueEvent)
            {
                parentIssueRemovedIssueEvent?.Invoke(ParentIssueRemovedIssueEvent!);
            }
            else if (IsBlockedByAddedIssueEvent)
            {
                blockedByAddedIssueEvent?.Invoke(BlockedByAddedIssueEvent!);
            }
            else if (IsBlockedByRemovedIssueEvent)
            {
                blockedByRemovedIssueEvent?.Invoke(BlockedByRemovedIssueEvent!);
            }
            else if (IsBlockingAddedIssueEvent)
            {
                blockingAddedIssueEvent?.Invoke(BlockingAddedIssueEvent!);
            }
            else if (IsBlockingRemovedIssueEvent)
            {
                blockingRemovedIssueEvent?.Invoke(BlockingRemovedIssueEvent!);
            }
            else if (IsTimelineConnectedEvent)
            {
                timelineConnectedEvent?.Invoke(TimelineConnectedEvent!);
            }
            else if (IsTimelineDisconnectedEvent)
            {
                timelineDisconnectedEvent?.Invoke(TimelineDisconnectedEvent!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.GitHub.LabeledIssueEvent>? labeledIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.UnlabeledIssueEvent>? unlabeledIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.MilestonedIssueEvent>? milestonedIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.DemilestonedIssueEvent>? demilestonedIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.RenamedIssueEvent>? renamedIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.ReviewRequestedIssueEvent>? reviewRequestedIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent>? reviewRequestRemovedIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.ReviewDismissedIssueEvent>? reviewDismissedIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.LockedIssueEvent>? lockedIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.AddedToProjectIssueEvent>? addedToProjectIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.MovedColumnInProjectIssueEvent>? movedColumnInProjectIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.RemovedFromProjectIssueEvent>? removedFromProjectIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent>? convertedNoteToIssueIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.TimelineCommentEvent>? timelineCommentEvent = null,
            global::System.Action<global::tryAGI.GitHub.TimelineCrossReferencedEvent>? timelineCrossReferencedEvent = null,
            global::System.Action<global::tryAGI.GitHub.TimelineCommittedEvent>? timelineCommittedEvent = null,
            global::System.Action<global::tryAGI.GitHub.TimelineReviewedEvent>? timelineReviewedEvent = null,
            global::System.Action<global::tryAGI.GitHub.TimelineLineCommentedEvent>? timelineLineCommentedEvent = null,
            global::System.Action<global::tryAGI.GitHub.TimelineCommitCommentedEvent>? timelineCommitCommentedEvent = null,
            global::System.Action<global::tryAGI.GitHub.TimelineAssignedIssueEvent>? timelineAssignedIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.TimelineUnassignedIssueEvent>? timelineUnassignedIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.StateChangeIssueEvent>? stateChangeIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.IssueTypeAddedIssueEvent>? issueTypeAddedIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.IssueTypeRemovedIssueEvent>? issueTypeRemovedIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.IssueTypeChangedIssueEvent>? issueTypeChangedIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.SubIssueAddedIssueEvent>? subIssueAddedIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.SubIssueRemovedIssueEvent>? subIssueRemovedIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.ParentIssueAddedIssueEvent>? parentIssueAddedIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.ParentIssueRemovedIssueEvent>? parentIssueRemovedIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.BlockedByAddedIssueEvent>? blockedByAddedIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.BlockedByRemovedIssueEvent>? blockedByRemovedIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.BlockingAddedIssueEvent>? blockingAddedIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.BlockingRemovedIssueEvent>? blockingRemovedIssueEvent = null,
            global::System.Action<global::tryAGI.GitHub.TimelineConnectedEvent>? timelineConnectedEvent = null,
            global::System.Action<global::tryAGI.GitHub.TimelineDisconnectedEvent>? timelineDisconnectedEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLabeledIssueEvent)
            {
                labeledIssueEvent?.Invoke(LabeledIssueEvent!);
            }
            else if (IsUnlabeledIssueEvent)
            {
                unlabeledIssueEvent?.Invoke(UnlabeledIssueEvent!);
            }
            else if (IsMilestonedIssueEvent)
            {
                milestonedIssueEvent?.Invoke(MilestonedIssueEvent!);
            }
            else if (IsDemilestonedIssueEvent)
            {
                demilestonedIssueEvent?.Invoke(DemilestonedIssueEvent!);
            }
            else if (IsRenamedIssueEvent)
            {
                renamedIssueEvent?.Invoke(RenamedIssueEvent!);
            }
            else if (IsReviewRequestedIssueEvent)
            {
                reviewRequestedIssueEvent?.Invoke(ReviewRequestedIssueEvent!);
            }
            else if (IsReviewRequestRemovedIssueEvent)
            {
                reviewRequestRemovedIssueEvent?.Invoke(ReviewRequestRemovedIssueEvent!);
            }
            else if (IsReviewDismissedIssueEvent)
            {
                reviewDismissedIssueEvent?.Invoke(ReviewDismissedIssueEvent!);
            }
            else if (IsLockedIssueEvent)
            {
                lockedIssueEvent?.Invoke(LockedIssueEvent!);
            }
            else if (IsAddedToProjectIssueEvent)
            {
                addedToProjectIssueEvent?.Invoke(AddedToProjectIssueEvent!);
            }
            else if (IsMovedColumnInProjectIssueEvent)
            {
                movedColumnInProjectIssueEvent?.Invoke(MovedColumnInProjectIssueEvent!);
            }
            else if (IsRemovedFromProjectIssueEvent)
            {
                removedFromProjectIssueEvent?.Invoke(RemovedFromProjectIssueEvent!);
            }
            else if (IsConvertedNoteToIssueIssueEvent)
            {
                convertedNoteToIssueIssueEvent?.Invoke(ConvertedNoteToIssueIssueEvent!);
            }
            else if (IsTimelineCommentEvent)
            {
                timelineCommentEvent?.Invoke(TimelineCommentEvent!);
            }
            else if (IsTimelineCrossReferencedEvent)
            {
                timelineCrossReferencedEvent?.Invoke(TimelineCrossReferencedEvent!);
            }
            else if (IsTimelineCommittedEvent)
            {
                timelineCommittedEvent?.Invoke(TimelineCommittedEvent!);
            }
            else if (IsTimelineReviewedEvent)
            {
                timelineReviewedEvent?.Invoke(TimelineReviewedEvent!);
            }
            else if (IsTimelineLineCommentedEvent)
            {
                timelineLineCommentedEvent?.Invoke(TimelineLineCommentedEvent!);
            }
            else if (IsTimelineCommitCommentedEvent)
            {
                timelineCommitCommentedEvent?.Invoke(TimelineCommitCommentedEvent!);
            }
            else if (IsTimelineAssignedIssueEvent)
            {
                timelineAssignedIssueEvent?.Invoke(TimelineAssignedIssueEvent!);
            }
            else if (IsTimelineUnassignedIssueEvent)
            {
                timelineUnassignedIssueEvent?.Invoke(TimelineUnassignedIssueEvent!);
            }
            else if (IsStateChangeIssueEvent)
            {
                stateChangeIssueEvent?.Invoke(StateChangeIssueEvent!);
            }
            else if (IsIssueTypeAddedIssueEvent)
            {
                issueTypeAddedIssueEvent?.Invoke(IssueTypeAddedIssueEvent!);
            }
            else if (IsIssueTypeRemovedIssueEvent)
            {
                issueTypeRemovedIssueEvent?.Invoke(IssueTypeRemovedIssueEvent!);
            }
            else if (IsIssueTypeChangedIssueEvent)
            {
                issueTypeChangedIssueEvent?.Invoke(IssueTypeChangedIssueEvent!);
            }
            else if (IsSubIssueAddedIssueEvent)
            {
                subIssueAddedIssueEvent?.Invoke(SubIssueAddedIssueEvent!);
            }
            else if (IsSubIssueRemovedIssueEvent)
            {
                subIssueRemovedIssueEvent?.Invoke(SubIssueRemovedIssueEvent!);
            }
            else if (IsParentIssueAddedIssueEvent)
            {
                parentIssueAddedIssueEvent?.Invoke(ParentIssueAddedIssueEvent!);
            }
            else if (IsParentIssueRemovedIssueEvent)
            {
                parentIssueRemovedIssueEvent?.Invoke(ParentIssueRemovedIssueEvent!);
            }
            else if (IsBlockedByAddedIssueEvent)
            {
                blockedByAddedIssueEvent?.Invoke(BlockedByAddedIssueEvent!);
            }
            else if (IsBlockedByRemovedIssueEvent)
            {
                blockedByRemovedIssueEvent?.Invoke(BlockedByRemovedIssueEvent!);
            }
            else if (IsBlockingAddedIssueEvent)
            {
                blockingAddedIssueEvent?.Invoke(BlockingAddedIssueEvent!);
            }
            else if (IsBlockingRemovedIssueEvent)
            {
                blockingRemovedIssueEvent?.Invoke(BlockingRemovedIssueEvent!);
            }
            else if (IsTimelineConnectedEvent)
            {
                timelineConnectedEvent?.Invoke(TimelineConnectedEvent!);
            }
            else if (IsTimelineDisconnectedEvent)
            {
                timelineDisconnectedEvent?.Invoke(TimelineDisconnectedEvent!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LabeledIssueEvent,
                typeof(global::tryAGI.GitHub.LabeledIssueEvent),
                UnlabeledIssueEvent,
                typeof(global::tryAGI.GitHub.UnlabeledIssueEvent),
                MilestonedIssueEvent,
                typeof(global::tryAGI.GitHub.MilestonedIssueEvent),
                DemilestonedIssueEvent,
                typeof(global::tryAGI.GitHub.DemilestonedIssueEvent),
                RenamedIssueEvent,
                typeof(global::tryAGI.GitHub.RenamedIssueEvent),
                ReviewRequestedIssueEvent,
                typeof(global::tryAGI.GitHub.ReviewRequestedIssueEvent),
                ReviewRequestRemovedIssueEvent,
                typeof(global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent),
                ReviewDismissedIssueEvent,
                typeof(global::tryAGI.GitHub.ReviewDismissedIssueEvent),
                LockedIssueEvent,
                typeof(global::tryAGI.GitHub.LockedIssueEvent),
                AddedToProjectIssueEvent,
                typeof(global::tryAGI.GitHub.AddedToProjectIssueEvent),
                MovedColumnInProjectIssueEvent,
                typeof(global::tryAGI.GitHub.MovedColumnInProjectIssueEvent),
                RemovedFromProjectIssueEvent,
                typeof(global::tryAGI.GitHub.RemovedFromProjectIssueEvent),
                ConvertedNoteToIssueIssueEvent,
                typeof(global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent),
                TimelineCommentEvent,
                typeof(global::tryAGI.GitHub.TimelineCommentEvent),
                TimelineCrossReferencedEvent,
                typeof(global::tryAGI.GitHub.TimelineCrossReferencedEvent),
                TimelineCommittedEvent,
                typeof(global::tryAGI.GitHub.TimelineCommittedEvent),
                TimelineReviewedEvent,
                typeof(global::tryAGI.GitHub.TimelineReviewedEvent),
                TimelineLineCommentedEvent,
                typeof(global::tryAGI.GitHub.TimelineLineCommentedEvent),
                TimelineCommitCommentedEvent,
                typeof(global::tryAGI.GitHub.TimelineCommitCommentedEvent),
                TimelineAssignedIssueEvent,
                typeof(global::tryAGI.GitHub.TimelineAssignedIssueEvent),
                TimelineUnassignedIssueEvent,
                typeof(global::tryAGI.GitHub.TimelineUnassignedIssueEvent),
                StateChangeIssueEvent,
                typeof(global::tryAGI.GitHub.StateChangeIssueEvent),
                IssueTypeAddedIssueEvent,
                typeof(global::tryAGI.GitHub.IssueTypeAddedIssueEvent),
                IssueTypeRemovedIssueEvent,
                typeof(global::tryAGI.GitHub.IssueTypeRemovedIssueEvent),
                IssueTypeChangedIssueEvent,
                typeof(global::tryAGI.GitHub.IssueTypeChangedIssueEvent),
                SubIssueAddedIssueEvent,
                typeof(global::tryAGI.GitHub.SubIssueAddedIssueEvent),
                SubIssueRemovedIssueEvent,
                typeof(global::tryAGI.GitHub.SubIssueRemovedIssueEvent),
                ParentIssueAddedIssueEvent,
                typeof(global::tryAGI.GitHub.ParentIssueAddedIssueEvent),
                ParentIssueRemovedIssueEvent,
                typeof(global::tryAGI.GitHub.ParentIssueRemovedIssueEvent),
                BlockedByAddedIssueEvent,
                typeof(global::tryAGI.GitHub.BlockedByAddedIssueEvent),
                BlockedByRemovedIssueEvent,
                typeof(global::tryAGI.GitHub.BlockedByRemovedIssueEvent),
                BlockingAddedIssueEvent,
                typeof(global::tryAGI.GitHub.BlockingAddedIssueEvent),
                BlockingRemovedIssueEvent,
                typeof(global::tryAGI.GitHub.BlockingRemovedIssueEvent),
                TimelineConnectedEvent,
                typeof(global::tryAGI.GitHub.TimelineConnectedEvent),
                TimelineDisconnectedEvent,
                typeof(global::tryAGI.GitHub.TimelineDisconnectedEvent),
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
        public bool Equals(TimelineIssueEvents other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.LabeledIssueEvent?>.Default.Equals(LabeledIssueEvent, other.LabeledIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.UnlabeledIssueEvent?>.Default.Equals(UnlabeledIssueEvent, other.UnlabeledIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.MilestonedIssueEvent?>.Default.Equals(MilestonedIssueEvent, other.MilestonedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.DemilestonedIssueEvent?>.Default.Equals(DemilestonedIssueEvent, other.DemilestonedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RenamedIssueEvent?>.Default.Equals(RenamedIssueEvent, other.RenamedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.ReviewRequestedIssueEvent?>.Default.Equals(ReviewRequestedIssueEvent, other.ReviewRequestedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent?>.Default.Equals(ReviewRequestRemovedIssueEvent, other.ReviewRequestRemovedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.ReviewDismissedIssueEvent?>.Default.Equals(ReviewDismissedIssueEvent, other.ReviewDismissedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.LockedIssueEvent?>.Default.Equals(LockedIssueEvent, other.LockedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AddedToProjectIssueEvent?>.Default.Equals(AddedToProjectIssueEvent, other.AddedToProjectIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.MovedColumnInProjectIssueEvent?>.Default.Equals(MovedColumnInProjectIssueEvent, other.MovedColumnInProjectIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RemovedFromProjectIssueEvent?>.Default.Equals(RemovedFromProjectIssueEvent, other.RemovedFromProjectIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent?>.Default.Equals(ConvertedNoteToIssueIssueEvent, other.ConvertedNoteToIssueIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.TimelineCommentEvent?>.Default.Equals(TimelineCommentEvent, other.TimelineCommentEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.TimelineCrossReferencedEvent?>.Default.Equals(TimelineCrossReferencedEvent, other.TimelineCrossReferencedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.TimelineCommittedEvent?>.Default.Equals(TimelineCommittedEvent, other.TimelineCommittedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.TimelineReviewedEvent?>.Default.Equals(TimelineReviewedEvent, other.TimelineReviewedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.TimelineLineCommentedEvent?>.Default.Equals(TimelineLineCommentedEvent, other.TimelineLineCommentedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.TimelineCommitCommentedEvent?>.Default.Equals(TimelineCommitCommentedEvent, other.TimelineCommitCommentedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.TimelineAssignedIssueEvent?>.Default.Equals(TimelineAssignedIssueEvent, other.TimelineAssignedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.TimelineUnassignedIssueEvent?>.Default.Equals(TimelineUnassignedIssueEvent, other.TimelineUnassignedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.StateChangeIssueEvent?>.Default.Equals(StateChangeIssueEvent, other.StateChangeIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.IssueTypeAddedIssueEvent?>.Default.Equals(IssueTypeAddedIssueEvent, other.IssueTypeAddedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.IssueTypeRemovedIssueEvent?>.Default.Equals(IssueTypeRemovedIssueEvent, other.IssueTypeRemovedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.IssueTypeChangedIssueEvent?>.Default.Equals(IssueTypeChangedIssueEvent, other.IssueTypeChangedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.SubIssueAddedIssueEvent?>.Default.Equals(SubIssueAddedIssueEvent, other.SubIssueAddedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.SubIssueRemovedIssueEvent?>.Default.Equals(SubIssueRemovedIssueEvent, other.SubIssueRemovedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.ParentIssueAddedIssueEvent?>.Default.Equals(ParentIssueAddedIssueEvent, other.ParentIssueAddedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.ParentIssueRemovedIssueEvent?>.Default.Equals(ParentIssueRemovedIssueEvent, other.ParentIssueRemovedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.BlockedByAddedIssueEvent?>.Default.Equals(BlockedByAddedIssueEvent, other.BlockedByAddedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.BlockedByRemovedIssueEvent?>.Default.Equals(BlockedByRemovedIssueEvent, other.BlockedByRemovedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.BlockingAddedIssueEvent?>.Default.Equals(BlockingAddedIssueEvent, other.BlockingAddedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.BlockingRemovedIssueEvent?>.Default.Equals(BlockingRemovedIssueEvent, other.BlockingRemovedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.TimelineConnectedEvent?>.Default.Equals(TimelineConnectedEvent, other.TimelineConnectedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.TimelineDisconnectedEvent?>.Default.Equals(TimelineDisconnectedEvent, other.TimelineDisconnectedEvent)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TimelineIssueEvents obj1, TimelineIssueEvents obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TimelineIssueEvents>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TimelineIssueEvents obj1, TimelineIssueEvents obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TimelineIssueEvents o && Equals(o);
        }
    }
}
