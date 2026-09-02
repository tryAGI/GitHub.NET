#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A repository rule with ruleset details.
    /// </summary>
    public readonly partial struct RepositoryRuleDetailed : global::System.IEquatable<RepositoryRuleDetailed>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCreation, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant1 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCreation, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant1))]
#endif
        public bool IsRepositoryRuleDetailedVariant1 => RepositoryRuleDetailedVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCreation, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant1;
            return IsRepositoryRuleDetailedVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCreation, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant1() => IsRepositoryRuleDetailedVariant1
            ? RepositoryRuleDetailedVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleUpdate, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant2 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleUpdate, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant2))]
#endif
        public bool IsRepositoryRuleDetailedVariant2 => RepositoryRuleDetailedVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleUpdate, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant2;
            return IsRepositoryRuleDetailedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleUpdate, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant2() => IsRepositoryRuleDetailedVariant2
            ? RepositoryRuleDetailedVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleDeletion, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant3 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleDeletion, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant3))]
#endif
        public bool IsRepositoryRuleDetailedVariant3 => RepositoryRuleDetailedVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleDeletion, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant3;
            return IsRepositoryRuleDetailedVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleDeletion, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant3() => IsRepositoryRuleDetailedVariant3
            ? RepositoryRuleDetailedVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant4 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant4))]
#endif
        public bool IsRepositoryRuleDetailedVariant4 => RepositoryRuleDetailedVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant4;
            return IsRepositoryRuleDetailedVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant4() => IsRepositoryRuleDetailedVariant4
            ? RepositoryRuleDetailedVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMergeQueue, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant5 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMergeQueue, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant5))]
#endif
        public bool IsRepositoryRuleDetailedVariant5 => RepositoryRuleDetailedVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMergeQueue, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant5;
            return IsRepositoryRuleDetailedVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMergeQueue, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant5() => IsRepositoryRuleDetailedVariant5
            ? RepositoryRuleDetailedVariant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant5' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant6 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant6 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant6))]
#endif
        public bool IsRepositoryRuleDetailedVariant6 => RepositoryRuleDetailedVariant6 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant6;
            return IsRepositoryRuleDetailedVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant6() => IsRepositoryRuleDetailedVariant6
            ? RepositoryRuleDetailedVariant6!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant6' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant7 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant7 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant7))]
#endif
        public bool IsRepositoryRuleDetailedVariant7 => RepositoryRuleDetailedVariant7 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant7;
            return IsRepositoryRuleDetailedVariant7;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant7() => IsRepositoryRuleDetailedVariant7
            ? RepositoryRuleDetailedVariant7!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant7' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulePullRequest, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant8 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulePullRequest, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant8 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant8))]
#endif
        public bool IsRepositoryRuleDetailedVariant8 => RepositoryRuleDetailedVariant8 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulePullRequest, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant8;
            return IsRepositoryRuleDetailedVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulePullRequest, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant8() => IsRepositoryRuleDetailedVariant8
            ? RepositoryRuleDetailedVariant8!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant8' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant9 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant9 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant9))]
#endif
        public bool IsRepositoryRuleDetailedVariant9 => RepositoryRuleDetailedVariant9 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant9(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant9;
            return IsRepositoryRuleDetailedVariant9;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant9() => IsRepositoryRuleDetailedVariant9
            ? RepositoryRuleDetailedVariant9!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant9' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleNonFastForward, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant10 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleNonFastForward, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant10 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant10))]
#endif
        public bool IsRepositoryRuleDetailedVariant10 => RepositoryRuleDetailedVariant10 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant10(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleNonFastForward, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant10;
            return IsRepositoryRuleDetailedVariant10;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleNonFastForward, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant10() => IsRepositoryRuleDetailedVariant10
            ? RepositoryRuleDetailedVariant10!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant10' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant11 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant11 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant11))]
#endif
        public bool IsRepositoryRuleDetailedVariant11 => RepositoryRuleDetailedVariant11 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant11(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant11;
            return IsRepositoryRuleDetailedVariant11;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant11() => IsRepositoryRuleDetailedVariant11
            ? RepositoryRuleDetailedVariant11!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant11' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant12 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant12 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant12))]
#endif
        public bool IsRepositoryRuleDetailedVariant12 => RepositoryRuleDetailedVariant12 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant12(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant12;
            return IsRepositoryRuleDetailedVariant12;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant12() => IsRepositoryRuleDetailedVariant12
            ? RepositoryRuleDetailedVariant12!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant12' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant13 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant13 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant13))]
#endif
        public bool IsRepositoryRuleDetailedVariant13 => RepositoryRuleDetailedVariant13 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant13(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant13;
            return IsRepositoryRuleDetailedVariant13;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant13() => IsRepositoryRuleDetailedVariant13
            ? RepositoryRuleDetailedVariant13!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant13' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant14 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant14 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant14))]
#endif
        public bool IsRepositoryRuleDetailedVariant14 => RepositoryRuleDetailedVariant14 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant14(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant14;
            return IsRepositoryRuleDetailedVariant14;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant14() => IsRepositoryRuleDetailedVariant14
            ? RepositoryRuleDetailedVariant14!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant14' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleTagNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant15 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleTagNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant15 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant15))]
#endif
        public bool IsRepositoryRuleDetailedVariant15 => RepositoryRuleDetailedVariant15 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant15(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleTagNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant15;
            return IsRepositoryRuleDetailedVariant15;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleTagNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant15() => IsRepositoryRuleDetailedVariant15
            ? RepositoryRuleDetailedVariant15!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant15' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleWorkflows, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant16 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleWorkflows, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant16 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant16))]
#endif
        public bool IsRepositoryRuleDetailedVariant16 => RepositoryRuleDetailedVariant16 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant16(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleWorkflows, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant16;
            return IsRepositoryRuleDetailedVariant16;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleWorkflows, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant16() => IsRepositoryRuleDetailedVariant16
            ? RepositoryRuleDetailedVariant16!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant16' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCodeScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant17 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCodeScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant17 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant17))]
#endif
        public bool IsRepositoryRuleDetailedVariant17 => RepositoryRuleDetailedVariant17 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant17(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCodeScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant17;
            return IsRepositoryRuleDetailedVariant17;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCodeScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant17() => IsRepositoryRuleDetailedVariant17
            ? RepositoryRuleDetailedVariant17!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant17' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant18 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant18 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant18))]
#endif
        public bool IsRepositoryRuleDetailedVariant18 => RepositoryRuleDetailedVariant18 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant18(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant18;
            return IsRepositoryRuleDetailedVariant18;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant18() => IsRepositoryRuleDetailedVariant18
            ? RepositoryRuleDetailedVariant18!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant18' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant19 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant19 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant19))]
#endif
        public bool IsRepositoryRuleDetailedVariant19 => RepositoryRuleDetailedVariant19 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant19(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant19;
            return IsRepositoryRuleDetailedVariant19;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant19() => IsRepositoryRuleDetailedVariant19
            ? RepositoryRuleDetailedVariant19!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant19' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant20 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant20 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant20))]
#endif
        public bool IsRepositoryRuleDetailedVariant20 => RepositoryRuleDetailedVariant20 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant20(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant20;
            return IsRepositoryRuleDetailedVariant20;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant20() => IsRepositoryRuleDetailedVariant20
            ? RepositoryRuleDetailedVariant20!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant20' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant21 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant21 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant21))]
#endif
        public bool IsRepositoryRuleDetailedVariant21 => RepositoryRuleDetailedVariant21 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant21(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant21;
            return IsRepositoryRuleDetailedVariant21;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant21() => IsRepositoryRuleDetailedVariant21
            ? RepositoryRuleDetailedVariant21!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant21' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant22 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant22 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant22))]
#endif
        public bool IsRepositoryRuleDetailedVariant22 => RepositoryRuleDetailedVariant22 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant22(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant22;
            return IsRepositoryRuleDetailedVariant22;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant22() => IsRepositoryRuleDetailedVariant22
            ? RepositoryRuleDetailedVariant22!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant22' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFileSize, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant23 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFileSize, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant23 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant23))]
#endif
        public bool IsRepositoryRuleDetailedVariant23 => RepositoryRuleDetailedVariant23 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryRuleDetailedVariant23(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFileSize, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            value = RepositoryRuleDetailedVariant23;
            return IsRepositoryRuleDetailedVariant23;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFileSize, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> PickRepositoryRuleDetailedVariant23() => IsRepositoryRuleDetailedVariant23
            ? RepositoryRuleDetailedVariant23!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryRuleDetailedVariant23' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCreation, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCreation, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCreation, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant1;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCreation, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant1(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCreation, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleUpdate, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleUpdate, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleUpdate, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant2;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleUpdate, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant2(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleUpdate, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleDeletion, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleDeletion, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleDeletion, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant3;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleDeletion, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant3(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleDeletion, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant4;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant4(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMergeQueue, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMergeQueue, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMergeQueue, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant5;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMergeQueue, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant5(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMergeQueue, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant6;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant6 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant6(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant7;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant7 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant7(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulePullRequest, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulePullRequest, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulePullRequest, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant8;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulePullRequest, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant8 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant8(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulePullRequest, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant9;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant9 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant9(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleNonFastForward, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleNonFastForward, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleNonFastForward, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant10;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleNonFastForward, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant10 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant10(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleNonFastForward, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant11;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant11 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant11(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant12;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant12 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant12(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant13;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant13 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant13(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant14;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant14 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant14(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleTagNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleTagNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleTagNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant15;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleTagNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant15 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant15(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleTagNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleWorkflows, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleWorkflows, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleWorkflows, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant16;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleWorkflows, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant16 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant16(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleWorkflows, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCodeScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCodeScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCodeScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant17;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCodeScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant17 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant17(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCodeScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant18;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant18 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant18(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant19;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant19 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant19(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant20;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant20 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant20(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant21;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant21 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant21(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant22;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant22 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant22(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFileSize, global::tryAGI.GitHub.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFileSize, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFileSize, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant23;

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFileSize, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant23 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RepositoryRuleDetailed FromRepositoryRuleDetailedVariant23(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFileSize, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? value) => new RepositoryRuleDetailed(value);

        /// <summary>
        ///
        /// </summary>
        public RepositoryRuleDetailed(
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCreation, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant1,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleUpdate, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant2,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleDeletion, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant3,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant4,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMergeQueue, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant5,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant6,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant7,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulePullRequest, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant8,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant9,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleNonFastForward, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant10,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant11,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant12,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant13,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant14,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleTagNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant15,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleWorkflows, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant16,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCodeScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant17,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant18,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant19,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant20,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant21,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant22,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFileSize, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant23
            )
        {
            RepositoryRuleDetailedVariant1 = repositoryRuleDetailedVariant1;
            RepositoryRuleDetailedVariant2 = repositoryRuleDetailedVariant2;
            RepositoryRuleDetailedVariant3 = repositoryRuleDetailedVariant3;
            RepositoryRuleDetailedVariant4 = repositoryRuleDetailedVariant4;
            RepositoryRuleDetailedVariant5 = repositoryRuleDetailedVariant5;
            RepositoryRuleDetailedVariant6 = repositoryRuleDetailedVariant6;
            RepositoryRuleDetailedVariant7 = repositoryRuleDetailedVariant7;
            RepositoryRuleDetailedVariant8 = repositoryRuleDetailedVariant8;
            RepositoryRuleDetailedVariant9 = repositoryRuleDetailedVariant9;
            RepositoryRuleDetailedVariant10 = repositoryRuleDetailedVariant10;
            RepositoryRuleDetailedVariant11 = repositoryRuleDetailedVariant11;
            RepositoryRuleDetailedVariant12 = repositoryRuleDetailedVariant12;
            RepositoryRuleDetailedVariant13 = repositoryRuleDetailedVariant13;
            RepositoryRuleDetailedVariant14 = repositoryRuleDetailedVariant14;
            RepositoryRuleDetailedVariant15 = repositoryRuleDetailedVariant15;
            RepositoryRuleDetailedVariant16 = repositoryRuleDetailedVariant16;
            RepositoryRuleDetailedVariant17 = repositoryRuleDetailedVariant17;
            RepositoryRuleDetailedVariant18 = repositoryRuleDetailedVariant18;
            RepositoryRuleDetailedVariant19 = repositoryRuleDetailedVariant19;
            RepositoryRuleDetailedVariant20 = repositoryRuleDetailedVariant20;
            RepositoryRuleDetailedVariant21 = repositoryRuleDetailedVariant21;
            RepositoryRuleDetailedVariant22 = repositoryRuleDetailedVariant22;
            RepositoryRuleDetailedVariant23 = repositoryRuleDetailedVariant23;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RepositoryRuleDetailedVariant23 as object ??
            RepositoryRuleDetailedVariant22 as object ??
            RepositoryRuleDetailedVariant21 as object ??
            RepositoryRuleDetailedVariant20 as object ??
            RepositoryRuleDetailedVariant19 as object ??
            RepositoryRuleDetailedVariant18 as object ??
            RepositoryRuleDetailedVariant17 as object ??
            RepositoryRuleDetailedVariant16 as object ??
            RepositoryRuleDetailedVariant15 as object ??
            RepositoryRuleDetailedVariant14 as object ??
            RepositoryRuleDetailedVariant13 as object ??
            RepositoryRuleDetailedVariant12 as object ??
            RepositoryRuleDetailedVariant11 as object ??
            RepositoryRuleDetailedVariant10 as object ??
            RepositoryRuleDetailedVariant9 as object ??
            RepositoryRuleDetailedVariant8 as object ??
            RepositoryRuleDetailedVariant7 as object ??
            RepositoryRuleDetailedVariant6 as object ??
            RepositoryRuleDetailedVariant5 as object ??
            RepositoryRuleDetailedVariant4 as object ??
            RepositoryRuleDetailedVariant3 as object ??
            RepositoryRuleDetailedVariant2 as object ??
            RepositoryRuleDetailedVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RepositoryRuleDetailedVariant1?.ToString() ??
            RepositoryRuleDetailedVariant2?.ToString() ??
            RepositoryRuleDetailedVariant3?.ToString() ??
            RepositoryRuleDetailedVariant4?.ToString() ??
            RepositoryRuleDetailedVariant5?.ToString() ??
            RepositoryRuleDetailedVariant6?.ToString() ??
            RepositoryRuleDetailedVariant7?.ToString() ??
            RepositoryRuleDetailedVariant8?.ToString() ??
            RepositoryRuleDetailedVariant9?.ToString() ??
            RepositoryRuleDetailedVariant10?.ToString() ??
            RepositoryRuleDetailedVariant11?.ToString() ??
            RepositoryRuleDetailedVariant12?.ToString() ??
            RepositoryRuleDetailedVariant13?.ToString() ??
            RepositoryRuleDetailedVariant14?.ToString() ??
            RepositoryRuleDetailedVariant15?.ToString() ??
            RepositoryRuleDetailedVariant16?.ToString() ??
            RepositoryRuleDetailedVariant17?.ToString() ??
            RepositoryRuleDetailedVariant18?.ToString() ??
            RepositoryRuleDetailedVariant19?.ToString() ??
            RepositoryRuleDetailedVariant20?.ToString() ??
            RepositoryRuleDetailedVariant21?.ToString() ??
            RepositoryRuleDetailedVariant22?.ToString() ??
            RepositoryRuleDetailedVariant23?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && IsRepositoryRuleDetailedVariant22 && !IsRepositoryRuleDetailedVariant23 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 && !IsRepositoryRuleDetailedVariant18 && !IsRepositoryRuleDetailedVariant19 && !IsRepositoryRuleDetailedVariant20 && !IsRepositoryRuleDetailedVariant21 && !IsRepositoryRuleDetailedVariant22 && IsRepositoryRuleDetailedVariant23;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCreation, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant1 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleUpdate, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant2 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleDeletion, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant3 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant4 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMergeQueue, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant5 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant6 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant7 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulePullRequest, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant8 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant9 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleNonFastForward, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant10 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant11 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant12 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant13 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant14 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleTagNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant15 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleWorkflows, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant16 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCodeScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant17 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant18 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant19 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant20 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant21 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant22 = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFileSize, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant23 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRepositoryRuleDetailedVariant1 && repositoryRuleDetailedVariant1 != null)
            {
                return repositoryRuleDetailedVariant1(RepositoryRuleDetailedVariant1!);
            }
            else if (IsRepositoryRuleDetailedVariant2 && repositoryRuleDetailedVariant2 != null)
            {
                return repositoryRuleDetailedVariant2(RepositoryRuleDetailedVariant2!);
            }
            else if (IsRepositoryRuleDetailedVariant3 && repositoryRuleDetailedVariant3 != null)
            {
                return repositoryRuleDetailedVariant3(RepositoryRuleDetailedVariant3!);
            }
            else if (IsRepositoryRuleDetailedVariant4 && repositoryRuleDetailedVariant4 != null)
            {
                return repositoryRuleDetailedVariant4(RepositoryRuleDetailedVariant4!);
            }
            else if (IsRepositoryRuleDetailedVariant5 && repositoryRuleDetailedVariant5 != null)
            {
                return repositoryRuleDetailedVariant5(RepositoryRuleDetailedVariant5!);
            }
            else if (IsRepositoryRuleDetailedVariant6 && repositoryRuleDetailedVariant6 != null)
            {
                return repositoryRuleDetailedVariant6(RepositoryRuleDetailedVariant6!);
            }
            else if (IsRepositoryRuleDetailedVariant7 && repositoryRuleDetailedVariant7 != null)
            {
                return repositoryRuleDetailedVariant7(RepositoryRuleDetailedVariant7!);
            }
            else if (IsRepositoryRuleDetailedVariant8 && repositoryRuleDetailedVariant8 != null)
            {
                return repositoryRuleDetailedVariant8(RepositoryRuleDetailedVariant8!);
            }
            else if (IsRepositoryRuleDetailedVariant9 && repositoryRuleDetailedVariant9 != null)
            {
                return repositoryRuleDetailedVariant9(RepositoryRuleDetailedVariant9!);
            }
            else if (IsRepositoryRuleDetailedVariant10 && repositoryRuleDetailedVariant10 != null)
            {
                return repositoryRuleDetailedVariant10(RepositoryRuleDetailedVariant10!);
            }
            else if (IsRepositoryRuleDetailedVariant11 && repositoryRuleDetailedVariant11 != null)
            {
                return repositoryRuleDetailedVariant11(RepositoryRuleDetailedVariant11!);
            }
            else if (IsRepositoryRuleDetailedVariant12 && repositoryRuleDetailedVariant12 != null)
            {
                return repositoryRuleDetailedVariant12(RepositoryRuleDetailedVariant12!);
            }
            else if (IsRepositoryRuleDetailedVariant13 && repositoryRuleDetailedVariant13 != null)
            {
                return repositoryRuleDetailedVariant13(RepositoryRuleDetailedVariant13!);
            }
            else if (IsRepositoryRuleDetailedVariant14 && repositoryRuleDetailedVariant14 != null)
            {
                return repositoryRuleDetailedVariant14(RepositoryRuleDetailedVariant14!);
            }
            else if (IsRepositoryRuleDetailedVariant15 && repositoryRuleDetailedVariant15 != null)
            {
                return repositoryRuleDetailedVariant15(RepositoryRuleDetailedVariant15!);
            }
            else if (IsRepositoryRuleDetailedVariant16 && repositoryRuleDetailedVariant16 != null)
            {
                return repositoryRuleDetailedVariant16(RepositoryRuleDetailedVariant16!);
            }
            else if (IsRepositoryRuleDetailedVariant17 && repositoryRuleDetailedVariant17 != null)
            {
                return repositoryRuleDetailedVariant17(RepositoryRuleDetailedVariant17!);
            }
            else if (IsRepositoryRuleDetailedVariant18 && repositoryRuleDetailedVariant18 != null)
            {
                return repositoryRuleDetailedVariant18(RepositoryRuleDetailedVariant18!);
            }
            else if (IsRepositoryRuleDetailedVariant19 && repositoryRuleDetailedVariant19 != null)
            {
                return repositoryRuleDetailedVariant19(RepositoryRuleDetailedVariant19!);
            }
            else if (IsRepositoryRuleDetailedVariant20 && repositoryRuleDetailedVariant20 != null)
            {
                return repositoryRuleDetailedVariant20(RepositoryRuleDetailedVariant20!);
            }
            else if (IsRepositoryRuleDetailedVariant21 && repositoryRuleDetailedVariant21 != null)
            {
                return repositoryRuleDetailedVariant21(RepositoryRuleDetailedVariant21!);
            }
            else if (IsRepositoryRuleDetailedVariant22 && repositoryRuleDetailedVariant22 != null)
            {
                return repositoryRuleDetailedVariant22(RepositoryRuleDetailedVariant22!);
            }
            else if (IsRepositoryRuleDetailedVariant23 && repositoryRuleDetailedVariant23 != null)
            {
                return repositoryRuleDetailedVariant23(RepositoryRuleDetailedVariant23!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCreation, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant1 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleUpdate, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant2 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleDeletion, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant3 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant4 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMergeQueue, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant5 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant6 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant7 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulePullRequest, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant8 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant9 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleNonFastForward, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant10 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant11 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant12 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant13 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant14 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleTagNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant15 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleWorkflows, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant16 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCodeScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant17 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant18 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant19 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant20 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant21 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant22 = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFileSize, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant23 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRepositoryRuleDetailedVariant1)
            {
                repositoryRuleDetailedVariant1?.Invoke(RepositoryRuleDetailedVariant1!);
            }
            else if (IsRepositoryRuleDetailedVariant2)
            {
                repositoryRuleDetailedVariant2?.Invoke(RepositoryRuleDetailedVariant2!);
            }
            else if (IsRepositoryRuleDetailedVariant3)
            {
                repositoryRuleDetailedVariant3?.Invoke(RepositoryRuleDetailedVariant3!);
            }
            else if (IsRepositoryRuleDetailedVariant4)
            {
                repositoryRuleDetailedVariant4?.Invoke(RepositoryRuleDetailedVariant4!);
            }
            else if (IsRepositoryRuleDetailedVariant5)
            {
                repositoryRuleDetailedVariant5?.Invoke(RepositoryRuleDetailedVariant5!);
            }
            else if (IsRepositoryRuleDetailedVariant6)
            {
                repositoryRuleDetailedVariant6?.Invoke(RepositoryRuleDetailedVariant6!);
            }
            else if (IsRepositoryRuleDetailedVariant7)
            {
                repositoryRuleDetailedVariant7?.Invoke(RepositoryRuleDetailedVariant7!);
            }
            else if (IsRepositoryRuleDetailedVariant8)
            {
                repositoryRuleDetailedVariant8?.Invoke(RepositoryRuleDetailedVariant8!);
            }
            else if (IsRepositoryRuleDetailedVariant9)
            {
                repositoryRuleDetailedVariant9?.Invoke(RepositoryRuleDetailedVariant9!);
            }
            else if (IsRepositoryRuleDetailedVariant10)
            {
                repositoryRuleDetailedVariant10?.Invoke(RepositoryRuleDetailedVariant10!);
            }
            else if (IsRepositoryRuleDetailedVariant11)
            {
                repositoryRuleDetailedVariant11?.Invoke(RepositoryRuleDetailedVariant11!);
            }
            else if (IsRepositoryRuleDetailedVariant12)
            {
                repositoryRuleDetailedVariant12?.Invoke(RepositoryRuleDetailedVariant12!);
            }
            else if (IsRepositoryRuleDetailedVariant13)
            {
                repositoryRuleDetailedVariant13?.Invoke(RepositoryRuleDetailedVariant13!);
            }
            else if (IsRepositoryRuleDetailedVariant14)
            {
                repositoryRuleDetailedVariant14?.Invoke(RepositoryRuleDetailedVariant14!);
            }
            else if (IsRepositoryRuleDetailedVariant15)
            {
                repositoryRuleDetailedVariant15?.Invoke(RepositoryRuleDetailedVariant15!);
            }
            else if (IsRepositoryRuleDetailedVariant16)
            {
                repositoryRuleDetailedVariant16?.Invoke(RepositoryRuleDetailedVariant16!);
            }
            else if (IsRepositoryRuleDetailedVariant17)
            {
                repositoryRuleDetailedVariant17?.Invoke(RepositoryRuleDetailedVariant17!);
            }
            else if (IsRepositoryRuleDetailedVariant18)
            {
                repositoryRuleDetailedVariant18?.Invoke(RepositoryRuleDetailedVariant18!);
            }
            else if (IsRepositoryRuleDetailedVariant19)
            {
                repositoryRuleDetailedVariant19?.Invoke(RepositoryRuleDetailedVariant19!);
            }
            else if (IsRepositoryRuleDetailedVariant20)
            {
                repositoryRuleDetailedVariant20?.Invoke(RepositoryRuleDetailedVariant20!);
            }
            else if (IsRepositoryRuleDetailedVariant21)
            {
                repositoryRuleDetailedVariant21?.Invoke(RepositoryRuleDetailedVariant21!);
            }
            else if (IsRepositoryRuleDetailedVariant22)
            {
                repositoryRuleDetailedVariant22?.Invoke(RepositoryRuleDetailedVariant22!);
            }
            else if (IsRepositoryRuleDetailedVariant23)
            {
                repositoryRuleDetailedVariant23?.Invoke(RepositoryRuleDetailedVariant23!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCreation, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant1 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleUpdate, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant2 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleDeletion, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant3 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant4 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMergeQueue, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant5 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant6 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant7 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulePullRequest, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant8 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant9 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleNonFastForward, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant10 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant11 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant12 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant13 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant14 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleTagNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant15 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleWorkflows, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant16 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCodeScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant17 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant18 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant19 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant20 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant21 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant22 = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFileSize, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant23 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRepositoryRuleDetailedVariant1)
            {
                repositoryRuleDetailedVariant1?.Invoke(RepositoryRuleDetailedVariant1!);
            }
            else if (IsRepositoryRuleDetailedVariant2)
            {
                repositoryRuleDetailedVariant2?.Invoke(RepositoryRuleDetailedVariant2!);
            }
            else if (IsRepositoryRuleDetailedVariant3)
            {
                repositoryRuleDetailedVariant3?.Invoke(RepositoryRuleDetailedVariant3!);
            }
            else if (IsRepositoryRuleDetailedVariant4)
            {
                repositoryRuleDetailedVariant4?.Invoke(RepositoryRuleDetailedVariant4!);
            }
            else if (IsRepositoryRuleDetailedVariant5)
            {
                repositoryRuleDetailedVariant5?.Invoke(RepositoryRuleDetailedVariant5!);
            }
            else if (IsRepositoryRuleDetailedVariant6)
            {
                repositoryRuleDetailedVariant6?.Invoke(RepositoryRuleDetailedVariant6!);
            }
            else if (IsRepositoryRuleDetailedVariant7)
            {
                repositoryRuleDetailedVariant7?.Invoke(RepositoryRuleDetailedVariant7!);
            }
            else if (IsRepositoryRuleDetailedVariant8)
            {
                repositoryRuleDetailedVariant8?.Invoke(RepositoryRuleDetailedVariant8!);
            }
            else if (IsRepositoryRuleDetailedVariant9)
            {
                repositoryRuleDetailedVariant9?.Invoke(RepositoryRuleDetailedVariant9!);
            }
            else if (IsRepositoryRuleDetailedVariant10)
            {
                repositoryRuleDetailedVariant10?.Invoke(RepositoryRuleDetailedVariant10!);
            }
            else if (IsRepositoryRuleDetailedVariant11)
            {
                repositoryRuleDetailedVariant11?.Invoke(RepositoryRuleDetailedVariant11!);
            }
            else if (IsRepositoryRuleDetailedVariant12)
            {
                repositoryRuleDetailedVariant12?.Invoke(RepositoryRuleDetailedVariant12!);
            }
            else if (IsRepositoryRuleDetailedVariant13)
            {
                repositoryRuleDetailedVariant13?.Invoke(RepositoryRuleDetailedVariant13!);
            }
            else if (IsRepositoryRuleDetailedVariant14)
            {
                repositoryRuleDetailedVariant14?.Invoke(RepositoryRuleDetailedVariant14!);
            }
            else if (IsRepositoryRuleDetailedVariant15)
            {
                repositoryRuleDetailedVariant15?.Invoke(RepositoryRuleDetailedVariant15!);
            }
            else if (IsRepositoryRuleDetailedVariant16)
            {
                repositoryRuleDetailedVariant16?.Invoke(RepositoryRuleDetailedVariant16!);
            }
            else if (IsRepositoryRuleDetailedVariant17)
            {
                repositoryRuleDetailedVariant17?.Invoke(RepositoryRuleDetailedVariant17!);
            }
            else if (IsRepositoryRuleDetailedVariant18)
            {
                repositoryRuleDetailedVariant18?.Invoke(RepositoryRuleDetailedVariant18!);
            }
            else if (IsRepositoryRuleDetailedVariant19)
            {
                repositoryRuleDetailedVariant19?.Invoke(RepositoryRuleDetailedVariant19!);
            }
            else if (IsRepositoryRuleDetailedVariant20)
            {
                repositoryRuleDetailedVariant20?.Invoke(RepositoryRuleDetailedVariant20!);
            }
            else if (IsRepositoryRuleDetailedVariant21)
            {
                repositoryRuleDetailedVariant21?.Invoke(RepositoryRuleDetailedVariant21!);
            }
            else if (IsRepositoryRuleDetailedVariant22)
            {
                repositoryRuleDetailedVariant22?.Invoke(RepositoryRuleDetailedVariant22!);
            }
            else if (IsRepositoryRuleDetailedVariant23)
            {
                repositoryRuleDetailedVariant23?.Invoke(RepositoryRuleDetailedVariant23!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RepositoryRuleDetailedVariant1,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCreation, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant2,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleUpdate, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant3,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleDeletion, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant4,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant5,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMergeQueue, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant6,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant7,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant8,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulePullRequest, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant9,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant10,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleNonFastForward, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant11,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant12,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant13,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant14,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant15,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleTagNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant16,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleWorkflows, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant17,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCodeScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant18,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant19,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant20,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant21,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant22,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant23,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFileSize, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>),
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
        public bool Equals(RepositoryRuleDetailed other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCreation, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant1, other.RepositoryRuleDetailedVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleUpdate, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant2, other.RepositoryRuleDetailedVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleDeletion, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant3, other.RepositoryRuleDetailedVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistory, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant4, other.RepositoryRuleDetailedVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMergeQueue, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant5, other.RepositoryRuleDetailedVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredDeployments, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant6, other.RepositoryRuleDetailedVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredSignatures, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant7, other.RepositoryRuleDetailedVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulePullRequest, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant8, other.RepositoryRuleDetailedVariant8) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleRequiredStatusChecks, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant9, other.RepositoryRuleDetailedVariant9) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleNonFastForward, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant10, other.RepositoryRuleDetailedVariant10) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitMessagePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant11, other.RepositoryRuleDetailedVariant11) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant12, other.RepositoryRuleDetailedVariant12) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCommitterEmailPattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant13, other.RepositoryRuleDetailedVariant13) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleBranchNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant14, other.RepositoryRuleDetailedVariant14) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleTagNamePattern, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant15, other.RepositoryRuleDetailedVariant15) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleWorkflows, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant16, other.RepositoryRuleDetailedVariant16) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCodeScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant17, other.RepositoryRuleDetailedVariant17) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleCopilotCodeReview, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant18, other.RepositoryRuleDetailedVariant18) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanning, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant19, other.RepositoryRuleDetailedVariant19) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFilePathRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant20, other.RepositoryRuleDetailedVariant20) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFilePathLength, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant21, other.RepositoryRuleDetailedVariant21) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleFileExtensionRestriction, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant22, other.RepositoryRuleDetailedVariant22) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRuleMaxFileSize, global::tryAGI.GitHub.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant23, other.RepositoryRuleDetailedVariant23)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RepositoryRuleDetailed obj1, RepositoryRuleDetailed obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RepositoryRuleDetailed>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RepositoryRuleDetailed obj1, RepositoryRuleDetailed obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RepositoryRuleDetailed o && Equals(o);
        }
    }
}
