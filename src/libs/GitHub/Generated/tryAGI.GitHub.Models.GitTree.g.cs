
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The hierarchy between files in a Git repository.
    /// </summary>
    public sealed partial class GitTree
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Truncated { get; set; }

        /// <summary>
        /// Objects specifying a tree structure<br/>
        /// Example: [{"path":"file.rb","mode":"100644","type":"blob","size":30,"sha":"44b4fc6d56897b048c772eb4087f854f46256132","url":"https://api.github.com/repos/octocat/Hello-World/git/blobs/44b4fc6d56897b048c772eb4087f854f46256132"}]
        /// </summary>
        /// <example>[{"path":"file.rb","mode":"100644","type":"blob","size":30,"sha":"44b4fc6d56897b048c772eb4087f854f46256132","url":"https://api.github.com/repos/octocat/Hello-World/git/blobs/44b4fc6d56897b048c772eb4087f854f46256132"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tree")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.GitTreeTreeItem> Tree { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitTree" /> class.
        /// </summary>
        /// <param name="sha"></param>
        /// <param name="truncated"></param>
        /// <param name="tree">
        /// Objects specifying a tree structure<br/>
        /// Example: [{"path":"file.rb","mode":"100644","type":"blob","size":30,"sha":"44b4fc6d56897b048c772eb4087f854f46256132","url":"https://api.github.com/repos/octocat/Hello-World/git/blobs/44b4fc6d56897b048c772eb4087f854f46256132"}]
        /// </param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GitTree(
            string sha,
            bool truncated,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.GitTreeTreeItem> tree,
            string? url)
        {
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Url = url;
            this.Truncated = truncated;
            this.Tree = tree ?? throw new global::System.ArgumentNullException(nameof(tree));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitTree" /> class.
        /// </summary>
        public GitTree()
        {
        }

    }
}