#nullable enable

namespace tryAGI.GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity?>
    {
        /// <inheritdoc />
        public override global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity? Read(
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
                        return global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurityExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurityExtensions.ToValueString(value.Value));
            }
        }
    }
}
