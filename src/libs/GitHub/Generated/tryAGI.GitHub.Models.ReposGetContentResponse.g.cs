#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ReposGetContentResponse : global::System.IEquatable<ReposGetContentResponse>
    {
        /// <summary>
        /// A list of directory items
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.ContentDirectoryItem>? ContentDirectory { get; init; }
#else
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.ContentDirectoryItem>? ContentDirectory { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentDirectory))]
#endif
        public bool IsContentDirectory => ContentDirectory != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContentDirectory(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::tryAGI.GitHub.ContentDirectoryItem>? value)
        {
            value = ContentDirectory;
            return IsContentDirectory;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.ContentDirectoryItem> PickContentDirectory() => IsContentDirectory
            ? ContentDirectory!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentDirectory' but the value was {ToString()}.");

        /// <summary>
        /// Content File
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.ContentFile? File { get; init; }
#else
        public global::tryAGI.GitHub.ContentFile? File { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.ContentFile? value)
        {
            value = File;
            return IsFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.ContentFile PickFile() => IsFile
            ? File!
            : throw new global::System.InvalidOperationException($"Expected union variant 'File' but the value was {ToString()}.");

        /// <summary>
        /// An object describing a symlink
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.ContentSymlink? Symlink { get; init; }
#else
        public global::tryAGI.GitHub.ContentSymlink? Symlink { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Symlink))]
#endif
        public bool IsSymlink => Symlink != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSymlink(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.ContentSymlink? value)
        {
            value = Symlink;
            return IsSymlink;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.ContentSymlink PickSymlink() => IsSymlink
            ? Symlink!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Symlink' but the value was {ToString()}.");

        /// <summary>
        /// An object describing a submodule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.GitHub.ContentSubmodule? Submodule { get; init; }
#else
        public global::tryAGI.GitHub.ContentSubmodule? Submodule { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Submodule))]
#endif
        public bool IsSubmodule => Submodule != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubmodule(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.GitHub.ContentSubmodule? value)
        {
            value = Submodule;
            return IsSubmodule;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.GitHub.ContentSubmodule PickSubmodule() => IsSubmodule
            ? Submodule!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Submodule' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ReposGetContentResponse(global::tryAGI.GitHub.ContentFile value) => new ReposGetContentResponse((global::tryAGI.GitHub.ContentFile?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.ContentFile?(ReposGetContentResponse @this) => @this.File;

        /// <summary>
        ///
        /// </summary>
        public ReposGetContentResponse(global::tryAGI.GitHub.ContentFile? value)
        {
            File = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ReposGetContentResponse FromFile(global::tryAGI.GitHub.ContentFile? value) => new ReposGetContentResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ReposGetContentResponse(global::tryAGI.GitHub.ContentSymlink value) => new ReposGetContentResponse((global::tryAGI.GitHub.ContentSymlink?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.ContentSymlink?(ReposGetContentResponse @this) => @this.Symlink;

        /// <summary>
        ///
        /// </summary>
        public ReposGetContentResponse(global::tryAGI.GitHub.ContentSymlink? value)
        {
            Symlink = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ReposGetContentResponse FromSymlink(global::tryAGI.GitHub.ContentSymlink? value) => new ReposGetContentResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ReposGetContentResponse(global::tryAGI.GitHub.ContentSubmodule value) => new ReposGetContentResponse((global::tryAGI.GitHub.ContentSubmodule?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.GitHub.ContentSubmodule?(ReposGetContentResponse @this) => @this.Submodule;

        /// <summary>
        ///
        /// </summary>
        public ReposGetContentResponse(global::tryAGI.GitHub.ContentSubmodule? value)
        {
            Submodule = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ReposGetContentResponse FromSubmodule(global::tryAGI.GitHub.ContentSubmodule? value) => new ReposGetContentResponse(value);

        /// <summary>
        ///
        /// </summary>
        public ReposGetContentResponse(
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.ContentDirectoryItem>? contentDirectory,
            global::tryAGI.GitHub.ContentFile? file,
            global::tryAGI.GitHub.ContentSymlink? symlink,
            global::tryAGI.GitHub.ContentSubmodule? submodule
            )
        {
            ContentDirectory = contentDirectory;
            File = file;
            Symlink = symlink;
            Submodule = submodule;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Submodule as object ??
            Symlink as object ??
            File as object ??
            ContentDirectory as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ContentDirectory?.ToString() ??
            File?.ToString() ??
            Symlink?.ToString() ??
            Submodule?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsContentDirectory && !IsFile && !IsSymlink && !IsSubmodule || !IsContentDirectory && IsFile && !IsSymlink && !IsSubmodule || !IsContentDirectory && !IsFile && IsSymlink && !IsSubmodule || !IsContentDirectory && !IsFile && !IsSymlink && IsSubmodule;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::tryAGI.GitHub.ContentDirectoryItem>, TResult>? contentDirectory = null,
            global::System.Func<global::tryAGI.GitHub.ContentFile, TResult>? file = null,
            global::System.Func<global::tryAGI.GitHub.ContentSymlink, TResult>? symlink = null,
            global::System.Func<global::tryAGI.GitHub.ContentSubmodule, TResult>? submodule = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsContentDirectory && contentDirectory != null)
            {
                return contentDirectory(ContentDirectory!);
            }
            else if (IsFile && file != null)
            {
                return file(File!);
            }
            else if (IsSymlink && symlink != null)
            {
                return symlink(Symlink!);
            }
            else if (IsSubmodule && submodule != null)
            {
                return submodule(Submodule!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.GitHub.ContentDirectoryItem>>? contentDirectory = null,

            global::System.Action<global::tryAGI.GitHub.ContentFile>? file = null,

            global::System.Action<global::tryAGI.GitHub.ContentSymlink>? symlink = null,

            global::System.Action<global::tryAGI.GitHub.ContentSubmodule>? submodule = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsContentDirectory)
            {
                contentDirectory?.Invoke(ContentDirectory!);
            }
            else if (IsFile)
            {
                file?.Invoke(File!);
            }
            else if (IsSymlink)
            {
                symlink?.Invoke(Symlink!);
            }
            else if (IsSubmodule)
            {
                submodule?.Invoke(Submodule!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::tryAGI.GitHub.ContentDirectoryItem>>? contentDirectory = null,
            global::System.Action<global::tryAGI.GitHub.ContentFile>? file = null,
            global::System.Action<global::tryAGI.GitHub.ContentSymlink>? symlink = null,
            global::System.Action<global::tryAGI.GitHub.ContentSubmodule>? submodule = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsContentDirectory)
            {
                contentDirectory?.Invoke(ContentDirectory!);
            }
            else if (IsFile)
            {
                file?.Invoke(File!);
            }
            else if (IsSymlink)
            {
                symlink?.Invoke(Symlink!);
            }
            else if (IsSubmodule)
            {
                submodule?.Invoke(Submodule!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ContentDirectory,
                typeof(global::System.Collections.Generic.IList<global::tryAGI.GitHub.ContentDirectoryItem>),
                File,
                typeof(global::tryAGI.GitHub.ContentFile),
                Symlink,
                typeof(global::tryAGI.GitHub.ContentSymlink),
                Submodule,
                typeof(global::tryAGI.GitHub.ContentSubmodule),
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
        public bool Equals(ReposGetContentResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::tryAGI.GitHub.ContentDirectoryItem>?>.Default.Equals(ContentDirectory, other.ContentDirectory) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.ContentFile?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.ContentSymlink?>.Default.Equals(Symlink, other.Symlink) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.GitHub.ContentSubmodule?>.Default.Equals(Submodule, other.Submodule)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ReposGetContentResponse obj1, ReposGetContentResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReposGetContentResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ReposGetContentResponse obj1, ReposGetContentResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReposGetContentResponse o && Equals(o);
        }
    }
}
