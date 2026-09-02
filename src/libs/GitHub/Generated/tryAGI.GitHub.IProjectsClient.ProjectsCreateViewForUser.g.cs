#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create a view for a user-owned project<br/>
        /// Create a new view in a user-owned project. Views allow you to customize how items in a project are displayed and filtered.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="projectNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ProjectsV2View> ProjectsCreateViewForUserAsync(
            string userId,
            int projectNumber,

            global::tryAGI.GitHub.ProjectsCreateViewForUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a view for a user-owned project<br/>
        /// Create a new view in a user-owned project. Views allow you to customize how items in a project are displayed and filtered.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="projectNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ProjectsV2View>> ProjectsCreateViewForUserAsResponseAsync(
            string userId,
            int projectNumber,

            global::tryAGI.GitHub.ProjectsCreateViewForUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a view for a user-owned project<br/>
        /// Create a new view in a user-owned project. Views allow you to customize how items in a project are displayed and filtered.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="projectNumber"></param>
        /// <param name="name">
        /// The name of the view.<br/>
        /// Example: Sprint Board
        /// </param>
        /// <param name="layout">
        /// The layout of the view.<br/>
        /// Example: board
        /// </param>
        /// <param name="filter">
        /// The filter query for the view. See [Filtering projects](https://docs.github.com/issues/planning-and-tracking-with-projects/customizing-views-in-your-project/filtering-projects) for more information.<br/>
        /// Example: is:issue is:open
        /// </param>
        /// <param name="visibleFields">
        /// `visible_fields` is not applicable to `roadmap` layout views.<br/>
        /// For `table` and `board` layouts, this represents the field IDs that should be visible in the view. If not provided, the default visible fields will be used.<br/>
        /// Example: [123, 456, 789]
        /// </param>
        /// <param name="sortBy">
        /// Sorting configuration for the view. Each element is a two-element array of `[field_id, direction]` where `direction` is `"asc"` or `"desc"`. Supports multiple sort criteria applied in order.<br/>
        /// Example: [[123, asc], [456, desc]]
        /// </param>
        /// <param name="groupBy">
        /// The field IDs to group items by (horizontal grouping). Supports a single field. The field must support grouping; fields such as `Title`, `Reviewers`, `Linked pull requests`, `Sub-issues progress`, `Tracked by`, and `Tracks` cannot be grouped on.<br/>
        /// Example: [123]
        /// </param>
        /// <param name="verticalGroupBy">
        /// The field IDs to use as columns in `board` layout (vertical grouping). Supports a single field. The field must support grouping; fields such as `Title`, `Reviewers`, `Linked pull requests`, `Sub-issues progress`, `Tracked by`, and `Tracks` cannot be grouped on.<br/>
        /// Example: [456]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ProjectsV2View> ProjectsCreateViewForUserAsync(
            string userId,
            int projectNumber,
            string name,
            global::tryAGI.GitHub.ProjectsCreateViewForUserRequestLayout layout,
            string? filter = default,
            global::System.Collections.Generic.IList<int>? visibleFields = default,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::tryAGI.GitHub.OneOf<int?, string>>>? sortBy = default,
            global::System.Collections.Generic.IList<int>? groupBy = default,
            global::System.Collections.Generic.IList<int>? verticalGroupBy = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}