#nullable enable

namespace tryAGI.GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsRepositoryProjectsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.GitHub.WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsRepositoryProjects?>
    {
        /// <inheritdoc />
        public override global::tryAGI.GitHub.WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsRepositoryProjects? Read(
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
                        return global::tryAGI.GitHub.WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsRepositoryProjectsExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::tryAGI.GitHub.WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsRepositoryProjects)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::tryAGI.GitHub.WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsRepositoryProjects?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.GitHub.WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsRepositoryProjects? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::tryAGI.GitHub.WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsRepositoryProjectsExtensions.ToValueString(value.Value));
            }
        }
    }
}
