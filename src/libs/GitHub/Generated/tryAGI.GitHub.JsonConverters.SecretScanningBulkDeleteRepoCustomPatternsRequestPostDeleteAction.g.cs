#nullable enable

namespace tryAGI.GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class SecretScanningBulkDeleteRepoCustomPatternsRequestPostDeleteActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.GitHub.SecretScanningBulkDeleteRepoCustomPatternsRequestPostDeleteAction>
    {
        /// <inheritdoc />
        public override global::tryAGI.GitHub.SecretScanningBulkDeleteRepoCustomPatternsRequestPostDeleteAction Read(
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
                        return global::tryAGI.GitHub.SecretScanningBulkDeleteRepoCustomPatternsRequestPostDeleteActionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::tryAGI.GitHub.SecretScanningBulkDeleteRepoCustomPatternsRequestPostDeleteAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::tryAGI.GitHub.SecretScanningBulkDeleteRepoCustomPatternsRequestPostDeleteAction);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.GitHub.SecretScanningBulkDeleteRepoCustomPatternsRequestPostDeleteAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::tryAGI.GitHub.SecretScanningBulkDeleteRepoCustomPatternsRequestPostDeleteActionExtensions.ToValueString(value));
        }
    }
}
