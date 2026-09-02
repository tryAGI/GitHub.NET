#nullable enable

namespace tryAGI.GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsEmailsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.GitHub.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsEmails?>
    {
        /// <inheritdoc />
        public override global::tryAGI.GitHub.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsEmails? Read(
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
                        return global::tryAGI.GitHub.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsEmailsExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::tryAGI.GitHub.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsEmails)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::tryAGI.GitHub.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsEmails?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.GitHub.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsEmails? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::tryAGI.GitHub.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsEmailsExtensions.ToValueString(value.Value));
            }
        }
    }
}
