#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct WebhookPullRequestReviewRequested : global::System.IEquatable<WebhookPullRequestReviewRequested>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant1? WebhookPullRequestReviewRequestedVariant1 { get; init; }
#else
        public global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant1? WebhookPullRequestReviewRequestedVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookPullRequestReviewRequestedVariant1))]
#endif
        public bool IsWebhookPullRequestReviewRequestedVariant1 => WebhookPullRequestReviewRequestedVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebhookPullRequestReviewRequestedVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant1? value)
        {
            value = WebhookPullRequestReviewRequestedVariant1;
            return IsWebhookPullRequestReviewRequestedVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant1 PickWebhookPullRequestReviewRequestedVariant1() => IsWebhookPullRequestReviewRequestedVariant1
            ? WebhookPullRequestReviewRequestedVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebhookPullRequestReviewRequestedVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant2? WebhookPullRequestReviewRequestedVariant2 { get; init; }
#else
        public global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant2? WebhookPullRequestReviewRequestedVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookPullRequestReviewRequestedVariant2))]
#endif
        public bool IsWebhookPullRequestReviewRequestedVariant2 => WebhookPullRequestReviewRequestedVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebhookPullRequestReviewRequestedVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant2? value)
        {
            value = WebhookPullRequestReviewRequestedVariant2;
            return IsWebhookPullRequestReviewRequestedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant2 PickWebhookPullRequestReviewRequestedVariant2() => IsWebhookPullRequestReviewRequestedVariant2
            ? WebhookPullRequestReviewRequestedVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebhookPullRequestReviewRequestedVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookPullRequestReviewRequested(global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant1 value) => new WebhookPullRequestReviewRequested((global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant1?(WebhookPullRequestReviewRequested @this) => @this.WebhookPullRequestReviewRequestedVariant1;

        /// <summary>
        ///
        /// </summary>
        public WebhookPullRequestReviewRequested(global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant1? value)
        {
            WebhookPullRequestReviewRequestedVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookPullRequestReviewRequested FromWebhookPullRequestReviewRequestedVariant1(global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant1? value) => new WebhookPullRequestReviewRequested(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WebhookPullRequestReviewRequested(global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant2 value) => new WebhookPullRequestReviewRequested((global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant2?(WebhookPullRequestReviewRequested @this) => @this.WebhookPullRequestReviewRequestedVariant2;

        /// <summary>
        ///
        /// </summary>
        public WebhookPullRequestReviewRequested(global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant2? value)
        {
            WebhookPullRequestReviewRequestedVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WebhookPullRequestReviewRequested FromWebhookPullRequestReviewRequestedVariant2(global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant2? value) => new WebhookPullRequestReviewRequested(value);

        /// <summary>
        ///
        /// </summary>
        public WebhookPullRequestReviewRequested(
            global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant1? webhookPullRequestReviewRequestedVariant1,
            global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant2? webhookPullRequestReviewRequestedVariant2
            )
        {
            WebhookPullRequestReviewRequestedVariant1 = webhookPullRequestReviewRequestedVariant1;
            WebhookPullRequestReviewRequestedVariant2 = webhookPullRequestReviewRequestedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebhookPullRequestReviewRequestedVariant2 as object ??
            WebhookPullRequestReviewRequestedVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            WebhookPullRequestReviewRequestedVariant1?.ToString() ??
            WebhookPullRequestReviewRequestedVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsWebhookPullRequestReviewRequestedVariant1 && !IsWebhookPullRequestReviewRequestedVariant2 || !IsWebhookPullRequestReviewRequestedVariant1 && IsWebhookPullRequestReviewRequestedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant1, TResult>? webhookPullRequestReviewRequestedVariant1 = null,
            global::System.Func<global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant2, TResult>? webhookPullRequestReviewRequestedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookPullRequestReviewRequestedVariant1 && webhookPullRequestReviewRequestedVariant1 != null)
            {
                return webhookPullRequestReviewRequestedVariant1(WebhookPullRequestReviewRequestedVariant1!);
            }
            else if (IsWebhookPullRequestReviewRequestedVariant2 && webhookPullRequestReviewRequestedVariant2 != null)
            {
                return webhookPullRequestReviewRequestedVariant2(WebhookPullRequestReviewRequestedVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant1>? webhookPullRequestReviewRequestedVariant1 = null,

            global::System.Action<global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant2>? webhookPullRequestReviewRequestedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookPullRequestReviewRequestedVariant1)
            {
                webhookPullRequestReviewRequestedVariant1?.Invoke(WebhookPullRequestReviewRequestedVariant1!);
            }
            else if (IsWebhookPullRequestReviewRequestedVariant2)
            {
                webhookPullRequestReviewRequestedVariant2?.Invoke(WebhookPullRequestReviewRequestedVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant1>? webhookPullRequestReviewRequestedVariant1 = null,
            global::System.Action<global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant2>? webhookPullRequestReviewRequestedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookPullRequestReviewRequestedVariant1)
            {
                webhookPullRequestReviewRequestedVariant1?.Invoke(WebhookPullRequestReviewRequestedVariant1!);
            }
            else if (IsWebhookPullRequestReviewRequestedVariant2)
            {
                webhookPullRequestReviewRequestedVariant2?.Invoke(WebhookPullRequestReviewRequestedVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WebhookPullRequestReviewRequestedVariant1,
                typeof(global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant1),
                WebhookPullRequestReviewRequestedVariant2,
                typeof(global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant2),
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
        public bool Equals(WebhookPullRequestReviewRequested other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant1?>.Default.Equals(WebhookPullRequestReviewRequestedVariant1, other.WebhookPullRequestReviewRequestedVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.WebhookPullRequestReviewRequestedVariant2?>.Default.Equals(WebhookPullRequestReviewRequestedVariant2, other.WebhookPullRequestReviewRequestedVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WebhookPullRequestReviewRequested obj1, WebhookPullRequestReviewRequested obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebhookPullRequestReviewRequested>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebhookPullRequestReviewRequested obj1, WebhookPullRequestReviewRequested obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookPullRequestReviewRequested o && Equals(o);
        }
    }
}
