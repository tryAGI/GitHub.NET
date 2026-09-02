#nullable enable

namespace tryAGI.GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class RepositoryRuleParamsProofOfPresenceRequiredAuthenticationLevelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.GitHub.RepositoryRuleParamsProofOfPresenceRequiredAuthenticationLevel?>
    {
        /// <inheritdoc />
        public override global::tryAGI.GitHub.RepositoryRuleParamsProofOfPresenceRequiredAuthenticationLevel? Read(
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
                        return global::tryAGI.GitHub.RepositoryRuleParamsProofOfPresenceRequiredAuthenticationLevelExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::tryAGI.GitHub.RepositoryRuleParamsProofOfPresenceRequiredAuthenticationLevel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::tryAGI.GitHub.RepositoryRuleParamsProofOfPresenceRequiredAuthenticationLevel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.GitHub.RepositoryRuleParamsProofOfPresenceRequiredAuthenticationLevel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::tryAGI.GitHub.RepositoryRuleParamsProofOfPresenceRequiredAuthenticationLevelExtensions.ToValueString(value.Value));
            }
        }
    }
}
