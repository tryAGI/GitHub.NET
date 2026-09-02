#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Conditions for an organization ruleset.<br/>
    /// The branch and tag rulesets conditions object should contain both `repository_name` and `ref_name` properties, or both `repository_id` and `ref_name` properties, or both `repository_property` and `ref_name` properties.<br/>
    /// The push rulesets conditions object does not require the `ref_name` property.<br/>
    /// For repository policy rulesets, the conditions object should only contain the `repository_name`, the `repository_id`, or the `repository_property`.
    /// </summary>
    public readonly partial struct OrgRulesetConditions : global::System.IEquatable<OrgRulesetConditions>
    {
        /// <summary>
        /// Conditions to target repositories by name and refs by name
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>? RepositoryNameAndRefName { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>? RepositoryNameAndRefName { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryNameAndRefName))]
#endif
        public bool IsRepositoryNameAndRefName => RepositoryNameAndRefName != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryNameAndRefName(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>? value)
        {
            value = RepositoryNameAndRefName;
            return IsRepositoryNameAndRefName;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget> PickRepositoryNameAndRefName() => IsRepositoryNameAndRefName
            ? RepositoryNameAndRefName!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryNameAndRefName' but the value was {ToString()}.");

        /// <summary>
        /// Conditions to target repositories by id and refs by name
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>? RepositoryIdAndRefName { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>? RepositoryIdAndRefName { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryIdAndRefName))]
#endif
        public bool IsRepositoryIdAndRefName => RepositoryIdAndRefName != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryIdAndRefName(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>? value)
        {
            value = RepositoryIdAndRefName;
            return IsRepositoryIdAndRefName;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget> PickRepositoryIdAndRefName() => IsRepositoryIdAndRefName
            ? RepositoryIdAndRefName!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryIdAndRefName' but the value was {ToString()}.");

        /// <summary>
        /// Conditions to target repositories by property and refs by name
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>? RepositoryPropertyAndRefName { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>? RepositoryPropertyAndRefName { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryPropertyAndRefName))]
#endif
        public bool IsRepositoryPropertyAndRefName => RepositoryPropertyAndRefName != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryPropertyAndRefName(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>? value)
        {
            value = RepositoryPropertyAndRefName;
            return IsRepositoryPropertyAndRefName;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget> PickRepositoryPropertyAndRefName() => IsRepositoryPropertyAndRefName
            ? RepositoryPropertyAndRefName!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryPropertyAndRefName' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRulesetConditions(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget> value) => new OrgRulesetConditions((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>?(OrgRulesetConditions @this) => @this.RepositoryNameAndRefName;

        /// <summary>
        ///
        /// </summary>
        public OrgRulesetConditions(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>? value)
        {
            RepositoryNameAndRefName = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRulesetConditions FromRepositoryNameAndRefName(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>? value) => new OrgRulesetConditions(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRulesetConditions(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget> value) => new OrgRulesetConditions((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>?(OrgRulesetConditions @this) => @this.RepositoryIdAndRefName;

        /// <summary>
        ///
        /// </summary>
        public OrgRulesetConditions(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>? value)
        {
            RepositoryIdAndRefName = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRulesetConditions FromRepositoryIdAndRefName(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>? value) => new OrgRulesetConditions(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OrgRulesetConditions(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget> value) => new OrgRulesetConditions((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>?(OrgRulesetConditions @this) => @this.RepositoryPropertyAndRefName;

        /// <summary>
        ///
        /// </summary>
        public OrgRulesetConditions(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>? value)
        {
            RepositoryPropertyAndRefName = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OrgRulesetConditions FromRepositoryPropertyAndRefName(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>? value) => new OrgRulesetConditions(value);

        /// <summary>
        ///
        /// </summary>
        public OrgRulesetConditions(
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>? repositoryNameAndRefName,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>? repositoryIdAndRefName,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>? repositoryPropertyAndRefName
            )
        {
            RepositoryNameAndRefName = repositoryNameAndRefName;
            RepositoryIdAndRefName = repositoryIdAndRefName;
            RepositoryPropertyAndRefName = repositoryPropertyAndRefName;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RepositoryPropertyAndRefName as object ??
            RepositoryIdAndRefName as object ??
            RepositoryNameAndRefName as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RepositoryNameAndRefName?.ToString() ??
            RepositoryIdAndRefName?.ToString() ??
            RepositoryPropertyAndRefName?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRepositoryNameAndRefName && !IsRepositoryIdAndRefName && !IsRepositoryPropertyAndRefName || !IsRepositoryNameAndRefName && IsRepositoryIdAndRefName && !IsRepositoryPropertyAndRefName || !IsRepositoryNameAndRefName && !IsRepositoryIdAndRefName && IsRepositoryPropertyAndRefName;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>?, TResult>? repositoryNameAndRefName = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>?, TResult>? repositoryIdAndRefName = null,
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>?, TResult>? repositoryPropertyAndRefName = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRepositoryNameAndRefName && repositoryNameAndRefName != null)
            {
                return repositoryNameAndRefName(RepositoryNameAndRefName!);
            }
            else if (IsRepositoryIdAndRefName && repositoryIdAndRefName != null)
            {
                return repositoryIdAndRefName(RepositoryIdAndRefName!);
            }
            else if (IsRepositoryPropertyAndRefName && repositoryPropertyAndRefName != null)
            {
                return repositoryPropertyAndRefName(RepositoryPropertyAndRefName!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>?>? repositoryNameAndRefName = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>?>? repositoryIdAndRefName = null,

            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>?>? repositoryPropertyAndRefName = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRepositoryNameAndRefName)
            {
                repositoryNameAndRefName?.Invoke(RepositoryNameAndRefName!);
            }
            else if (IsRepositoryIdAndRefName)
            {
                repositoryIdAndRefName?.Invoke(RepositoryIdAndRefName!);
            }
            else if (IsRepositoryPropertyAndRefName)
            {
                repositoryPropertyAndRefName?.Invoke(RepositoryPropertyAndRefName!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>?>? repositoryNameAndRefName = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>?>? repositoryIdAndRefName = null,
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>?>? repositoryPropertyAndRefName = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRepositoryNameAndRefName)
            {
                repositoryNameAndRefName?.Invoke(RepositoryNameAndRefName!);
            }
            else if (IsRepositoryIdAndRefName)
            {
                repositoryIdAndRefName?.Invoke(RepositoryIdAndRefName!);
            }
            else if (IsRepositoryPropertyAndRefName)
            {
                repositoryPropertyAndRefName?.Invoke(RepositoryPropertyAndRefName!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RepositoryNameAndRefName,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>),
                RepositoryIdAndRefName,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>),
                RepositoryPropertyAndRefName,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>),
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
        public bool Equals(OrgRulesetConditions other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryNameTarget>?>.Default.Equals(RepositoryNameAndRefName, other.RepositoryNameAndRefName) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryIdTarget>?>.Default.Equals(RepositoryIdAndRefName, other.RepositoryIdAndRefName) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.RepositoryRulesetConditions, global::tryAGI.GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>?>.Default.Equals(RepositoryPropertyAndRefName, other.RepositoryPropertyAndRefName)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OrgRulesetConditions obj1, OrgRulesetConditions obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OrgRulesetConditions>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OrgRulesetConditions obj1, OrgRulesetConditions obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OrgRulesetConditions o && Equals(o);
        }
    }
}
