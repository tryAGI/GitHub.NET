#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IReactionsClient
    {
        /// <summary>
        /// Delete a commit comment reaction<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; You can also specify a repository by `repository_id` using the route `DELETE /repositories/:repository_id/comments/:comment_id/reactions/:reaction_id`.<br/>
        /// Delete a reaction to a [commit comment](https://docs.github.com/rest/commits/comments#get-a-commit-comment).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commentId"></param>
        /// <param name="reactionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ReactionsDeleteForCommitCommentAsync(
            string owner,
            string repo,
            long commentId,
            int reactionId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a commit comment reaction<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; You can also specify a repository by `repository_id` using the route `DELETE /repositories/:repository_id/comments/:comment_id/reactions/:reaction_id`.<br/>
        /// Delete a reaction to a [commit comment](https://docs.github.com/rest/commits/comments#get-a-commit-comment).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commentId"></param>
        /// <param name="reactionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> ReactionsDeleteForCommitCommentAsResponseAsync(
            string owner,
            string repo,
            long commentId,
            int reactionId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}