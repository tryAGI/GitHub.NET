#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A collaborator (user or team) of a Copilot Space
    /// </summary>
    public readonly partial struct CopilotSpaceCollaborator : global::System.IEquatable<CopilotSpaceCollaborator>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant12>? CopilotSpaceCollaboratorVariant1 { get; init; }
#else
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant12>? CopilotSpaceCollaboratorVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CopilotSpaceCollaboratorVariant1))]
#endif
        public bool IsCopilotSpaceCollaboratorVariant1 => CopilotSpaceCollaboratorVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCopilotSpaceCollaboratorVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant12>? value)
        {
            value = CopilotSpaceCollaboratorVariant1;
            return IsCopilotSpaceCollaboratorVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant12> PickCopilotSpaceCollaboratorVariant1() => IsCopilotSpaceCollaboratorVariant1
            ? CopilotSpaceCollaboratorVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CopilotSpaceCollaboratorVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant2? CopilotSpaceCollaboratorVariant2 { get; init; }
#else
        public global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant2? CopilotSpaceCollaboratorVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CopilotSpaceCollaboratorVariant2))]
#endif
        public bool IsCopilotSpaceCollaboratorVariant2 => CopilotSpaceCollaboratorVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCopilotSpaceCollaboratorVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant2? value)
        {
            value = CopilotSpaceCollaboratorVariant2;
            return IsCopilotSpaceCollaboratorVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant2 PickCopilotSpaceCollaboratorVariant2() => IsCopilotSpaceCollaboratorVariant2
            ? CopilotSpaceCollaboratorVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CopilotSpaceCollaboratorVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CopilotSpaceCollaborator(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant12> value) => new CopilotSpaceCollaborator((global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant12>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant12>?(CopilotSpaceCollaborator @this) => @this.CopilotSpaceCollaboratorVariant1;

        /// <summary>
        ///
        /// </summary>
        public CopilotSpaceCollaborator(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant12>? value)
        {
            CopilotSpaceCollaboratorVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CopilotSpaceCollaborator FromCopilotSpaceCollaboratorVariant1(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant12>? value) => new CopilotSpaceCollaborator(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CopilotSpaceCollaborator(global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant2 value) => new CopilotSpaceCollaborator((global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant2?(CopilotSpaceCollaborator @this) => @this.CopilotSpaceCollaboratorVariant2;

        /// <summary>
        ///
        /// </summary>
        public CopilotSpaceCollaborator(global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant2? value)
        {
            CopilotSpaceCollaboratorVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CopilotSpaceCollaborator FromCopilotSpaceCollaboratorVariant2(global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant2? value) => new CopilotSpaceCollaborator(value);

        /// <summary>
        ///
        /// </summary>
        public CopilotSpaceCollaborator(
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant12>? copilotSpaceCollaboratorVariant1,
            global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant2? copilotSpaceCollaboratorVariant2
            )
        {
            CopilotSpaceCollaboratorVariant1 = copilotSpaceCollaboratorVariant1;
            CopilotSpaceCollaboratorVariant2 = copilotSpaceCollaboratorVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CopilotSpaceCollaboratorVariant2 as object ??
            CopilotSpaceCollaboratorVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CopilotSpaceCollaboratorVariant1?.ToString() ??
            CopilotSpaceCollaboratorVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCopilotSpaceCollaboratorVariant1 || IsCopilotSpaceCollaboratorVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant12>?, TResult>? copilotSpaceCollaboratorVariant1 = null,
            global::System.Func<global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant2, TResult>? copilotSpaceCollaboratorVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCopilotSpaceCollaboratorVariant1 && copilotSpaceCollaboratorVariant1 != null)
            {
                return copilotSpaceCollaboratorVariant1(CopilotSpaceCollaboratorVariant1!);
            }
            else if (IsCopilotSpaceCollaboratorVariant2 && copilotSpaceCollaboratorVariant2 != null)
            {
                return copilotSpaceCollaboratorVariant2(CopilotSpaceCollaboratorVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant12>?>? copilotSpaceCollaboratorVariant1 = null,

            global::System.Action<global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant2>? copilotSpaceCollaboratorVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCopilotSpaceCollaboratorVariant1)
            {
                copilotSpaceCollaboratorVariant1?.Invoke(CopilotSpaceCollaboratorVariant1!);
            }
            else if (IsCopilotSpaceCollaboratorVariant2)
            {
                copilotSpaceCollaboratorVariant2?.Invoke(CopilotSpaceCollaboratorVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant12>?>? copilotSpaceCollaboratorVariant1 = null,
            global::System.Action<global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant2>? copilotSpaceCollaboratorVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCopilotSpaceCollaboratorVariant1)
            {
                copilotSpaceCollaboratorVariant1?.Invoke(CopilotSpaceCollaboratorVariant1!);
            }
            else if (IsCopilotSpaceCollaboratorVariant2)
            {
                copilotSpaceCollaboratorVariant2?.Invoke(CopilotSpaceCollaboratorVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CopilotSpaceCollaboratorVariant1,
                typeof(global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant12>),
                CopilotSpaceCollaboratorVariant2,
                typeof(global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant2),
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
        public bool Equals(CopilotSpaceCollaborator other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant12>?>.Default.Equals(CopilotSpaceCollaboratorVariant1, other.CopilotSpaceCollaboratorVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant2?>.Default.Equals(CopilotSpaceCollaboratorVariant2, other.CopilotSpaceCollaboratorVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CopilotSpaceCollaborator obj1, CopilotSpaceCollaborator obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CopilotSpaceCollaborator>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CopilotSpaceCollaborator obj1, CopilotSpaceCollaborator obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CopilotSpaceCollaborator o && Equals(o);
        }
    }
}
