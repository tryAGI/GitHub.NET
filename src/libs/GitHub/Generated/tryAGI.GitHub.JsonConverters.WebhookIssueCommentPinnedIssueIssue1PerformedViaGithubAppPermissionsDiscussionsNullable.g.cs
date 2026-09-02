#nullable enable

namespace tryAGI.GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsDiscussionsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.GitHub.WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsDiscussions?>
    {
        /// <inheritdoc />
        public override global::tryAGI.GitHub.WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsDiscussions? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::tryAGI.GitHub.WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsDiscussionsExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::tryAGI.GitHub.WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsDiscussions)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::tryAGI.GitHub.WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsDiscussions?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.GitHub.WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsDiscussions? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::tryAGI.GitHub.WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsDiscussionsExtensions.ToValueString(value.Value));
            }
        }
    }
}
