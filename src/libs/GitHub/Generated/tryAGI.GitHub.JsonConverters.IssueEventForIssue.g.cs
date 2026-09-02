#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.GitHub.JsonConverters
{
    /// <inheritdoc />
    public class IssueEventForIssueJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.GitHub.IssueEventForIssue>
    {
        /// <inheritdoc />
        public override global::tryAGI.GitHub.IssueEventForIssue Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("actor")) __score0++;
            if (__jsonProps.Contains("actor.avatar_url")) __score0++;
            if (__jsonProps.Contains("actor.email")) __score0++;
            if (__jsonProps.Contains("actor.events_url")) __score0++;
            if (__jsonProps.Contains("actor.followers_url")) __score0++;
            if (__jsonProps.Contains("actor.following_url")) __score0++;
            if (__jsonProps.Contains("actor.gists_url")) __score0++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score0++;
            if (__jsonProps.Contains("actor.html_url")) __score0++;
            if (__jsonProps.Contains("actor.id")) __score0++;
            if (__jsonProps.Contains("actor.login")) __score0++;
            if (__jsonProps.Contains("actor.name")) __score0++;
            if (__jsonProps.Contains("actor.node_id")) __score0++;
            if (__jsonProps.Contains("actor.organizations_url")) __score0++;
            if (__jsonProps.Contains("actor.received_events_url")) __score0++;
            if (__jsonProps.Contains("actor.repos_url")) __score0++;
            if (__jsonProps.Contains("actor.site_admin")) __score0++;
            if (__jsonProps.Contains("actor.starred_at")) __score0++;
            if (__jsonProps.Contains("actor.starred_url")) __score0++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score0++;
            if (__jsonProps.Contains("actor.type")) __score0++;
            if (__jsonProps.Contains("actor.url")) __score0++;
            if (__jsonProps.Contains("actor.user_view_type")) __score0++;
            if (__jsonProps.Contains("commit_id")) __score0++;
            if (__jsonProps.Contains("commit_url")) __score0++;
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("event")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("intent")) __score0++;
            if (__jsonProps.Contains("intent.confidence")) __score0++;
            if (__jsonProps.Contains("intent.rationale")) __score0++;
            if (__jsonProps.Contains("label")) __score0++;
            if (__jsonProps.Contains("label.color")) __score0++;
            if (__jsonProps.Contains("label.name")) __score0++;
            if (__jsonProps.Contains("node_id")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score0++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score0++;
            if (__jsonProps.Contains("url")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("actor")) __score1++;
            if (__jsonProps.Contains("actor.avatar_url")) __score1++;
            if (__jsonProps.Contains("actor.email")) __score1++;
            if (__jsonProps.Contains("actor.events_url")) __score1++;
            if (__jsonProps.Contains("actor.followers_url")) __score1++;
            if (__jsonProps.Contains("actor.following_url")) __score1++;
            if (__jsonProps.Contains("actor.gists_url")) __score1++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score1++;
            if (__jsonProps.Contains("actor.html_url")) __score1++;
            if (__jsonProps.Contains("actor.id")) __score1++;
            if (__jsonProps.Contains("actor.login")) __score1++;
            if (__jsonProps.Contains("actor.name")) __score1++;
            if (__jsonProps.Contains("actor.node_id")) __score1++;
            if (__jsonProps.Contains("actor.organizations_url")) __score1++;
            if (__jsonProps.Contains("actor.received_events_url")) __score1++;
            if (__jsonProps.Contains("actor.repos_url")) __score1++;
            if (__jsonProps.Contains("actor.site_admin")) __score1++;
            if (__jsonProps.Contains("actor.starred_at")) __score1++;
            if (__jsonProps.Contains("actor.starred_url")) __score1++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score1++;
            if (__jsonProps.Contains("actor.type")) __score1++;
            if (__jsonProps.Contains("actor.url")) __score1++;
            if (__jsonProps.Contains("actor.user_view_type")) __score1++;
            if (__jsonProps.Contains("commit_id")) __score1++;
            if (__jsonProps.Contains("commit_url")) __score1++;
            if (__jsonProps.Contains("created_at")) __score1++;
            if (__jsonProps.Contains("event")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("intent")) __score1++;
            if (__jsonProps.Contains("intent.confidence")) __score1++;
            if (__jsonProps.Contains("intent.rationale")) __score1++;
            if (__jsonProps.Contains("label")) __score1++;
            if (__jsonProps.Contains("label.color")) __score1++;
            if (__jsonProps.Contains("label.name")) __score1++;
            if (__jsonProps.Contains("node_id")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score1++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score1++;
            if (__jsonProps.Contains("url")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("actor")) __score2++;
            if (__jsonProps.Contains("actor.avatar_url")) __score2++;
            if (__jsonProps.Contains("actor.email")) __score2++;
            if (__jsonProps.Contains("actor.events_url")) __score2++;
            if (__jsonProps.Contains("actor.followers_url")) __score2++;
            if (__jsonProps.Contains("actor.following_url")) __score2++;
            if (__jsonProps.Contains("actor.gists_url")) __score2++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score2++;
            if (__jsonProps.Contains("actor.html_url")) __score2++;
            if (__jsonProps.Contains("actor.id")) __score2++;
            if (__jsonProps.Contains("actor.login")) __score2++;
            if (__jsonProps.Contains("actor.name")) __score2++;
            if (__jsonProps.Contains("actor.node_id")) __score2++;
            if (__jsonProps.Contains("actor.organizations_url")) __score2++;
            if (__jsonProps.Contains("actor.received_events_url")) __score2++;
            if (__jsonProps.Contains("actor.repos_url")) __score2++;
            if (__jsonProps.Contains("actor.site_admin")) __score2++;
            if (__jsonProps.Contains("actor.starred_at")) __score2++;
            if (__jsonProps.Contains("actor.starred_url")) __score2++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score2++;
            if (__jsonProps.Contains("actor.type")) __score2++;
            if (__jsonProps.Contains("actor.url")) __score2++;
            if (__jsonProps.Contains("actor.user_view_type")) __score2++;
            if (__jsonProps.Contains("assignee")) __score2++;
            if (__jsonProps.Contains("assignee.avatar_url")) __score2++;
            if (__jsonProps.Contains("assignee.email")) __score2++;
            if (__jsonProps.Contains("assignee.events_url")) __score2++;
            if (__jsonProps.Contains("assignee.followers_url")) __score2++;
            if (__jsonProps.Contains("assignee.following_url")) __score2++;
            if (__jsonProps.Contains("assignee.gists_url")) __score2++;
            if (__jsonProps.Contains("assignee.gravatar_id")) __score2++;
            if (__jsonProps.Contains("assignee.html_url")) __score2++;
            if (__jsonProps.Contains("assignee.id")) __score2++;
            if (__jsonProps.Contains("assignee.login")) __score2++;
            if (__jsonProps.Contains("assignee.name")) __score2++;
            if (__jsonProps.Contains("assignee.node_id")) __score2++;
            if (__jsonProps.Contains("assignee.organizations_url")) __score2++;
            if (__jsonProps.Contains("assignee.received_events_url")) __score2++;
            if (__jsonProps.Contains("assignee.repos_url")) __score2++;
            if (__jsonProps.Contains("assignee.site_admin")) __score2++;
            if (__jsonProps.Contains("assignee.starred_at")) __score2++;
            if (__jsonProps.Contains("assignee.starred_url")) __score2++;
            if (__jsonProps.Contains("assignee.subscriptions_url")) __score2++;
            if (__jsonProps.Contains("assignee.type")) __score2++;
            if (__jsonProps.Contains("assignee.url")) __score2++;
            if (__jsonProps.Contains("assignee.user_view_type")) __score2++;
            if (__jsonProps.Contains("assigner")) __score2++;
            if (__jsonProps.Contains("assigner.avatar_url")) __score2++;
            if (__jsonProps.Contains("assigner.email")) __score2++;
            if (__jsonProps.Contains("assigner.events_url")) __score2++;
            if (__jsonProps.Contains("assigner.followers_url")) __score2++;
            if (__jsonProps.Contains("assigner.following_url")) __score2++;
            if (__jsonProps.Contains("assigner.gists_url")) __score2++;
            if (__jsonProps.Contains("assigner.gravatar_id")) __score2++;
            if (__jsonProps.Contains("assigner.html_url")) __score2++;
            if (__jsonProps.Contains("assigner.id")) __score2++;
            if (__jsonProps.Contains("assigner.login")) __score2++;
            if (__jsonProps.Contains("assigner.name")) __score2++;
            if (__jsonProps.Contains("assigner.node_id")) __score2++;
            if (__jsonProps.Contains("assigner.organizations_url")) __score2++;
            if (__jsonProps.Contains("assigner.received_events_url")) __score2++;
            if (__jsonProps.Contains("assigner.repos_url")) __score2++;
            if (__jsonProps.Contains("assigner.site_admin")) __score2++;
            if (__jsonProps.Contains("assigner.starred_at")) __score2++;
            if (__jsonProps.Contains("assigner.starred_url")) __score2++;
            if (__jsonProps.Contains("assigner.subscriptions_url")) __score2++;
            if (__jsonProps.Contains("assigner.type")) __score2++;
            if (__jsonProps.Contains("assigner.url")) __score2++;
            if (__jsonProps.Contains("assigner.user_view_type")) __score2++;
            if (__jsonProps.Contains("commit_id")) __score2++;
            if (__jsonProps.Contains("commit_url")) __score2++;
            if (__jsonProps.Contains("created_at")) __score2++;
            if (__jsonProps.Contains("event")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("intent")) __score2++;
            if (__jsonProps.Contains("intent.confidence")) __score2++;
            if (__jsonProps.Contains("intent.rationale")) __score2++;
            if (__jsonProps.Contains("node_id")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score2++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score2++;
            if (__jsonProps.Contains("url")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("actor")) __score3++;
            if (__jsonProps.Contains("actor.avatar_url")) __score3++;
            if (__jsonProps.Contains("actor.email")) __score3++;
            if (__jsonProps.Contains("actor.events_url")) __score3++;
            if (__jsonProps.Contains("actor.followers_url")) __score3++;
            if (__jsonProps.Contains("actor.following_url")) __score3++;
            if (__jsonProps.Contains("actor.gists_url")) __score3++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score3++;
            if (__jsonProps.Contains("actor.html_url")) __score3++;
            if (__jsonProps.Contains("actor.id")) __score3++;
            if (__jsonProps.Contains("actor.login")) __score3++;
            if (__jsonProps.Contains("actor.name")) __score3++;
            if (__jsonProps.Contains("actor.node_id")) __score3++;
            if (__jsonProps.Contains("actor.organizations_url")) __score3++;
            if (__jsonProps.Contains("actor.received_events_url")) __score3++;
            if (__jsonProps.Contains("actor.repos_url")) __score3++;
            if (__jsonProps.Contains("actor.site_admin")) __score3++;
            if (__jsonProps.Contains("actor.starred_at")) __score3++;
            if (__jsonProps.Contains("actor.starred_url")) __score3++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score3++;
            if (__jsonProps.Contains("actor.type")) __score3++;
            if (__jsonProps.Contains("actor.url")) __score3++;
            if (__jsonProps.Contains("actor.user_view_type")) __score3++;
            if (__jsonProps.Contains("assignee")) __score3++;
            if (__jsonProps.Contains("assignee.avatar_url")) __score3++;
            if (__jsonProps.Contains("assignee.email")) __score3++;
            if (__jsonProps.Contains("assignee.events_url")) __score3++;
            if (__jsonProps.Contains("assignee.followers_url")) __score3++;
            if (__jsonProps.Contains("assignee.following_url")) __score3++;
            if (__jsonProps.Contains("assignee.gists_url")) __score3++;
            if (__jsonProps.Contains("assignee.gravatar_id")) __score3++;
            if (__jsonProps.Contains("assignee.html_url")) __score3++;
            if (__jsonProps.Contains("assignee.id")) __score3++;
            if (__jsonProps.Contains("assignee.login")) __score3++;
            if (__jsonProps.Contains("assignee.name")) __score3++;
            if (__jsonProps.Contains("assignee.node_id")) __score3++;
            if (__jsonProps.Contains("assignee.organizations_url")) __score3++;
            if (__jsonProps.Contains("assignee.received_events_url")) __score3++;
            if (__jsonProps.Contains("assignee.repos_url")) __score3++;
            if (__jsonProps.Contains("assignee.site_admin")) __score3++;
            if (__jsonProps.Contains("assignee.starred_at")) __score3++;
            if (__jsonProps.Contains("assignee.starred_url")) __score3++;
            if (__jsonProps.Contains("assignee.subscriptions_url")) __score3++;
            if (__jsonProps.Contains("assignee.type")) __score3++;
            if (__jsonProps.Contains("assignee.url")) __score3++;
            if (__jsonProps.Contains("assignee.user_view_type")) __score3++;
            if (__jsonProps.Contains("assigner")) __score3++;
            if (__jsonProps.Contains("assigner.avatar_url")) __score3++;
            if (__jsonProps.Contains("assigner.email")) __score3++;
            if (__jsonProps.Contains("assigner.events_url")) __score3++;
            if (__jsonProps.Contains("assigner.followers_url")) __score3++;
            if (__jsonProps.Contains("assigner.following_url")) __score3++;
            if (__jsonProps.Contains("assigner.gists_url")) __score3++;
            if (__jsonProps.Contains("assigner.gravatar_id")) __score3++;
            if (__jsonProps.Contains("assigner.html_url")) __score3++;
            if (__jsonProps.Contains("assigner.id")) __score3++;
            if (__jsonProps.Contains("assigner.login")) __score3++;
            if (__jsonProps.Contains("assigner.name")) __score3++;
            if (__jsonProps.Contains("assigner.node_id")) __score3++;
            if (__jsonProps.Contains("assigner.organizations_url")) __score3++;
            if (__jsonProps.Contains("assigner.received_events_url")) __score3++;
            if (__jsonProps.Contains("assigner.repos_url")) __score3++;
            if (__jsonProps.Contains("assigner.site_admin")) __score3++;
            if (__jsonProps.Contains("assigner.starred_at")) __score3++;
            if (__jsonProps.Contains("assigner.starred_url")) __score3++;
            if (__jsonProps.Contains("assigner.subscriptions_url")) __score3++;
            if (__jsonProps.Contains("assigner.type")) __score3++;
            if (__jsonProps.Contains("assigner.url")) __score3++;
            if (__jsonProps.Contains("assigner.user_view_type")) __score3++;
            if (__jsonProps.Contains("commit_id")) __score3++;
            if (__jsonProps.Contains("commit_url")) __score3++;
            if (__jsonProps.Contains("created_at")) __score3++;
            if (__jsonProps.Contains("event")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("node_id")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score3++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score3++;
            if (__jsonProps.Contains("url")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("actor")) __score4++;
            if (__jsonProps.Contains("actor.avatar_url")) __score4++;
            if (__jsonProps.Contains("actor.email")) __score4++;
            if (__jsonProps.Contains("actor.events_url")) __score4++;
            if (__jsonProps.Contains("actor.followers_url")) __score4++;
            if (__jsonProps.Contains("actor.following_url")) __score4++;
            if (__jsonProps.Contains("actor.gists_url")) __score4++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score4++;
            if (__jsonProps.Contains("actor.html_url")) __score4++;
            if (__jsonProps.Contains("actor.id")) __score4++;
            if (__jsonProps.Contains("actor.login")) __score4++;
            if (__jsonProps.Contains("actor.name")) __score4++;
            if (__jsonProps.Contains("actor.node_id")) __score4++;
            if (__jsonProps.Contains("actor.organizations_url")) __score4++;
            if (__jsonProps.Contains("actor.received_events_url")) __score4++;
            if (__jsonProps.Contains("actor.repos_url")) __score4++;
            if (__jsonProps.Contains("actor.site_admin")) __score4++;
            if (__jsonProps.Contains("actor.starred_at")) __score4++;
            if (__jsonProps.Contains("actor.starred_url")) __score4++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score4++;
            if (__jsonProps.Contains("actor.type")) __score4++;
            if (__jsonProps.Contains("actor.url")) __score4++;
            if (__jsonProps.Contains("actor.user_view_type")) __score4++;
            if (__jsonProps.Contains("commit_id")) __score4++;
            if (__jsonProps.Contains("commit_url")) __score4++;
            if (__jsonProps.Contains("created_at")) __score4++;
            if (__jsonProps.Contains("event")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("milestone")) __score4++;
            if (__jsonProps.Contains("milestone.title")) __score4++;
            if (__jsonProps.Contains("node_id")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score4++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score4++;
            if (__jsonProps.Contains("url")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("actor")) __score5++;
            if (__jsonProps.Contains("actor.avatar_url")) __score5++;
            if (__jsonProps.Contains("actor.email")) __score5++;
            if (__jsonProps.Contains("actor.events_url")) __score5++;
            if (__jsonProps.Contains("actor.followers_url")) __score5++;
            if (__jsonProps.Contains("actor.following_url")) __score5++;
            if (__jsonProps.Contains("actor.gists_url")) __score5++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score5++;
            if (__jsonProps.Contains("actor.html_url")) __score5++;
            if (__jsonProps.Contains("actor.id")) __score5++;
            if (__jsonProps.Contains("actor.login")) __score5++;
            if (__jsonProps.Contains("actor.name")) __score5++;
            if (__jsonProps.Contains("actor.node_id")) __score5++;
            if (__jsonProps.Contains("actor.organizations_url")) __score5++;
            if (__jsonProps.Contains("actor.received_events_url")) __score5++;
            if (__jsonProps.Contains("actor.repos_url")) __score5++;
            if (__jsonProps.Contains("actor.site_admin")) __score5++;
            if (__jsonProps.Contains("actor.starred_at")) __score5++;
            if (__jsonProps.Contains("actor.starred_url")) __score5++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score5++;
            if (__jsonProps.Contains("actor.type")) __score5++;
            if (__jsonProps.Contains("actor.url")) __score5++;
            if (__jsonProps.Contains("actor.user_view_type")) __score5++;
            if (__jsonProps.Contains("commit_id")) __score5++;
            if (__jsonProps.Contains("commit_url")) __score5++;
            if (__jsonProps.Contains("created_at")) __score5++;
            if (__jsonProps.Contains("event")) __score5++;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("milestone")) __score5++;
            if (__jsonProps.Contains("milestone.title")) __score5++;
            if (__jsonProps.Contains("node_id")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score5++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score5++;
            if (__jsonProps.Contains("url")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("actor")) __score6++;
            if (__jsonProps.Contains("actor.avatar_url")) __score6++;
            if (__jsonProps.Contains("actor.email")) __score6++;
            if (__jsonProps.Contains("actor.events_url")) __score6++;
            if (__jsonProps.Contains("actor.followers_url")) __score6++;
            if (__jsonProps.Contains("actor.following_url")) __score6++;
            if (__jsonProps.Contains("actor.gists_url")) __score6++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score6++;
            if (__jsonProps.Contains("actor.html_url")) __score6++;
            if (__jsonProps.Contains("actor.id")) __score6++;
            if (__jsonProps.Contains("actor.login")) __score6++;
            if (__jsonProps.Contains("actor.name")) __score6++;
            if (__jsonProps.Contains("actor.node_id")) __score6++;
            if (__jsonProps.Contains("actor.organizations_url")) __score6++;
            if (__jsonProps.Contains("actor.received_events_url")) __score6++;
            if (__jsonProps.Contains("actor.repos_url")) __score6++;
            if (__jsonProps.Contains("actor.site_admin")) __score6++;
            if (__jsonProps.Contains("actor.starred_at")) __score6++;
            if (__jsonProps.Contains("actor.starred_url")) __score6++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score6++;
            if (__jsonProps.Contains("actor.type")) __score6++;
            if (__jsonProps.Contains("actor.url")) __score6++;
            if (__jsonProps.Contains("actor.user_view_type")) __score6++;
            if (__jsonProps.Contains("commit_id")) __score6++;
            if (__jsonProps.Contains("commit_url")) __score6++;
            if (__jsonProps.Contains("created_at")) __score6++;
            if (__jsonProps.Contains("event")) __score6++;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("node_id")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score6++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score6++;
            if (__jsonProps.Contains("rename")) __score6++;
            if (__jsonProps.Contains("rename.from")) __score6++;
            if (__jsonProps.Contains("rename.to")) __score6++;
            if (__jsonProps.Contains("url")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("actor")) __score7++;
            if (__jsonProps.Contains("actor.avatar_url")) __score7++;
            if (__jsonProps.Contains("actor.email")) __score7++;
            if (__jsonProps.Contains("actor.events_url")) __score7++;
            if (__jsonProps.Contains("actor.followers_url")) __score7++;
            if (__jsonProps.Contains("actor.following_url")) __score7++;
            if (__jsonProps.Contains("actor.gists_url")) __score7++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score7++;
            if (__jsonProps.Contains("actor.html_url")) __score7++;
            if (__jsonProps.Contains("actor.id")) __score7++;
            if (__jsonProps.Contains("actor.login")) __score7++;
            if (__jsonProps.Contains("actor.name")) __score7++;
            if (__jsonProps.Contains("actor.node_id")) __score7++;
            if (__jsonProps.Contains("actor.organizations_url")) __score7++;
            if (__jsonProps.Contains("actor.received_events_url")) __score7++;
            if (__jsonProps.Contains("actor.repos_url")) __score7++;
            if (__jsonProps.Contains("actor.site_admin")) __score7++;
            if (__jsonProps.Contains("actor.starred_at")) __score7++;
            if (__jsonProps.Contains("actor.starred_url")) __score7++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score7++;
            if (__jsonProps.Contains("actor.type")) __score7++;
            if (__jsonProps.Contains("actor.url")) __score7++;
            if (__jsonProps.Contains("actor.user_view_type")) __score7++;
            if (__jsonProps.Contains("commit_id")) __score7++;
            if (__jsonProps.Contains("commit_url")) __score7++;
            if (__jsonProps.Contains("created_at")) __score7++;
            if (__jsonProps.Contains("event")) __score7++;
            if (__jsonProps.Contains("id")) __score7++;
            if (__jsonProps.Contains("node_id")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score7++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score7++;
            if (__jsonProps.Contains("requested_reviewer")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.avatar_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.email")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.events_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.followers_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.following_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.gists_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.gravatar_id")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.html_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.id")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.login")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.name")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.node_id")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.organizations_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.received_events_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.repos_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.site_admin")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.starred_at")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.starred_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.subscriptions_url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.type")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.url")) __score7++;
            if (__jsonProps.Contains("requested_reviewer.user_view_type")) __score7++;
            if (__jsonProps.Contains("requested_team")) __score7++;
            if (__jsonProps.Contains("requested_team.access_source")) __score7++;
            if (__jsonProps.Contains("requested_team.description")) __score7++;
            if (__jsonProps.Contains("requested_team.enterprise_id")) __score7++;
            if (__jsonProps.Contains("requested_team.html_url")) __score7++;
            if (__jsonProps.Contains("requested_team.id")) __score7++;
            if (__jsonProps.Contains("requested_team.members_url")) __score7++;
            if (__jsonProps.Contains("requested_team.name")) __score7++;
            if (__jsonProps.Contains("requested_team.node_id")) __score7++;
            if (__jsonProps.Contains("requested_team.notification_setting")) __score7++;
            if (__jsonProps.Contains("requested_team.organization_id")) __score7++;
            if (__jsonProps.Contains("requested_team.parent")) __score7++;
            if (__jsonProps.Contains("requested_team.permission")) __score7++;
            if (__jsonProps.Contains("requested_team.permissions")) __score7++;
            if (__jsonProps.Contains("requested_team.privacy")) __score7++;
            if (__jsonProps.Contains("requested_team.repositories_url")) __score7++;
            if (__jsonProps.Contains("requested_team.slug")) __score7++;
            if (__jsonProps.Contains("requested_team.type")) __score7++;
            if (__jsonProps.Contains("requested_team.url")) __score7++;
            if (__jsonProps.Contains("review_requester")) __score7++;
            if (__jsonProps.Contains("review_requester.avatar_url")) __score7++;
            if (__jsonProps.Contains("review_requester.email")) __score7++;
            if (__jsonProps.Contains("review_requester.events_url")) __score7++;
            if (__jsonProps.Contains("review_requester.followers_url")) __score7++;
            if (__jsonProps.Contains("review_requester.following_url")) __score7++;
            if (__jsonProps.Contains("review_requester.gists_url")) __score7++;
            if (__jsonProps.Contains("review_requester.gravatar_id")) __score7++;
            if (__jsonProps.Contains("review_requester.html_url")) __score7++;
            if (__jsonProps.Contains("review_requester.id")) __score7++;
            if (__jsonProps.Contains("review_requester.login")) __score7++;
            if (__jsonProps.Contains("review_requester.name")) __score7++;
            if (__jsonProps.Contains("review_requester.node_id")) __score7++;
            if (__jsonProps.Contains("review_requester.organizations_url")) __score7++;
            if (__jsonProps.Contains("review_requester.received_events_url")) __score7++;
            if (__jsonProps.Contains("review_requester.repos_url")) __score7++;
            if (__jsonProps.Contains("review_requester.site_admin")) __score7++;
            if (__jsonProps.Contains("review_requester.starred_at")) __score7++;
            if (__jsonProps.Contains("review_requester.starred_url")) __score7++;
            if (__jsonProps.Contains("review_requester.subscriptions_url")) __score7++;
            if (__jsonProps.Contains("review_requester.type")) __score7++;
            if (__jsonProps.Contains("review_requester.url")) __score7++;
            if (__jsonProps.Contains("review_requester.user_view_type")) __score7++;
            if (__jsonProps.Contains("url")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("actor")) __score8++;
            if (__jsonProps.Contains("actor.avatar_url")) __score8++;
            if (__jsonProps.Contains("actor.email")) __score8++;
            if (__jsonProps.Contains("actor.events_url")) __score8++;
            if (__jsonProps.Contains("actor.followers_url")) __score8++;
            if (__jsonProps.Contains("actor.following_url")) __score8++;
            if (__jsonProps.Contains("actor.gists_url")) __score8++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score8++;
            if (__jsonProps.Contains("actor.html_url")) __score8++;
            if (__jsonProps.Contains("actor.id")) __score8++;
            if (__jsonProps.Contains("actor.login")) __score8++;
            if (__jsonProps.Contains("actor.name")) __score8++;
            if (__jsonProps.Contains("actor.node_id")) __score8++;
            if (__jsonProps.Contains("actor.organizations_url")) __score8++;
            if (__jsonProps.Contains("actor.received_events_url")) __score8++;
            if (__jsonProps.Contains("actor.repos_url")) __score8++;
            if (__jsonProps.Contains("actor.site_admin")) __score8++;
            if (__jsonProps.Contains("actor.starred_at")) __score8++;
            if (__jsonProps.Contains("actor.starred_url")) __score8++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score8++;
            if (__jsonProps.Contains("actor.type")) __score8++;
            if (__jsonProps.Contains("actor.url")) __score8++;
            if (__jsonProps.Contains("actor.user_view_type")) __score8++;
            if (__jsonProps.Contains("commit_id")) __score8++;
            if (__jsonProps.Contains("commit_url")) __score8++;
            if (__jsonProps.Contains("created_at")) __score8++;
            if (__jsonProps.Contains("event")) __score8++;
            if (__jsonProps.Contains("id")) __score8++;
            if (__jsonProps.Contains("node_id")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score8++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score8++;
            if (__jsonProps.Contains("requested_reviewer")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.avatar_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.email")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.events_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.followers_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.following_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.gists_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.gravatar_id")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.html_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.id")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.login")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.name")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.node_id")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.organizations_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.received_events_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.repos_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.site_admin")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.starred_at")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.starred_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.subscriptions_url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.type")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.url")) __score8++;
            if (__jsonProps.Contains("requested_reviewer.user_view_type")) __score8++;
            if (__jsonProps.Contains("requested_team")) __score8++;
            if (__jsonProps.Contains("requested_team.access_source")) __score8++;
            if (__jsonProps.Contains("requested_team.description")) __score8++;
            if (__jsonProps.Contains("requested_team.enterprise_id")) __score8++;
            if (__jsonProps.Contains("requested_team.html_url")) __score8++;
            if (__jsonProps.Contains("requested_team.id")) __score8++;
            if (__jsonProps.Contains("requested_team.members_url")) __score8++;
            if (__jsonProps.Contains("requested_team.name")) __score8++;
            if (__jsonProps.Contains("requested_team.node_id")) __score8++;
            if (__jsonProps.Contains("requested_team.notification_setting")) __score8++;
            if (__jsonProps.Contains("requested_team.organization_id")) __score8++;
            if (__jsonProps.Contains("requested_team.parent")) __score8++;
            if (__jsonProps.Contains("requested_team.permission")) __score8++;
            if (__jsonProps.Contains("requested_team.permissions")) __score8++;
            if (__jsonProps.Contains("requested_team.privacy")) __score8++;
            if (__jsonProps.Contains("requested_team.repositories_url")) __score8++;
            if (__jsonProps.Contains("requested_team.slug")) __score8++;
            if (__jsonProps.Contains("requested_team.type")) __score8++;
            if (__jsonProps.Contains("requested_team.url")) __score8++;
            if (__jsonProps.Contains("review_requester")) __score8++;
            if (__jsonProps.Contains("review_requester.avatar_url")) __score8++;
            if (__jsonProps.Contains("review_requester.email")) __score8++;
            if (__jsonProps.Contains("review_requester.events_url")) __score8++;
            if (__jsonProps.Contains("review_requester.followers_url")) __score8++;
            if (__jsonProps.Contains("review_requester.following_url")) __score8++;
            if (__jsonProps.Contains("review_requester.gists_url")) __score8++;
            if (__jsonProps.Contains("review_requester.gravatar_id")) __score8++;
            if (__jsonProps.Contains("review_requester.html_url")) __score8++;
            if (__jsonProps.Contains("review_requester.id")) __score8++;
            if (__jsonProps.Contains("review_requester.login")) __score8++;
            if (__jsonProps.Contains("review_requester.name")) __score8++;
            if (__jsonProps.Contains("review_requester.node_id")) __score8++;
            if (__jsonProps.Contains("review_requester.organizations_url")) __score8++;
            if (__jsonProps.Contains("review_requester.received_events_url")) __score8++;
            if (__jsonProps.Contains("review_requester.repos_url")) __score8++;
            if (__jsonProps.Contains("review_requester.site_admin")) __score8++;
            if (__jsonProps.Contains("review_requester.starred_at")) __score8++;
            if (__jsonProps.Contains("review_requester.starred_url")) __score8++;
            if (__jsonProps.Contains("review_requester.subscriptions_url")) __score8++;
            if (__jsonProps.Contains("review_requester.type")) __score8++;
            if (__jsonProps.Contains("review_requester.url")) __score8++;
            if (__jsonProps.Contains("review_requester.user_view_type")) __score8++;
            if (__jsonProps.Contains("url")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("actor")) __score9++;
            if (__jsonProps.Contains("actor.avatar_url")) __score9++;
            if (__jsonProps.Contains("actor.email")) __score9++;
            if (__jsonProps.Contains("actor.events_url")) __score9++;
            if (__jsonProps.Contains("actor.followers_url")) __score9++;
            if (__jsonProps.Contains("actor.following_url")) __score9++;
            if (__jsonProps.Contains("actor.gists_url")) __score9++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score9++;
            if (__jsonProps.Contains("actor.html_url")) __score9++;
            if (__jsonProps.Contains("actor.id")) __score9++;
            if (__jsonProps.Contains("actor.login")) __score9++;
            if (__jsonProps.Contains("actor.name")) __score9++;
            if (__jsonProps.Contains("actor.node_id")) __score9++;
            if (__jsonProps.Contains("actor.organizations_url")) __score9++;
            if (__jsonProps.Contains("actor.received_events_url")) __score9++;
            if (__jsonProps.Contains("actor.repos_url")) __score9++;
            if (__jsonProps.Contains("actor.site_admin")) __score9++;
            if (__jsonProps.Contains("actor.starred_at")) __score9++;
            if (__jsonProps.Contains("actor.starred_url")) __score9++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score9++;
            if (__jsonProps.Contains("actor.type")) __score9++;
            if (__jsonProps.Contains("actor.url")) __score9++;
            if (__jsonProps.Contains("actor.user_view_type")) __score9++;
            if (__jsonProps.Contains("commit_id")) __score9++;
            if (__jsonProps.Contains("commit_url")) __score9++;
            if (__jsonProps.Contains("created_at")) __score9++;
            if (__jsonProps.Contains("dismissed_review")) __score9++;
            if (__jsonProps.Contains("dismissed_review.dismissal_commit_id")) __score9++;
            if (__jsonProps.Contains("dismissed_review.dismissal_message")) __score9++;
            if (__jsonProps.Contains("dismissed_review.review_id")) __score9++;
            if (__jsonProps.Contains("dismissed_review.state")) __score9++;
            if (__jsonProps.Contains("event")) __score9++;
            if (__jsonProps.Contains("id")) __score9++;
            if (__jsonProps.Contains("node_id")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score9++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score9++;
            if (__jsonProps.Contains("url")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("actor")) __score10++;
            if (__jsonProps.Contains("actor.avatar_url")) __score10++;
            if (__jsonProps.Contains("actor.email")) __score10++;
            if (__jsonProps.Contains("actor.events_url")) __score10++;
            if (__jsonProps.Contains("actor.followers_url")) __score10++;
            if (__jsonProps.Contains("actor.following_url")) __score10++;
            if (__jsonProps.Contains("actor.gists_url")) __score10++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score10++;
            if (__jsonProps.Contains("actor.html_url")) __score10++;
            if (__jsonProps.Contains("actor.id")) __score10++;
            if (__jsonProps.Contains("actor.login")) __score10++;
            if (__jsonProps.Contains("actor.name")) __score10++;
            if (__jsonProps.Contains("actor.node_id")) __score10++;
            if (__jsonProps.Contains("actor.organizations_url")) __score10++;
            if (__jsonProps.Contains("actor.received_events_url")) __score10++;
            if (__jsonProps.Contains("actor.repos_url")) __score10++;
            if (__jsonProps.Contains("actor.site_admin")) __score10++;
            if (__jsonProps.Contains("actor.starred_at")) __score10++;
            if (__jsonProps.Contains("actor.starred_url")) __score10++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score10++;
            if (__jsonProps.Contains("actor.type")) __score10++;
            if (__jsonProps.Contains("actor.url")) __score10++;
            if (__jsonProps.Contains("actor.user_view_type")) __score10++;
            if (__jsonProps.Contains("commit_id")) __score10++;
            if (__jsonProps.Contains("commit_url")) __score10++;
            if (__jsonProps.Contains("created_at")) __score10++;
            if (__jsonProps.Contains("event")) __score10++;
            if (__jsonProps.Contains("id")) __score10++;
            if (__jsonProps.Contains("lock_reason")) __score10++;
            if (__jsonProps.Contains("node_id")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score10++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score10++;
            if (__jsonProps.Contains("url")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("actor")) __score11++;
            if (__jsonProps.Contains("actor.avatar_url")) __score11++;
            if (__jsonProps.Contains("actor.email")) __score11++;
            if (__jsonProps.Contains("actor.events_url")) __score11++;
            if (__jsonProps.Contains("actor.followers_url")) __score11++;
            if (__jsonProps.Contains("actor.following_url")) __score11++;
            if (__jsonProps.Contains("actor.gists_url")) __score11++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score11++;
            if (__jsonProps.Contains("actor.html_url")) __score11++;
            if (__jsonProps.Contains("actor.id")) __score11++;
            if (__jsonProps.Contains("actor.login")) __score11++;
            if (__jsonProps.Contains("actor.name")) __score11++;
            if (__jsonProps.Contains("actor.node_id")) __score11++;
            if (__jsonProps.Contains("actor.organizations_url")) __score11++;
            if (__jsonProps.Contains("actor.received_events_url")) __score11++;
            if (__jsonProps.Contains("actor.repos_url")) __score11++;
            if (__jsonProps.Contains("actor.site_admin")) __score11++;
            if (__jsonProps.Contains("actor.starred_at")) __score11++;
            if (__jsonProps.Contains("actor.starred_url")) __score11++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score11++;
            if (__jsonProps.Contains("actor.type")) __score11++;
            if (__jsonProps.Contains("actor.url")) __score11++;
            if (__jsonProps.Contains("actor.user_view_type")) __score11++;
            if (__jsonProps.Contains("commit_id")) __score11++;
            if (__jsonProps.Contains("commit_url")) __score11++;
            if (__jsonProps.Contains("created_at")) __score11++;
            if (__jsonProps.Contains("event")) __score11++;
            if (__jsonProps.Contains("id")) __score11++;
            if (__jsonProps.Contains("node_id")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score11++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score11++;
            if (__jsonProps.Contains("project_card")) __score11++;
            if (__jsonProps.Contains("project_card.column_name")) __score11++;
            if (__jsonProps.Contains("project_card.id")) __score11++;
            if (__jsonProps.Contains("project_card.previous_column_name")) __score11++;
            if (__jsonProps.Contains("project_card.project_id")) __score11++;
            if (__jsonProps.Contains("project_card.project_url")) __score11++;
            if (__jsonProps.Contains("project_card.url")) __score11++;
            if (__jsonProps.Contains("url")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("actor")) __score12++;
            if (__jsonProps.Contains("actor.avatar_url")) __score12++;
            if (__jsonProps.Contains("actor.email")) __score12++;
            if (__jsonProps.Contains("actor.events_url")) __score12++;
            if (__jsonProps.Contains("actor.followers_url")) __score12++;
            if (__jsonProps.Contains("actor.following_url")) __score12++;
            if (__jsonProps.Contains("actor.gists_url")) __score12++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score12++;
            if (__jsonProps.Contains("actor.html_url")) __score12++;
            if (__jsonProps.Contains("actor.id")) __score12++;
            if (__jsonProps.Contains("actor.login")) __score12++;
            if (__jsonProps.Contains("actor.name")) __score12++;
            if (__jsonProps.Contains("actor.node_id")) __score12++;
            if (__jsonProps.Contains("actor.organizations_url")) __score12++;
            if (__jsonProps.Contains("actor.received_events_url")) __score12++;
            if (__jsonProps.Contains("actor.repos_url")) __score12++;
            if (__jsonProps.Contains("actor.site_admin")) __score12++;
            if (__jsonProps.Contains("actor.starred_at")) __score12++;
            if (__jsonProps.Contains("actor.starred_url")) __score12++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score12++;
            if (__jsonProps.Contains("actor.type")) __score12++;
            if (__jsonProps.Contains("actor.url")) __score12++;
            if (__jsonProps.Contains("actor.user_view_type")) __score12++;
            if (__jsonProps.Contains("commit_id")) __score12++;
            if (__jsonProps.Contains("commit_url")) __score12++;
            if (__jsonProps.Contains("created_at")) __score12++;
            if (__jsonProps.Contains("event")) __score12++;
            if (__jsonProps.Contains("id")) __score12++;
            if (__jsonProps.Contains("node_id")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score12++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score12++;
            if (__jsonProps.Contains("project_card")) __score12++;
            if (__jsonProps.Contains("project_card.column_name")) __score12++;
            if (__jsonProps.Contains("project_card.id")) __score12++;
            if (__jsonProps.Contains("project_card.previous_column_name")) __score12++;
            if (__jsonProps.Contains("project_card.project_id")) __score12++;
            if (__jsonProps.Contains("project_card.project_url")) __score12++;
            if (__jsonProps.Contains("project_card.url")) __score12++;
            if (__jsonProps.Contains("url")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("actor")) __score13++;
            if (__jsonProps.Contains("actor.avatar_url")) __score13++;
            if (__jsonProps.Contains("actor.email")) __score13++;
            if (__jsonProps.Contains("actor.events_url")) __score13++;
            if (__jsonProps.Contains("actor.followers_url")) __score13++;
            if (__jsonProps.Contains("actor.following_url")) __score13++;
            if (__jsonProps.Contains("actor.gists_url")) __score13++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score13++;
            if (__jsonProps.Contains("actor.html_url")) __score13++;
            if (__jsonProps.Contains("actor.id")) __score13++;
            if (__jsonProps.Contains("actor.login")) __score13++;
            if (__jsonProps.Contains("actor.name")) __score13++;
            if (__jsonProps.Contains("actor.node_id")) __score13++;
            if (__jsonProps.Contains("actor.organizations_url")) __score13++;
            if (__jsonProps.Contains("actor.received_events_url")) __score13++;
            if (__jsonProps.Contains("actor.repos_url")) __score13++;
            if (__jsonProps.Contains("actor.site_admin")) __score13++;
            if (__jsonProps.Contains("actor.starred_at")) __score13++;
            if (__jsonProps.Contains("actor.starred_url")) __score13++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score13++;
            if (__jsonProps.Contains("actor.type")) __score13++;
            if (__jsonProps.Contains("actor.url")) __score13++;
            if (__jsonProps.Contains("actor.user_view_type")) __score13++;
            if (__jsonProps.Contains("commit_id")) __score13++;
            if (__jsonProps.Contains("commit_url")) __score13++;
            if (__jsonProps.Contains("created_at")) __score13++;
            if (__jsonProps.Contains("event")) __score13++;
            if (__jsonProps.Contains("id")) __score13++;
            if (__jsonProps.Contains("node_id")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score13++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score13++;
            if (__jsonProps.Contains("project_card")) __score13++;
            if (__jsonProps.Contains("project_card.column_name")) __score13++;
            if (__jsonProps.Contains("project_card.id")) __score13++;
            if (__jsonProps.Contains("project_card.previous_column_name")) __score13++;
            if (__jsonProps.Contains("project_card.project_id")) __score13++;
            if (__jsonProps.Contains("project_card.project_url")) __score13++;
            if (__jsonProps.Contains("project_card.url")) __score13++;
            if (__jsonProps.Contains("url")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("actor")) __score14++;
            if (__jsonProps.Contains("actor.avatar_url")) __score14++;
            if (__jsonProps.Contains("actor.email")) __score14++;
            if (__jsonProps.Contains("actor.events_url")) __score14++;
            if (__jsonProps.Contains("actor.followers_url")) __score14++;
            if (__jsonProps.Contains("actor.following_url")) __score14++;
            if (__jsonProps.Contains("actor.gists_url")) __score14++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score14++;
            if (__jsonProps.Contains("actor.html_url")) __score14++;
            if (__jsonProps.Contains("actor.id")) __score14++;
            if (__jsonProps.Contains("actor.login")) __score14++;
            if (__jsonProps.Contains("actor.name")) __score14++;
            if (__jsonProps.Contains("actor.node_id")) __score14++;
            if (__jsonProps.Contains("actor.organizations_url")) __score14++;
            if (__jsonProps.Contains("actor.received_events_url")) __score14++;
            if (__jsonProps.Contains("actor.repos_url")) __score14++;
            if (__jsonProps.Contains("actor.site_admin")) __score14++;
            if (__jsonProps.Contains("actor.starred_at")) __score14++;
            if (__jsonProps.Contains("actor.starred_url")) __score14++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score14++;
            if (__jsonProps.Contains("actor.type")) __score14++;
            if (__jsonProps.Contains("actor.url")) __score14++;
            if (__jsonProps.Contains("actor.user_view_type")) __score14++;
            if (__jsonProps.Contains("commit_id")) __score14++;
            if (__jsonProps.Contains("commit_url")) __score14++;
            if (__jsonProps.Contains("created_at")) __score14++;
            if (__jsonProps.Contains("event")) __score14++;
            if (__jsonProps.Contains("id")) __score14++;
            if (__jsonProps.Contains("node_id")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score14++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score14++;
            if (__jsonProps.Contains("project_card")) __score14++;
            if (__jsonProps.Contains("project_card.column_name")) __score14++;
            if (__jsonProps.Contains("project_card.id")) __score14++;
            if (__jsonProps.Contains("project_card.previous_column_name")) __score14++;
            if (__jsonProps.Contains("project_card.project_id")) __score14++;
            if (__jsonProps.Contains("project_card.project_url")) __score14++;
            if (__jsonProps.Contains("project_card.url")) __score14++;
            if (__jsonProps.Contains("url")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("actor")) __score15++;
            if (__jsonProps.Contains("actor.avatar_url")) __score15++;
            if (__jsonProps.Contains("actor.email")) __score15++;
            if (__jsonProps.Contains("actor.events_url")) __score15++;
            if (__jsonProps.Contains("actor.followers_url")) __score15++;
            if (__jsonProps.Contains("actor.following_url")) __score15++;
            if (__jsonProps.Contains("actor.gists_url")) __score15++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score15++;
            if (__jsonProps.Contains("actor.html_url")) __score15++;
            if (__jsonProps.Contains("actor.id")) __score15++;
            if (__jsonProps.Contains("actor.login")) __score15++;
            if (__jsonProps.Contains("actor.name")) __score15++;
            if (__jsonProps.Contains("actor.node_id")) __score15++;
            if (__jsonProps.Contains("actor.organizations_url")) __score15++;
            if (__jsonProps.Contains("actor.received_events_url")) __score15++;
            if (__jsonProps.Contains("actor.repos_url")) __score15++;
            if (__jsonProps.Contains("actor.site_admin")) __score15++;
            if (__jsonProps.Contains("actor.starred_at")) __score15++;
            if (__jsonProps.Contains("actor.starred_url")) __score15++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score15++;
            if (__jsonProps.Contains("actor.type")) __score15++;
            if (__jsonProps.Contains("actor.url")) __score15++;
            if (__jsonProps.Contains("actor.user_view_type")) __score15++;
            if (__jsonProps.Contains("commit_id")) __score15++;
            if (__jsonProps.Contains("commit_url")) __score15++;
            if (__jsonProps.Contains("created_at")) __score15++;
            if (__jsonProps.Contains("event")) __score15++;
            if (__jsonProps.Contains("id")) __score15++;
            if (__jsonProps.Contains("intent")) __score15++;
            if (__jsonProps.Contains("intent.confidence")) __score15++;
            if (__jsonProps.Contains("intent.rationale")) __score15++;
            if (__jsonProps.Contains("issue_type")) __score15++;
            if (__jsonProps.Contains("issue_type.color")) __score15++;
            if (__jsonProps.Contains("issue_type.id")) __score15++;
            if (__jsonProps.Contains("issue_type.name")) __score15++;
            if (__jsonProps.Contains("node_id")) __score15++;
            if (__jsonProps.Contains("performed_via_github_app")) __score15++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score15++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score15++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score15++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score15++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score15++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score15++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score15++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score15++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score15++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score15++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score15++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score15++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score15++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score15++;
            if (__jsonProps.Contains("url")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("actor")) __score16++;
            if (__jsonProps.Contains("actor.avatar_url")) __score16++;
            if (__jsonProps.Contains("actor.email")) __score16++;
            if (__jsonProps.Contains("actor.events_url")) __score16++;
            if (__jsonProps.Contains("actor.followers_url")) __score16++;
            if (__jsonProps.Contains("actor.following_url")) __score16++;
            if (__jsonProps.Contains("actor.gists_url")) __score16++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score16++;
            if (__jsonProps.Contains("actor.html_url")) __score16++;
            if (__jsonProps.Contains("actor.id")) __score16++;
            if (__jsonProps.Contains("actor.login")) __score16++;
            if (__jsonProps.Contains("actor.name")) __score16++;
            if (__jsonProps.Contains("actor.node_id")) __score16++;
            if (__jsonProps.Contains("actor.organizations_url")) __score16++;
            if (__jsonProps.Contains("actor.received_events_url")) __score16++;
            if (__jsonProps.Contains("actor.repos_url")) __score16++;
            if (__jsonProps.Contains("actor.site_admin")) __score16++;
            if (__jsonProps.Contains("actor.starred_at")) __score16++;
            if (__jsonProps.Contains("actor.starred_url")) __score16++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score16++;
            if (__jsonProps.Contains("actor.type")) __score16++;
            if (__jsonProps.Contains("actor.url")) __score16++;
            if (__jsonProps.Contains("actor.user_view_type")) __score16++;
            if (__jsonProps.Contains("commit_id")) __score16++;
            if (__jsonProps.Contains("commit_url")) __score16++;
            if (__jsonProps.Contains("created_at")) __score16++;
            if (__jsonProps.Contains("event")) __score16++;
            if (__jsonProps.Contains("id")) __score16++;
            if (__jsonProps.Contains("intent")) __score16++;
            if (__jsonProps.Contains("intent.confidence")) __score16++;
            if (__jsonProps.Contains("intent.rationale")) __score16++;
            if (__jsonProps.Contains("node_id")) __score16++;
            if (__jsonProps.Contains("performed_via_github_app")) __score16++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score16++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score16++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score16++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score16++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score16++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score16++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score16++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score16++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score16++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score16++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score16++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score16++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score16++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score16++;
            if (__jsonProps.Contains("prev_issue_type")) __score16++;
            if (__jsonProps.Contains("prev_issue_type.color")) __score16++;
            if (__jsonProps.Contains("prev_issue_type.id")) __score16++;
            if (__jsonProps.Contains("prev_issue_type.name")) __score16++;
            if (__jsonProps.Contains("url")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("actor")) __score17++;
            if (__jsonProps.Contains("actor.avatar_url")) __score17++;
            if (__jsonProps.Contains("actor.email")) __score17++;
            if (__jsonProps.Contains("actor.events_url")) __score17++;
            if (__jsonProps.Contains("actor.followers_url")) __score17++;
            if (__jsonProps.Contains("actor.following_url")) __score17++;
            if (__jsonProps.Contains("actor.gists_url")) __score17++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score17++;
            if (__jsonProps.Contains("actor.html_url")) __score17++;
            if (__jsonProps.Contains("actor.id")) __score17++;
            if (__jsonProps.Contains("actor.login")) __score17++;
            if (__jsonProps.Contains("actor.name")) __score17++;
            if (__jsonProps.Contains("actor.node_id")) __score17++;
            if (__jsonProps.Contains("actor.organizations_url")) __score17++;
            if (__jsonProps.Contains("actor.received_events_url")) __score17++;
            if (__jsonProps.Contains("actor.repos_url")) __score17++;
            if (__jsonProps.Contains("actor.site_admin")) __score17++;
            if (__jsonProps.Contains("actor.starred_at")) __score17++;
            if (__jsonProps.Contains("actor.starred_url")) __score17++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score17++;
            if (__jsonProps.Contains("actor.type")) __score17++;
            if (__jsonProps.Contains("actor.url")) __score17++;
            if (__jsonProps.Contains("actor.user_view_type")) __score17++;
            if (__jsonProps.Contains("commit_id")) __score17++;
            if (__jsonProps.Contains("commit_url")) __score17++;
            if (__jsonProps.Contains("created_at")) __score17++;
            if (__jsonProps.Contains("event")) __score17++;
            if (__jsonProps.Contains("id")) __score17++;
            if (__jsonProps.Contains("intent")) __score17++;
            if (__jsonProps.Contains("intent.confidence")) __score17++;
            if (__jsonProps.Contains("intent.rationale")) __score17++;
            if (__jsonProps.Contains("issue_type")) __score17++;
            if (__jsonProps.Contains("issue_type.color")) __score17++;
            if (__jsonProps.Contains("issue_type.id")) __score17++;
            if (__jsonProps.Contains("issue_type.name")) __score17++;
            if (__jsonProps.Contains("node_id")) __score17++;
            if (__jsonProps.Contains("performed_via_github_app")) __score17++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score17++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score17++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score17++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score17++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score17++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score17++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score17++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score17++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score17++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score17++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score17++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score17++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score17++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score17++;
            if (__jsonProps.Contains("prev_issue_type")) __score17++;
            if (__jsonProps.Contains("prev_issue_type.color")) __score17++;
            if (__jsonProps.Contains("prev_issue_type.id")) __score17++;
            if (__jsonProps.Contains("prev_issue_type.name")) __score17++;
            if (__jsonProps.Contains("url")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("actor")) __score18++;
            if (__jsonProps.Contains("actor.avatar_url")) __score18++;
            if (__jsonProps.Contains("actor.email")) __score18++;
            if (__jsonProps.Contains("actor.events_url")) __score18++;
            if (__jsonProps.Contains("actor.followers_url")) __score18++;
            if (__jsonProps.Contains("actor.following_url")) __score18++;
            if (__jsonProps.Contains("actor.gists_url")) __score18++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score18++;
            if (__jsonProps.Contains("actor.html_url")) __score18++;
            if (__jsonProps.Contains("actor.id")) __score18++;
            if (__jsonProps.Contains("actor.login")) __score18++;
            if (__jsonProps.Contains("actor.name")) __score18++;
            if (__jsonProps.Contains("actor.node_id")) __score18++;
            if (__jsonProps.Contains("actor.organizations_url")) __score18++;
            if (__jsonProps.Contains("actor.received_events_url")) __score18++;
            if (__jsonProps.Contains("actor.repos_url")) __score18++;
            if (__jsonProps.Contains("actor.site_admin")) __score18++;
            if (__jsonProps.Contains("actor.starred_at")) __score18++;
            if (__jsonProps.Contains("actor.starred_url")) __score18++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score18++;
            if (__jsonProps.Contains("actor.type")) __score18++;
            if (__jsonProps.Contains("actor.url")) __score18++;
            if (__jsonProps.Contains("actor.user_view_type")) __score18++;
            if (__jsonProps.Contains("commit_id")) __score18++;
            if (__jsonProps.Contains("commit_url")) __score18++;
            if (__jsonProps.Contains("created_at")) __score18++;
            if (__jsonProps.Contains("event")) __score18++;
            if (__jsonProps.Contains("id")) __score18++;
            if (__jsonProps.Contains("node_id")) __score18++;
            if (__jsonProps.Contains("performed_via_github_app")) __score18++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score18++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score18++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score18++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score18++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score18++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score18++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score18++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score18++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score18++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score18++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score18++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score18++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score18++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score18++;
            if (__jsonProps.Contains("sub_issue")) __score18++;
            if (__jsonProps.Contains("sub_issue.issue_type")) __score18++;
            if (__jsonProps.Contains("sub_issue.number")) __score18++;
            if (__jsonProps.Contains("sub_issue.repository")) __score18++;
            if (__jsonProps.Contains("sub_issue.state")) __score18++;
            if (__jsonProps.Contains("sub_issue.state_reason")) __score18++;
            if (__jsonProps.Contains("sub_issue.title")) __score18++;
            if (__jsonProps.Contains("url")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("actor")) __score19++;
            if (__jsonProps.Contains("actor.avatar_url")) __score19++;
            if (__jsonProps.Contains("actor.email")) __score19++;
            if (__jsonProps.Contains("actor.events_url")) __score19++;
            if (__jsonProps.Contains("actor.followers_url")) __score19++;
            if (__jsonProps.Contains("actor.following_url")) __score19++;
            if (__jsonProps.Contains("actor.gists_url")) __score19++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score19++;
            if (__jsonProps.Contains("actor.html_url")) __score19++;
            if (__jsonProps.Contains("actor.id")) __score19++;
            if (__jsonProps.Contains("actor.login")) __score19++;
            if (__jsonProps.Contains("actor.name")) __score19++;
            if (__jsonProps.Contains("actor.node_id")) __score19++;
            if (__jsonProps.Contains("actor.organizations_url")) __score19++;
            if (__jsonProps.Contains("actor.received_events_url")) __score19++;
            if (__jsonProps.Contains("actor.repos_url")) __score19++;
            if (__jsonProps.Contains("actor.site_admin")) __score19++;
            if (__jsonProps.Contains("actor.starred_at")) __score19++;
            if (__jsonProps.Contains("actor.starred_url")) __score19++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score19++;
            if (__jsonProps.Contains("actor.type")) __score19++;
            if (__jsonProps.Contains("actor.url")) __score19++;
            if (__jsonProps.Contains("actor.user_view_type")) __score19++;
            if (__jsonProps.Contains("commit_id")) __score19++;
            if (__jsonProps.Contains("commit_url")) __score19++;
            if (__jsonProps.Contains("created_at")) __score19++;
            if (__jsonProps.Contains("event")) __score19++;
            if (__jsonProps.Contains("id")) __score19++;
            if (__jsonProps.Contains("node_id")) __score19++;
            if (__jsonProps.Contains("performed_via_github_app")) __score19++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score19++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score19++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score19++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score19++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score19++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score19++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score19++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score19++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score19++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score19++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score19++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score19++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score19++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score19++;
            if (__jsonProps.Contains("sub_issue")) __score19++;
            if (__jsonProps.Contains("sub_issue.issue_type")) __score19++;
            if (__jsonProps.Contains("sub_issue.number")) __score19++;
            if (__jsonProps.Contains("sub_issue.repository")) __score19++;
            if (__jsonProps.Contains("sub_issue.state")) __score19++;
            if (__jsonProps.Contains("sub_issue.state_reason")) __score19++;
            if (__jsonProps.Contains("sub_issue.title")) __score19++;
            if (__jsonProps.Contains("url")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("actor")) __score20++;
            if (__jsonProps.Contains("actor.avatar_url")) __score20++;
            if (__jsonProps.Contains("actor.email")) __score20++;
            if (__jsonProps.Contains("actor.events_url")) __score20++;
            if (__jsonProps.Contains("actor.followers_url")) __score20++;
            if (__jsonProps.Contains("actor.following_url")) __score20++;
            if (__jsonProps.Contains("actor.gists_url")) __score20++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score20++;
            if (__jsonProps.Contains("actor.html_url")) __score20++;
            if (__jsonProps.Contains("actor.id")) __score20++;
            if (__jsonProps.Contains("actor.login")) __score20++;
            if (__jsonProps.Contains("actor.name")) __score20++;
            if (__jsonProps.Contains("actor.node_id")) __score20++;
            if (__jsonProps.Contains("actor.organizations_url")) __score20++;
            if (__jsonProps.Contains("actor.received_events_url")) __score20++;
            if (__jsonProps.Contains("actor.repos_url")) __score20++;
            if (__jsonProps.Contains("actor.site_admin")) __score20++;
            if (__jsonProps.Contains("actor.starred_at")) __score20++;
            if (__jsonProps.Contains("actor.starred_url")) __score20++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score20++;
            if (__jsonProps.Contains("actor.type")) __score20++;
            if (__jsonProps.Contains("actor.url")) __score20++;
            if (__jsonProps.Contains("actor.user_view_type")) __score20++;
            if (__jsonProps.Contains("commit_id")) __score20++;
            if (__jsonProps.Contains("commit_url")) __score20++;
            if (__jsonProps.Contains("created_at")) __score20++;
            if (__jsonProps.Contains("event")) __score20++;
            if (__jsonProps.Contains("id")) __score20++;
            if (__jsonProps.Contains("node_id")) __score20++;
            if (__jsonProps.Contains("parent_issue")) __score20++;
            if (__jsonProps.Contains("parent_issue.issue_type")) __score20++;
            if (__jsonProps.Contains("parent_issue.number")) __score20++;
            if (__jsonProps.Contains("parent_issue.repository")) __score20++;
            if (__jsonProps.Contains("parent_issue.state")) __score20++;
            if (__jsonProps.Contains("parent_issue.state_reason")) __score20++;
            if (__jsonProps.Contains("parent_issue.title")) __score20++;
            if (__jsonProps.Contains("performed_via_github_app")) __score20++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score20++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score20++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score20++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score20++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score20++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score20++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score20++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score20++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score20++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score20++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score20++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score20++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score20++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score20++;
            if (__jsonProps.Contains("url")) __score20++;
            var __score21 = 0;
            if (__jsonProps.Contains("actor")) __score21++;
            if (__jsonProps.Contains("actor.avatar_url")) __score21++;
            if (__jsonProps.Contains("actor.email")) __score21++;
            if (__jsonProps.Contains("actor.events_url")) __score21++;
            if (__jsonProps.Contains("actor.followers_url")) __score21++;
            if (__jsonProps.Contains("actor.following_url")) __score21++;
            if (__jsonProps.Contains("actor.gists_url")) __score21++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score21++;
            if (__jsonProps.Contains("actor.html_url")) __score21++;
            if (__jsonProps.Contains("actor.id")) __score21++;
            if (__jsonProps.Contains("actor.login")) __score21++;
            if (__jsonProps.Contains("actor.name")) __score21++;
            if (__jsonProps.Contains("actor.node_id")) __score21++;
            if (__jsonProps.Contains("actor.organizations_url")) __score21++;
            if (__jsonProps.Contains("actor.received_events_url")) __score21++;
            if (__jsonProps.Contains("actor.repos_url")) __score21++;
            if (__jsonProps.Contains("actor.site_admin")) __score21++;
            if (__jsonProps.Contains("actor.starred_at")) __score21++;
            if (__jsonProps.Contains("actor.starred_url")) __score21++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score21++;
            if (__jsonProps.Contains("actor.type")) __score21++;
            if (__jsonProps.Contains("actor.url")) __score21++;
            if (__jsonProps.Contains("actor.user_view_type")) __score21++;
            if (__jsonProps.Contains("commit_id")) __score21++;
            if (__jsonProps.Contains("commit_url")) __score21++;
            if (__jsonProps.Contains("created_at")) __score21++;
            if (__jsonProps.Contains("event")) __score21++;
            if (__jsonProps.Contains("id")) __score21++;
            if (__jsonProps.Contains("node_id")) __score21++;
            if (__jsonProps.Contains("parent_issue")) __score21++;
            if (__jsonProps.Contains("parent_issue.issue_type")) __score21++;
            if (__jsonProps.Contains("parent_issue.number")) __score21++;
            if (__jsonProps.Contains("parent_issue.repository")) __score21++;
            if (__jsonProps.Contains("parent_issue.state")) __score21++;
            if (__jsonProps.Contains("parent_issue.state_reason")) __score21++;
            if (__jsonProps.Contains("parent_issue.title")) __score21++;
            if (__jsonProps.Contains("performed_via_github_app")) __score21++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score21++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score21++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score21++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score21++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score21++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score21++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score21++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score21++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score21++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score21++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score21++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score21++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score21++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score21++;
            if (__jsonProps.Contains("url")) __score21++;
            var __score22 = 0;
            if (__jsonProps.Contains("actor")) __score22++;
            if (__jsonProps.Contains("actor.avatar_url")) __score22++;
            if (__jsonProps.Contains("actor.email")) __score22++;
            if (__jsonProps.Contains("actor.events_url")) __score22++;
            if (__jsonProps.Contains("actor.followers_url")) __score22++;
            if (__jsonProps.Contains("actor.following_url")) __score22++;
            if (__jsonProps.Contains("actor.gists_url")) __score22++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score22++;
            if (__jsonProps.Contains("actor.html_url")) __score22++;
            if (__jsonProps.Contains("actor.id")) __score22++;
            if (__jsonProps.Contains("actor.login")) __score22++;
            if (__jsonProps.Contains("actor.name")) __score22++;
            if (__jsonProps.Contains("actor.node_id")) __score22++;
            if (__jsonProps.Contains("actor.organizations_url")) __score22++;
            if (__jsonProps.Contains("actor.received_events_url")) __score22++;
            if (__jsonProps.Contains("actor.repos_url")) __score22++;
            if (__jsonProps.Contains("actor.site_admin")) __score22++;
            if (__jsonProps.Contains("actor.starred_at")) __score22++;
            if (__jsonProps.Contains("actor.starred_url")) __score22++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score22++;
            if (__jsonProps.Contains("actor.type")) __score22++;
            if (__jsonProps.Contains("actor.url")) __score22++;
            if (__jsonProps.Contains("actor.user_view_type")) __score22++;
            if (__jsonProps.Contains("blocked_by")) __score22++;
            if (__jsonProps.Contains("blocked_by.issue_type")) __score22++;
            if (__jsonProps.Contains("blocked_by.number")) __score22++;
            if (__jsonProps.Contains("blocked_by.repository")) __score22++;
            if (__jsonProps.Contains("blocked_by.state")) __score22++;
            if (__jsonProps.Contains("blocked_by.state_reason")) __score22++;
            if (__jsonProps.Contains("blocked_by.title")) __score22++;
            if (__jsonProps.Contains("commit_id")) __score22++;
            if (__jsonProps.Contains("commit_url")) __score22++;
            if (__jsonProps.Contains("created_at")) __score22++;
            if (__jsonProps.Contains("event")) __score22++;
            if (__jsonProps.Contains("id")) __score22++;
            if (__jsonProps.Contains("node_id")) __score22++;
            if (__jsonProps.Contains("performed_via_github_app")) __score22++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score22++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score22++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score22++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score22++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score22++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score22++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score22++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score22++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score22++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score22++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score22++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score22++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score22++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score22++;
            if (__jsonProps.Contains("url")) __score22++;
            var __score23 = 0;
            if (__jsonProps.Contains("actor")) __score23++;
            if (__jsonProps.Contains("actor.avatar_url")) __score23++;
            if (__jsonProps.Contains("actor.email")) __score23++;
            if (__jsonProps.Contains("actor.events_url")) __score23++;
            if (__jsonProps.Contains("actor.followers_url")) __score23++;
            if (__jsonProps.Contains("actor.following_url")) __score23++;
            if (__jsonProps.Contains("actor.gists_url")) __score23++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score23++;
            if (__jsonProps.Contains("actor.html_url")) __score23++;
            if (__jsonProps.Contains("actor.id")) __score23++;
            if (__jsonProps.Contains("actor.login")) __score23++;
            if (__jsonProps.Contains("actor.name")) __score23++;
            if (__jsonProps.Contains("actor.node_id")) __score23++;
            if (__jsonProps.Contains("actor.organizations_url")) __score23++;
            if (__jsonProps.Contains("actor.received_events_url")) __score23++;
            if (__jsonProps.Contains("actor.repos_url")) __score23++;
            if (__jsonProps.Contains("actor.site_admin")) __score23++;
            if (__jsonProps.Contains("actor.starred_at")) __score23++;
            if (__jsonProps.Contains("actor.starred_url")) __score23++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score23++;
            if (__jsonProps.Contains("actor.type")) __score23++;
            if (__jsonProps.Contains("actor.url")) __score23++;
            if (__jsonProps.Contains("actor.user_view_type")) __score23++;
            if (__jsonProps.Contains("blocked_by")) __score23++;
            if (__jsonProps.Contains("blocked_by.issue_type")) __score23++;
            if (__jsonProps.Contains("blocked_by.number")) __score23++;
            if (__jsonProps.Contains("blocked_by.repository")) __score23++;
            if (__jsonProps.Contains("blocked_by.state")) __score23++;
            if (__jsonProps.Contains("blocked_by.state_reason")) __score23++;
            if (__jsonProps.Contains("blocked_by.title")) __score23++;
            if (__jsonProps.Contains("commit_id")) __score23++;
            if (__jsonProps.Contains("commit_url")) __score23++;
            if (__jsonProps.Contains("created_at")) __score23++;
            if (__jsonProps.Contains("event")) __score23++;
            if (__jsonProps.Contains("id")) __score23++;
            if (__jsonProps.Contains("node_id")) __score23++;
            if (__jsonProps.Contains("performed_via_github_app")) __score23++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score23++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score23++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score23++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score23++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score23++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score23++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score23++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score23++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score23++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score23++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score23++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score23++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score23++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score23++;
            if (__jsonProps.Contains("url")) __score23++;
            var __score24 = 0;
            if (__jsonProps.Contains("actor")) __score24++;
            if (__jsonProps.Contains("actor.avatar_url")) __score24++;
            if (__jsonProps.Contains("actor.email")) __score24++;
            if (__jsonProps.Contains("actor.events_url")) __score24++;
            if (__jsonProps.Contains("actor.followers_url")) __score24++;
            if (__jsonProps.Contains("actor.following_url")) __score24++;
            if (__jsonProps.Contains("actor.gists_url")) __score24++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score24++;
            if (__jsonProps.Contains("actor.html_url")) __score24++;
            if (__jsonProps.Contains("actor.id")) __score24++;
            if (__jsonProps.Contains("actor.login")) __score24++;
            if (__jsonProps.Contains("actor.name")) __score24++;
            if (__jsonProps.Contains("actor.node_id")) __score24++;
            if (__jsonProps.Contains("actor.organizations_url")) __score24++;
            if (__jsonProps.Contains("actor.received_events_url")) __score24++;
            if (__jsonProps.Contains("actor.repos_url")) __score24++;
            if (__jsonProps.Contains("actor.site_admin")) __score24++;
            if (__jsonProps.Contains("actor.starred_at")) __score24++;
            if (__jsonProps.Contains("actor.starred_url")) __score24++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score24++;
            if (__jsonProps.Contains("actor.type")) __score24++;
            if (__jsonProps.Contains("actor.url")) __score24++;
            if (__jsonProps.Contains("actor.user_view_type")) __score24++;
            if (__jsonProps.Contains("blocking")) __score24++;
            if (__jsonProps.Contains("blocking.issue_type")) __score24++;
            if (__jsonProps.Contains("blocking.number")) __score24++;
            if (__jsonProps.Contains("blocking.repository")) __score24++;
            if (__jsonProps.Contains("blocking.state")) __score24++;
            if (__jsonProps.Contains("blocking.state_reason")) __score24++;
            if (__jsonProps.Contains("blocking.title")) __score24++;
            if (__jsonProps.Contains("commit_id")) __score24++;
            if (__jsonProps.Contains("commit_url")) __score24++;
            if (__jsonProps.Contains("created_at")) __score24++;
            if (__jsonProps.Contains("event")) __score24++;
            if (__jsonProps.Contains("id")) __score24++;
            if (__jsonProps.Contains("node_id")) __score24++;
            if (__jsonProps.Contains("performed_via_github_app")) __score24++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score24++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score24++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score24++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score24++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score24++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score24++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score24++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score24++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score24++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score24++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score24++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score24++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score24++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score24++;
            if (__jsonProps.Contains("url")) __score24++;
            var __score25 = 0;
            if (__jsonProps.Contains("actor")) __score25++;
            if (__jsonProps.Contains("actor.avatar_url")) __score25++;
            if (__jsonProps.Contains("actor.email")) __score25++;
            if (__jsonProps.Contains("actor.events_url")) __score25++;
            if (__jsonProps.Contains("actor.followers_url")) __score25++;
            if (__jsonProps.Contains("actor.following_url")) __score25++;
            if (__jsonProps.Contains("actor.gists_url")) __score25++;
            if (__jsonProps.Contains("actor.gravatar_id")) __score25++;
            if (__jsonProps.Contains("actor.html_url")) __score25++;
            if (__jsonProps.Contains("actor.id")) __score25++;
            if (__jsonProps.Contains("actor.login")) __score25++;
            if (__jsonProps.Contains("actor.name")) __score25++;
            if (__jsonProps.Contains("actor.node_id")) __score25++;
            if (__jsonProps.Contains("actor.organizations_url")) __score25++;
            if (__jsonProps.Contains("actor.received_events_url")) __score25++;
            if (__jsonProps.Contains("actor.repos_url")) __score25++;
            if (__jsonProps.Contains("actor.site_admin")) __score25++;
            if (__jsonProps.Contains("actor.starred_at")) __score25++;
            if (__jsonProps.Contains("actor.starred_url")) __score25++;
            if (__jsonProps.Contains("actor.subscriptions_url")) __score25++;
            if (__jsonProps.Contains("actor.type")) __score25++;
            if (__jsonProps.Contains("actor.url")) __score25++;
            if (__jsonProps.Contains("actor.user_view_type")) __score25++;
            if (__jsonProps.Contains("blocking")) __score25++;
            if (__jsonProps.Contains("blocking.issue_type")) __score25++;
            if (__jsonProps.Contains("blocking.number")) __score25++;
            if (__jsonProps.Contains("blocking.repository")) __score25++;
            if (__jsonProps.Contains("blocking.state")) __score25++;
            if (__jsonProps.Contains("blocking.state_reason")) __score25++;
            if (__jsonProps.Contains("blocking.title")) __score25++;
            if (__jsonProps.Contains("commit_id")) __score25++;
            if (__jsonProps.Contains("commit_url")) __score25++;
            if (__jsonProps.Contains("created_at")) __score25++;
            if (__jsonProps.Contains("event")) __score25++;
            if (__jsonProps.Contains("id")) __score25++;
            if (__jsonProps.Contains("node_id")) __score25++;
            if (__jsonProps.Contains("performed_via_github_app")) __score25++;
            if (__jsonProps.Contains("performed_via_github_app.client_id")) __score25++;
            if (__jsonProps.Contains("performed_via_github_app.created_at")) __score25++;
            if (__jsonProps.Contains("performed_via_github_app.description")) __score25++;
            if (__jsonProps.Contains("performed_via_github_app.events")) __score25++;
            if (__jsonProps.Contains("performed_via_github_app.external_url")) __score25++;
            if (__jsonProps.Contains("performed_via_github_app.html_url")) __score25++;
            if (__jsonProps.Contains("performed_via_github_app.id")) __score25++;
            if (__jsonProps.Contains("performed_via_github_app.installations_count")) __score25++;
            if (__jsonProps.Contains("performed_via_github_app.name")) __score25++;
            if (__jsonProps.Contains("performed_via_github_app.node_id")) __score25++;
            if (__jsonProps.Contains("performed_via_github_app.owner")) __score25++;
            if (__jsonProps.Contains("performed_via_github_app.permissions")) __score25++;
            if (__jsonProps.Contains("performed_via_github_app.slug")) __score25++;
            if (__jsonProps.Contains("performed_via_github_app.updated_at")) __score25++;
            if (__jsonProps.Contains("url")) __score25++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }
            if (__score16 > __bestScore) { __bestScore = __score16; __bestIndex = 16; }
            if (__score17 > __bestScore) { __bestScore = __score17; __bestIndex = 17; }
            if (__score18 > __bestScore) { __bestScore = __score18; __bestIndex = 18; }
            if (__score19 > __bestScore) { __bestScore = __score19; __bestIndex = 19; }
            if (__score20 > __bestScore) { __bestScore = __score20; __bestIndex = 20; }
            if (__score21 > __bestScore) { __bestScore = __score21; __bestIndex = 21; }
            if (__score22 > __bestScore) { __bestScore = __score22; __bestIndex = 22; }
            if (__score23 > __bestScore) { __bestScore = __score23; __bestIndex = 23; }
            if (__score24 > __bestScore) { __bestScore = __score24; __bestIndex = 24; }
            if (__score25 > __bestScore) { __bestScore = __score25; __bestIndex = 25; }

            global::tryAGI.GitHub.LabeledIssueEvent? labeledIssueEvent = default;
            global::tryAGI.GitHub.UnlabeledIssueEvent? unlabeledIssueEvent = default;
            global::tryAGI.GitHub.AssignedIssueEvent? assignedIssueEvent = default;
            global::tryAGI.GitHub.UnassignedIssueEvent? unassignedIssueEvent = default;
            global::tryAGI.GitHub.MilestonedIssueEvent? milestonedIssueEvent = default;
            global::tryAGI.GitHub.DemilestonedIssueEvent? demilestonedIssueEvent = default;
            global::tryAGI.GitHub.RenamedIssueEvent? renamedIssueEvent = default;
            global::tryAGI.GitHub.ReviewRequestedIssueEvent? reviewRequestedIssueEvent = default;
            global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent? reviewRequestRemovedIssueEvent = default;
            global::tryAGI.GitHub.ReviewDismissedIssueEvent? reviewDismissedIssueEvent = default;
            global::tryAGI.GitHub.LockedIssueEvent? lockedIssueEvent = default;
            global::tryAGI.GitHub.AddedToProjectIssueEvent? addedToProjectIssueEvent = default;
            global::tryAGI.GitHub.MovedColumnInProjectIssueEvent? movedColumnInProjectIssueEvent = default;
            global::tryAGI.GitHub.RemovedFromProjectIssueEvent? removedFromProjectIssueEvent = default;
            global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent? convertedNoteToIssueIssueEvent = default;
            global::tryAGI.GitHub.IssueTypeAddedIssueEvent? issueTypeAddedIssueEvent = default;
            global::tryAGI.GitHub.IssueTypeRemovedIssueEvent? issueTypeRemovedIssueEvent = default;
            global::tryAGI.GitHub.IssueTypeChangedIssueEvent? issueTypeChangedIssueEvent = default;
            global::tryAGI.GitHub.SubIssueAddedIssueEvent? subIssueAddedIssueEvent = default;
            global::tryAGI.GitHub.SubIssueRemovedIssueEvent? subIssueRemovedIssueEvent = default;
            global::tryAGI.GitHub.ParentIssueAddedIssueEvent? parentIssueAddedIssueEvent = default;
            global::tryAGI.GitHub.ParentIssueRemovedIssueEvent? parentIssueRemovedIssueEvent = default;
            global::tryAGI.GitHub.BlockedByAddedIssueEvent? blockedByAddedIssueEvent = default;
            global::tryAGI.GitHub.BlockedByRemovedIssueEvent? blockedByRemovedIssueEvent = default;
            global::tryAGI.GitHub.BlockingAddedIssueEvent? blockingAddedIssueEvent = default;
            global::tryAGI.GitHub.BlockingRemovedIssueEvent? blockingRemovedIssueEvent = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.LabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.LabeledIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.LabeledIssueEvent).Name}");
                        labeledIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.UnlabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.UnlabeledIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.UnlabeledIssueEvent).Name}");
                        unlabeledIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.AssignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.AssignedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.AssignedIssueEvent).Name}");
                        assignedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.UnassignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.UnassignedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.UnassignedIssueEvent).Name}");
                        unassignedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.MilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.MilestonedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.MilestonedIssueEvent).Name}");
                        milestonedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.DemilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.DemilestonedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.DemilestonedIssueEvent).Name}");
                        demilestonedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RenamedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RenamedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RenamedIssueEvent).Name}");
                        renamedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ReviewRequestedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ReviewRequestedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ReviewRequestedIssueEvent).Name}");
                        reviewRequestedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent).Name}");
                        reviewRequestRemovedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ReviewDismissedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ReviewDismissedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ReviewDismissedIssueEvent).Name}");
                        reviewDismissedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.LockedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.LockedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.LockedIssueEvent).Name}");
                        lockedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.AddedToProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.AddedToProjectIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.AddedToProjectIssueEvent).Name}");
                        addedToProjectIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.MovedColumnInProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.MovedColumnInProjectIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.MovedColumnInProjectIssueEvent).Name}");
                        movedColumnInProjectIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 13)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RemovedFromProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RemovedFromProjectIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RemovedFromProjectIssueEvent).Name}");
                        removedFromProjectIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 14)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent).Name}");
                        convertedNoteToIssueIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 15)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.IssueTypeAddedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.IssueTypeAddedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.IssueTypeAddedIssueEvent).Name}");
                        issueTypeAddedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 16)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.IssueTypeRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.IssueTypeRemovedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.IssueTypeRemovedIssueEvent).Name}");
                        issueTypeRemovedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 17)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.IssueTypeChangedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.IssueTypeChangedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.IssueTypeChangedIssueEvent).Name}");
                        issueTypeChangedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 18)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SubIssueAddedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SubIssueAddedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SubIssueAddedIssueEvent).Name}");
                        subIssueAddedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 19)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SubIssueRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SubIssueRemovedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SubIssueRemovedIssueEvent).Name}");
                        subIssueRemovedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 20)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ParentIssueAddedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ParentIssueAddedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ParentIssueAddedIssueEvent).Name}");
                        parentIssueAddedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 21)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ParentIssueRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ParentIssueRemovedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ParentIssueRemovedIssueEvent).Name}");
                        parentIssueRemovedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 22)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.BlockedByAddedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.BlockedByAddedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.BlockedByAddedIssueEvent).Name}");
                        blockedByAddedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 23)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.BlockedByRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.BlockedByRemovedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.BlockedByRemovedIssueEvent).Name}");
                        blockedByRemovedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 24)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.BlockingAddedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.BlockingAddedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.BlockingAddedIssueEvent).Name}");
                        blockingAddedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 25)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.BlockingRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.BlockingRemovedIssueEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.BlockingRemovedIssueEvent).Name}");
                        blockingRemovedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.LabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.LabeledIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.LabeledIssueEvent).Name}");
                    labeledIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.UnlabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.UnlabeledIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.UnlabeledIssueEvent).Name}");
                    unlabeledIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.AssignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.AssignedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.AssignedIssueEvent).Name}");
                    assignedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.UnassignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.UnassignedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.UnassignedIssueEvent).Name}");
                    unassignedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.MilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.MilestonedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.MilestonedIssueEvent).Name}");
                    milestonedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.DemilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.DemilestonedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.DemilestonedIssueEvent).Name}");
                    demilestonedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RenamedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RenamedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RenamedIssueEvent).Name}");
                    renamedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ReviewRequestedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ReviewRequestedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ReviewRequestedIssueEvent).Name}");
                    reviewRequestedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent).Name}");
                    reviewRequestRemovedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ReviewDismissedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ReviewDismissedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ReviewDismissedIssueEvent).Name}");
                    reviewDismissedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.LockedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.LockedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.LockedIssueEvent).Name}");
                    lockedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.AddedToProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.AddedToProjectIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.AddedToProjectIssueEvent).Name}");
                    addedToProjectIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.MovedColumnInProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.MovedColumnInProjectIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.MovedColumnInProjectIssueEvent).Name}");
                    movedColumnInProjectIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RemovedFromProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RemovedFromProjectIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RemovedFromProjectIssueEvent).Name}");
                    removedFromProjectIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent).Name}");
                    convertedNoteToIssueIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.IssueTypeAddedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.IssueTypeAddedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.IssueTypeAddedIssueEvent).Name}");
                    issueTypeAddedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.IssueTypeRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.IssueTypeRemovedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.IssueTypeRemovedIssueEvent).Name}");
                    issueTypeRemovedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.IssueTypeChangedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.IssueTypeChangedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.IssueTypeChangedIssueEvent).Name}");
                    issueTypeChangedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SubIssueAddedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SubIssueAddedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SubIssueAddedIssueEvent).Name}");
                    subIssueAddedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SubIssueRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SubIssueRemovedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SubIssueRemovedIssueEvent).Name}");
                    subIssueRemovedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ParentIssueAddedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ParentIssueAddedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ParentIssueAddedIssueEvent).Name}");
                    parentIssueAddedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ParentIssueRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ParentIssueRemovedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ParentIssueRemovedIssueEvent).Name}");
                    parentIssueRemovedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.BlockedByAddedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.BlockedByAddedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.BlockedByAddedIssueEvent).Name}");
                    blockedByAddedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.BlockedByRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.BlockedByRemovedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.BlockedByRemovedIssueEvent).Name}");
                    blockedByRemovedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.BlockingAddedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.BlockingAddedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.BlockingAddedIssueEvent).Name}");
                    blockingAddedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (labeledIssueEvent == null && unlabeledIssueEvent == null && assignedIssueEvent == null && unassignedIssueEvent == null && milestonedIssueEvent == null && demilestonedIssueEvent == null && renamedIssueEvent == null && reviewRequestedIssueEvent == null && reviewRequestRemovedIssueEvent == null && reviewDismissedIssueEvent == null && lockedIssueEvent == null && addedToProjectIssueEvent == null && movedColumnInProjectIssueEvent == null && removedFromProjectIssueEvent == null && convertedNoteToIssueIssueEvent == null && issueTypeAddedIssueEvent == null && issueTypeRemovedIssueEvent == null && issueTypeChangedIssueEvent == null && subIssueAddedIssueEvent == null && subIssueRemovedIssueEvent == null && parentIssueAddedIssueEvent == null && parentIssueRemovedIssueEvent == null && blockedByAddedIssueEvent == null && blockedByRemovedIssueEvent == null && blockingAddedIssueEvent == null && blockingRemovedIssueEvent == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.BlockingRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.BlockingRemovedIssueEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.BlockingRemovedIssueEvent).Name}");
                    blockingRemovedIssueEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.GitHub.IssueEventForIssue(
                labeledIssueEvent,

                unlabeledIssueEvent,

                assignedIssueEvent,

                unassignedIssueEvent,

                milestonedIssueEvent,

                demilestonedIssueEvent,

                renamedIssueEvent,

                reviewRequestedIssueEvent,

                reviewRequestRemovedIssueEvent,

                reviewDismissedIssueEvent,

                lockedIssueEvent,

                addedToProjectIssueEvent,

                movedColumnInProjectIssueEvent,

                removedFromProjectIssueEvent,

                convertedNoteToIssueIssueEvent,

                issueTypeAddedIssueEvent,

                issueTypeRemovedIssueEvent,

                issueTypeChangedIssueEvent,

                subIssueAddedIssueEvent,

                subIssueRemovedIssueEvent,

                parentIssueAddedIssueEvent,

                parentIssueRemovedIssueEvent,

                blockedByAddedIssueEvent,

                blockedByRemovedIssueEvent,

                blockingAddedIssueEvent,

                blockingRemovedIssueEvent
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.GitHub.IssueEventForIssue value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLabeledIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.LabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.LabeledIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.LabeledIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LabeledIssueEvent!, typeInfo);
            }
            else if (value.IsUnlabeledIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.UnlabeledIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.UnlabeledIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.UnlabeledIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnlabeledIssueEvent!, typeInfo);
            }
            else if (value.IsAssignedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.AssignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.AssignedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.AssignedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssignedIssueEvent!, typeInfo);
            }
            else if (value.IsUnassignedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.UnassignedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.UnassignedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.UnassignedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnassignedIssueEvent!, typeInfo);
            }
            else if (value.IsMilestonedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.MilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.MilestonedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.MilestonedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MilestonedIssueEvent!, typeInfo);
            }
            else if (value.IsDemilestonedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.DemilestonedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.DemilestonedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.DemilestonedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DemilestonedIssueEvent!, typeInfo);
            }
            else if (value.IsRenamedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RenamedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RenamedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RenamedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RenamedIssueEvent!, typeInfo);
            }
            else if (value.IsReviewRequestedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ReviewRequestedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ReviewRequestedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ReviewRequestedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewRequestedIssueEvent!, typeInfo);
            }
            else if (value.IsReviewRequestRemovedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ReviewRequestRemovedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewRequestRemovedIssueEvent!, typeInfo);
            }
            else if (value.IsReviewDismissedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ReviewDismissedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ReviewDismissedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ReviewDismissedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReviewDismissedIssueEvent!, typeInfo);
            }
            else if (value.IsLockedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.LockedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.LockedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.LockedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LockedIssueEvent!, typeInfo);
            }
            else if (value.IsAddedToProjectIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.AddedToProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.AddedToProjectIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.AddedToProjectIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AddedToProjectIssueEvent!, typeInfo);
            }
            else if (value.IsMovedColumnInProjectIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.MovedColumnInProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.MovedColumnInProjectIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.MovedColumnInProjectIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MovedColumnInProjectIssueEvent!, typeInfo);
            }
            else if (value.IsRemovedFromProjectIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.RemovedFromProjectIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.RemovedFromProjectIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.RemovedFromProjectIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RemovedFromProjectIssueEvent!, typeInfo);
            }
            else if (value.IsConvertedNoteToIssueIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ConvertedNoteToIssueIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConvertedNoteToIssueIssueEvent!, typeInfo);
            }
            else if (value.IsIssueTypeAddedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.IssueTypeAddedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.IssueTypeAddedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.IssueTypeAddedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IssueTypeAddedIssueEvent!, typeInfo);
            }
            else if (value.IsIssueTypeRemovedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.IssueTypeRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.IssueTypeRemovedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.IssueTypeRemovedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IssueTypeRemovedIssueEvent!, typeInfo);
            }
            else if (value.IsIssueTypeChangedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.IssueTypeChangedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.IssueTypeChangedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.IssueTypeChangedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IssueTypeChangedIssueEvent!, typeInfo);
            }
            else if (value.IsSubIssueAddedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SubIssueAddedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SubIssueAddedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SubIssueAddedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubIssueAddedIssueEvent!, typeInfo);
            }
            else if (value.IsSubIssueRemovedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.SubIssueRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.SubIssueRemovedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.SubIssueRemovedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubIssueRemovedIssueEvent!, typeInfo);
            }
            else if (value.IsParentIssueAddedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ParentIssueAddedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ParentIssueAddedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ParentIssueAddedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ParentIssueAddedIssueEvent!, typeInfo);
            }
            else if (value.IsParentIssueRemovedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.ParentIssueRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.ParentIssueRemovedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.ParentIssueRemovedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ParentIssueRemovedIssueEvent!, typeInfo);
            }
            else if (value.IsBlockedByAddedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.BlockedByAddedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.BlockedByAddedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.BlockedByAddedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BlockedByAddedIssueEvent!, typeInfo);
            }
            else if (value.IsBlockedByRemovedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.BlockedByRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.BlockedByRemovedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.BlockedByRemovedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BlockedByRemovedIssueEvent!, typeInfo);
            }
            else if (value.IsBlockingAddedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.BlockingAddedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.BlockingAddedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.BlockingAddedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BlockingAddedIssueEvent!, typeInfo);
            }
            else if (value.IsBlockingRemovedIssueEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.GitHub.BlockingRemovedIssueEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.GitHub.BlockingRemovedIssueEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.GitHub.BlockingRemovedIssueEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BlockingRemovedIssueEvent!, typeInfo);
            }
        }
    }
}