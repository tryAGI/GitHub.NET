#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PullRequestWebhook : global::System.IEquatable<PullRequestWebhook>
    {
        /// <summary>
        /// Pull requests let you tell others about changes you've pushed to a repository on GitHub. Once a pull request is sent, interested parties can review the set of changes, discuss potential modifications, and even push follow-up commits if necessary.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.PullRequest? PullRequest { get; init; }
#else
        public global::tryAGI.GitHub.PullRequest? PullRequest { get; }
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
            out global::tryAGI.GitHub.PullRequest? value)
        {
            value = PullRequest;
            return IsPullRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.PullRequest PickPullRequest() => IsPullRequest
            ? PullRequest!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PullRequest' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.PullRequestWebhookVariant2? PullRequestWebhookVariant2 { get; init; }
#else
        public global::tryAGI.GitHub.PullRequestWebhookVariant2? PullRequestWebhookVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PullRequestWebhookVariant2))]
#endif
        public bool IsPullRequestWebhookVariant2 => PullRequestWebhookVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPullRequestWebhookVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.PullRequestWebhookVariant2? value)
        {
            value = PullRequestWebhookVariant2;
            return IsPullRequestWebhookVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.PullRequestWebhookVariant2 PickPullRequestWebhookVariant2() => IsPullRequestWebhookVariant2
            ? PullRequestWebhookVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PullRequestWebhookVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PullRequestWebhook(global::tryAGI.GitHub.PullRequest value) => new PullRequestWebhook((global::tryAGI.GitHub.PullRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.PullRequest?(PullRequestWebhook @this) => @this.PullRequest;

        /// <summary>
        ///
        /// </summary>
        public PullRequestWebhook(global::tryAGI.GitHub.PullRequest? value)
        {
            PullRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PullRequestWebhook FromPullRequest(global::tryAGI.GitHub.PullRequest? value) => new PullRequestWebhook(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PullRequestWebhook(global::tryAGI.GitHub.PullRequestWebhookVariant2 value) => new PullRequestWebhook((global::tryAGI.GitHub.PullRequestWebhookVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.PullRequestWebhookVariant2?(PullRequestWebhook @this) => @this.PullRequestWebhookVariant2;

        /// <summary>
        ///
        /// </summary>
        public PullRequestWebhook(global::tryAGI.GitHub.PullRequestWebhookVariant2? value)
        {
            PullRequestWebhookVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PullRequestWebhook FromPullRequestWebhookVariant2(global::tryAGI.GitHub.PullRequestWebhookVariant2? value) => new PullRequestWebhook(value);

        /// <summary>
        ///
        /// </summary>
        public PullRequestWebhook(
            global::tryAGI.GitHub.PullRequest? pullRequest,
            global::tryAGI.GitHub.PullRequestWebhookVariant2? pullRequestWebhookVariant2
            )
        {
            PullRequest = pullRequest;
            PullRequestWebhookVariant2 = pullRequestWebhookVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PullRequestWebhookVariant2 as object ??
            PullRequest as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PullRequest?.ToString() ??
            PullRequestWebhookVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPullRequest && IsPullRequestWebhookVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.GitHub.PullRequest, TResult>? pullRequest = null,
            global::System.Func<global::tryAGI.GitHub.PullRequestWebhookVariant2, TResult>? pullRequestWebhookVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPullRequest && pullRequest != null)
            {
                return pullRequest(PullRequest!);
            }
            else if (IsPullRequestWebhookVariant2 && pullRequestWebhookVariant2 != null)
            {
                return pullRequestWebhookVariant2(PullRequestWebhookVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.GitHub.PullRequest>? pullRequest = null,

            global::System.Action<global::tryAGI.GitHub.PullRequestWebhookVariant2>? pullRequestWebhookVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPullRequest)
            {
                pullRequest?.Invoke(PullRequest!);
            }
            else if (IsPullRequestWebhookVariant2)
            {
                pullRequestWebhookVariant2?.Invoke(PullRequestWebhookVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.GitHub.PullRequest>? pullRequest = null,
            global::System.Action<global::tryAGI.GitHub.PullRequestWebhookVariant2>? pullRequestWebhookVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPullRequest)
            {
                pullRequest?.Invoke(PullRequest!);
            }
            else if (IsPullRequestWebhookVariant2)
            {
                pullRequestWebhookVariant2?.Invoke(PullRequestWebhookVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PullRequest,
                typeof(global::tryAGI.GitHub.PullRequest),
                PullRequestWebhookVariant2,
                typeof(global::tryAGI.GitHub.PullRequestWebhookVariant2),
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
        public bool Equals(PullRequestWebhook other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.PullRequest?>.Default.Equals(PullRequest, other.PullRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.PullRequestWebhookVariant2?>.Default.Equals(PullRequestWebhookVariant2, other.PullRequestWebhookVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PullRequestWebhook obj1, PullRequestWebhook obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PullRequestWebhook>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PullRequestWebhook obj1, PullRequestWebhook obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PullRequestWebhook o && Equals(o);
        }
    }
}
