#nullable enable

namespace tryAGI.GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsMembersNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.GitHub.WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsMembers?>
    {
        /// <inheritdoc />
        public override global::tryAGI.GitHub.WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsMembers? Read(
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
                        return global::tryAGI.GitHub.WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsMembersExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::tryAGI.GitHub.WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsMembers)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::tryAGI.GitHub.WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsMembers?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.GitHub.WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsMembers? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::tryAGI.GitHub.WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsMembersExtensions.ToValueString(value.Value));
            }
        }
    }
}
