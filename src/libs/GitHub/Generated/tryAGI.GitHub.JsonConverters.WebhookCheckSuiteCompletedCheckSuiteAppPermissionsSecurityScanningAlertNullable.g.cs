#nullable enable

namespace tryAGI.GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlertNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlert?>
    {
        /// <inheritdoc />
        public override global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlert? Read(
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
                        return global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlertExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlert)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlert?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlert? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlertExtensions.ToValueString(value.Value));
            }
        }
    }
}
