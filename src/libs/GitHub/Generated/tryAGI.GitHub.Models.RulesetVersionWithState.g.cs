#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct RulesetVersionWithState : global::System.IEquatable<RulesetVersionWithState>
    {
        /// <summary>
        /// The historical version of a ruleset
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RulesetVersion? RulesetVersion { get; init; }
#else
        public global::tryAGI.GitHub.RulesetVersion? RulesetVersion { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RulesetVersion))]
#endif
        public bool IsRulesetVersion => RulesetVersion != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRulesetVersion(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RulesetVersion? value)
        {
            value = RulesetVersion;
            return IsRulesetVersion;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RulesetVersion PickRulesetVersion() => IsRulesetVersion
            ? RulesetVersion!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RulesetVersion' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.RulesetVersionWithStateVariant2? RulesetVersionWithStateVariant2 { get; init; }
#else
        public global::tryAGI.GitHub.RulesetVersionWithStateVariant2? RulesetVersionWithStateVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RulesetVersionWithStateVariant2))]
#endif
        public bool IsRulesetVersionWithStateVariant2 => RulesetVersionWithStateVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRulesetVersionWithStateVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.RulesetVersionWithStateVariant2? value)
        {
            value = RulesetVersionWithStateVariant2;
            return IsRulesetVersionWithStateVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.RulesetVersionWithStateVariant2 PickRulesetVersionWithStateVariant2() => IsRulesetVersionWithStateVariant2
            ? RulesetVersionWithStateVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RulesetVersionWithStateVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RulesetVersionWithState(global::tryAGI.GitHub.RulesetVersion value) => new RulesetVersionWithState((global::tryAGI.GitHub.RulesetVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RulesetVersion?(RulesetVersionWithState @this) => @this.RulesetVersion;

        /// <summary>
        ///
        /// </summary>
        public RulesetVersionWithState(global::tryAGI.GitHub.RulesetVersion? value)
        {
            RulesetVersion = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RulesetVersionWithState FromRulesetVersion(global::tryAGI.GitHub.RulesetVersion? value) => new RulesetVersionWithState(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RulesetVersionWithState(global::tryAGI.GitHub.RulesetVersionWithStateVariant2 value) => new RulesetVersionWithState((global::tryAGI.GitHub.RulesetVersionWithStateVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.RulesetVersionWithStateVariant2?(RulesetVersionWithState @this) => @this.RulesetVersionWithStateVariant2;

        /// <summary>
        ///
        /// </summary>
        public RulesetVersionWithState(global::tryAGI.GitHub.RulesetVersionWithStateVariant2? value)
        {
            RulesetVersionWithStateVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RulesetVersionWithState FromRulesetVersionWithStateVariant2(global::tryAGI.GitHub.RulesetVersionWithStateVariant2? value) => new RulesetVersionWithState(value);

        /// <summary>
        ///
        /// </summary>
        public RulesetVersionWithState(
            global::tryAGI.GitHub.RulesetVersion? rulesetVersion,
            global::tryAGI.GitHub.RulesetVersionWithStateVariant2? rulesetVersionWithStateVariant2
            )
        {
            RulesetVersion = rulesetVersion;
            RulesetVersionWithStateVariant2 = rulesetVersionWithStateVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RulesetVersionWithStateVariant2 as object ??
            RulesetVersion as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RulesetVersion?.ToString() ??
            RulesetVersionWithStateVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRulesetVersion && IsRulesetVersionWithStateVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.GitHub.RulesetVersion, TResult>? rulesetVersion = null,
            global::System.Func<global::tryAGI.GitHub.RulesetVersionWithStateVariant2, TResult>? rulesetVersionWithStateVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRulesetVersion && rulesetVersion != null)
            {
                return rulesetVersion(RulesetVersion!);
            }
            else if (IsRulesetVersionWithStateVariant2 && rulesetVersionWithStateVariant2 != null)
            {
                return rulesetVersionWithStateVariant2(RulesetVersionWithStateVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.GitHub.RulesetVersion>? rulesetVersion = null,

            global::System.Action<global::tryAGI.GitHub.RulesetVersionWithStateVariant2>? rulesetVersionWithStateVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRulesetVersion)
            {
                rulesetVersion?.Invoke(RulesetVersion!);
            }
            else if (IsRulesetVersionWithStateVariant2)
            {
                rulesetVersionWithStateVariant2?.Invoke(RulesetVersionWithStateVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.GitHub.RulesetVersion>? rulesetVersion = null,
            global::System.Action<global::tryAGI.GitHub.RulesetVersionWithStateVariant2>? rulesetVersionWithStateVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRulesetVersion)
            {
                rulesetVersion?.Invoke(RulesetVersion!);
            }
            else if (IsRulesetVersionWithStateVariant2)
            {
                rulesetVersionWithStateVariant2?.Invoke(RulesetVersionWithStateVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RulesetVersion,
                typeof(global::tryAGI.GitHub.RulesetVersion),
                RulesetVersionWithStateVariant2,
                typeof(global::tryAGI.GitHub.RulesetVersionWithStateVariant2),
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
        public bool Equals(RulesetVersionWithState other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RulesetVersion?>.Default.Equals(RulesetVersion, other.RulesetVersion) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.RulesetVersionWithStateVariant2?>.Default.Equals(RulesetVersionWithStateVariant2, other.RulesetVersionWithStateVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RulesetVersionWithState obj1, RulesetVersionWithState obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RulesetVersionWithState>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RulesetVersionWithState obj1, RulesetVersionWithState obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RulesetVersionWithState o && Equals(o);
        }
    }
}
