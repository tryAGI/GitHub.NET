#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct UsersGetAuthenticatedResponse : global::System.IEquatable<UsersGetAuthenticatedResponse>
    {
        /// <summary>
        /// Private User
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.PrivateUser? PrivateUser { get; init; }
#else
        public global::tryAGI.GitHub.PrivateUser? PrivateUser { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PrivateUser))]
#endif
        public bool IsPrivateUser => PrivateUser != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPrivateUser(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.PrivateUser? value)
        {
            value = PrivateUser;
            return IsPrivateUser;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.PrivateUser PickPrivateUser() => IsPrivateUser
            ? PrivateUser!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PrivateUser' but the value was {ToString()}.");

        /// <summary>
        /// Public User
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.PublicUser? PublicUser { get; init; }
#else
        public global::tryAGI.GitHub.PublicUser? PublicUser { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PublicUser))]
#endif
        public bool IsPublicUser => PublicUser != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPublicUser(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.PublicUser? value)
        {
            value = PublicUser;
            return IsPublicUser;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.PublicUser PickPublicUser() => IsPublicUser
            ? PublicUser!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PublicUser' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UsersGetAuthenticatedResponse(global::tryAGI.GitHub.PrivateUser value) => new UsersGetAuthenticatedResponse((global::tryAGI.GitHub.PrivateUser?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.PrivateUser?(UsersGetAuthenticatedResponse @this) => @this.PrivateUser;

        /// <summary>
        ///
        /// </summary>
        public UsersGetAuthenticatedResponse(global::tryAGI.GitHub.PrivateUser? value)
        {
            PrivateUser = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UsersGetAuthenticatedResponse FromPrivateUser(global::tryAGI.GitHub.PrivateUser? value) => new UsersGetAuthenticatedResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UsersGetAuthenticatedResponse(global::tryAGI.GitHub.PublicUser value) => new UsersGetAuthenticatedResponse((global::tryAGI.GitHub.PublicUser?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.PublicUser?(UsersGetAuthenticatedResponse @this) => @this.PublicUser;

        /// <summary>
        ///
        /// </summary>
        public UsersGetAuthenticatedResponse(global::tryAGI.GitHub.PublicUser? value)
        {
            PublicUser = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UsersGetAuthenticatedResponse FromPublicUser(global::tryAGI.GitHub.PublicUser? value) => new UsersGetAuthenticatedResponse(value);

        /// <summary>
        ///
        /// </summary>
        public UsersGetAuthenticatedResponse(
            global::tryAGI.GitHub.PrivateUser? privateUser,
            global::tryAGI.GitHub.PublicUser? publicUser
            )
        {
            PrivateUser = privateUser;
            PublicUser = publicUser;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PublicUser as object ??
            PrivateUser as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PrivateUser?.ToString() ??
            PublicUser?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPrivateUser && !IsPublicUser || !IsPrivateUser && IsPublicUser;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.GitHub.PrivateUser, TResult>? privateUser = null,
            global::System.Func<global::tryAGI.GitHub.PublicUser, TResult>? publicUser = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPrivateUser && privateUser != null)
            {
                return privateUser(PrivateUser!);
            }
            else if (IsPublicUser && publicUser != null)
            {
                return publicUser(PublicUser!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.GitHub.PrivateUser>? privateUser = null,

            global::System.Action<global::tryAGI.GitHub.PublicUser>? publicUser = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPrivateUser)
            {
                privateUser?.Invoke(PrivateUser!);
            }
            else if (IsPublicUser)
            {
                publicUser?.Invoke(PublicUser!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.GitHub.PrivateUser>? privateUser = null,
            global::System.Action<global::tryAGI.GitHub.PublicUser>? publicUser = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPrivateUser)
            {
                privateUser?.Invoke(PrivateUser!);
            }
            else if (IsPublicUser)
            {
                publicUser?.Invoke(PublicUser!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PrivateUser,
                typeof(global::tryAGI.GitHub.PrivateUser),
                PublicUser,
                typeof(global::tryAGI.GitHub.PublicUser),
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
        public bool Equals(UsersGetAuthenticatedResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.PrivateUser?>.Default.Equals(PrivateUser, other.PrivateUser) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.PublicUser?>.Default.Equals(PublicUser, other.PublicUser)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UsersGetAuthenticatedResponse obj1, UsersGetAuthenticatedResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UsersGetAuthenticatedResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UsersGetAuthenticatedResponse obj1, UsersGetAuthenticatedResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UsersGetAuthenticatedResponse o && Equals(o);
        }
    }
}
