#nullable enable

namespace tryAGI.GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsRepositoryHooksNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.GitHub.WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsRepositoryHooks?>
    {
        /// <inheritdoc />
        public override global::tryAGI.GitHub.WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsRepositoryHooks? Read(
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
                        return global::tryAGI.GitHub.WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsRepositoryHooksExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::tryAGI.GitHub.WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsRepositoryHooks)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::tryAGI.GitHub.WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsRepositoryHooks?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.GitHub.WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsRepositoryHooks? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::tryAGI.GitHub.WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsRepositoryHooksExtensions.ToValueString(value.Value));
            }
        }
    }
}
