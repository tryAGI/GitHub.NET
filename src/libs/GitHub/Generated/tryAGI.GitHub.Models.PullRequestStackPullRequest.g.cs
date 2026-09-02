#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PullRequestStackPullRequest : global::System.IEquatable<PullRequestStackPullRequest>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.PullRequestMinimal? PullRequestMinimal { get; init; }
#else
        public global::tryAGI.GitHub.PullRequestMinimal? PullRequestMinimal { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PullRequestMinimal))]
#endif
        public bool IsPullRequestMinimal => PullRequestMinimal != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPullRequestMinimal(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.PullRequestMinimal? value)
        {
            value = PullRequestMinimal;
            return IsPullRequestMinimal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.PullRequestMinimal PickPullRequestMinimal() => IsPullRequestMinimal
            ? PullRequestMinimal!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PullRequestMinimal' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.PullRequestStackPullRequestVariant2? PullRequestStackPullRequestVariant2 { get; init; }
#else
        public global::tryAGI.GitHub.PullRequestStackPullRequestVariant2? PullRequestStackPullRequestVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PullRequestStackPullRequestVariant2))]
#endif
        public bool IsPullRequestStackPullRequestVariant2 => PullRequestStackPullRequestVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPullRequestStackPullRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.PullRequestStackPullRequestVariant2? value)
        {
            value = PullRequestStackPullRequestVariant2;
            return IsPullRequestStackPullRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.PullRequestStackPullRequestVariant2 PickPullRequestStackPullRequestVariant2() => IsPullRequestStackPullRequestVariant2
            ? PullRequestStackPullRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PullRequestStackPullRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PullRequestStackPullRequest(global::tryAGI.GitHub.PullRequestMinimal value) => new PullRequestStackPullRequest((global::tryAGI.GitHub.PullRequestMinimal?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.PullRequestMinimal?(PullRequestStackPullRequest @this) => @this.PullRequestMinimal;

        /// <summary>
        ///
        /// </summary>
        public PullRequestStackPullRequest(global::tryAGI.GitHub.PullRequestMinimal? value)
        {
            PullRequestMinimal = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PullRequestStackPullRequest FromPullRequestMinimal(global::tryAGI.GitHub.PullRequestMinimal? value) => new PullRequestStackPullRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PullRequestStackPullRequest(global::tryAGI.GitHub.PullRequestStackPullRequestVariant2 value) => new PullRequestStackPullRequest((global::tryAGI.GitHub.PullRequestStackPullRequestVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.PullRequestStackPullRequestVariant2?(PullRequestStackPullRequest @this) => @this.PullRequestStackPullRequestVariant2;

        /// <summary>
        ///
        /// </summary>
        public PullRequestStackPullRequest(global::tryAGI.GitHub.PullRequestStackPullRequestVariant2? value)
        {
            PullRequestStackPullRequestVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PullRequestStackPullRequest FromPullRequestStackPullRequestVariant2(global::tryAGI.GitHub.PullRequestStackPullRequestVariant2? value) => new PullRequestStackPullRequest(value);

        /// <summary>
        ///
        /// </summary>
        public PullRequestStackPullRequest(
            global::tryAGI.GitHub.PullRequestMinimal? pullRequestMinimal,
            global::tryAGI.GitHub.PullRequestStackPullRequestVariant2? pullRequestStackPullRequestVariant2
            )
        {
            PullRequestMinimal = pullRequestMinimal;
            PullRequestStackPullRequestVariant2 = pullRequestStackPullRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PullRequestStackPullRequestVariant2 as object ??
            PullRequestMinimal as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PullRequestMinimal?.ToString() ??
            PullRequestStackPullRequestVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPullRequestMinimal && IsPullRequestStackPullRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.GitHub.PullRequestMinimal, TResult>? pullRequestMinimal = null,
            global::System.Func<global::tryAGI.GitHub.PullRequestStackPullRequestVariant2, TResult>? pullRequestStackPullRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPullRequestMinimal && pullRequestMinimal != null)
            {
                return pullRequestMinimal(PullRequestMinimal!);
            }
            else if (IsPullRequestStackPullRequestVariant2 && pullRequestStackPullRequestVariant2 != null)
            {
                return pullRequestStackPullRequestVariant2(PullRequestStackPullRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.GitHub.PullRequestMinimal>? pullRequestMinimal = null,

            global::System.Action<global::tryAGI.GitHub.PullRequestStackPullRequestVariant2>? pullRequestStackPullRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPullRequestMinimal)
            {
                pullRequestMinimal?.Invoke(PullRequestMinimal!);
            }
            else if (IsPullRequestStackPullRequestVariant2)
            {
                pullRequestStackPullRequestVariant2?.Invoke(PullRequestStackPullRequestVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.GitHub.PullRequestMinimal>? pullRequestMinimal = null,
            global::System.Action<global::tryAGI.GitHub.PullRequestStackPullRequestVariant2>? pullRequestStackPullRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPullRequestMinimal)
            {
                pullRequestMinimal?.Invoke(PullRequestMinimal!);
            }
            else if (IsPullRequestStackPullRequestVariant2)
            {
                pullRequestStackPullRequestVariant2?.Invoke(PullRequestStackPullRequestVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PullRequestMinimal,
                typeof(global::tryAGI.GitHub.PullRequestMinimal),
                PullRequestStackPullRequestVariant2,
                typeof(global::tryAGI.GitHub.PullRequestStackPullRequestVariant2),
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
        public bool Equals(PullRequestStackPullRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.PullRequestMinimal?>.Default.Equals(PullRequestMinimal, other.PullRequestMinimal) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.PullRequestStackPullRequestVariant2?>.Default.Equals(PullRequestStackPullRequestVariant2, other.PullRequestStackPullRequestVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PullRequestStackPullRequest obj1, PullRequestStackPullRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PullRequestStackPullRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PullRequestStackPullRequest obj1, PullRequestStackPullRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PullRequestStackPullRequest o && Equals(o);
        }
    }
}
