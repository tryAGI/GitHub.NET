#nullable enable

namespace tryAGI.GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class IssuesUpdateResponseSuggestionsIssueFieldValueConfidenceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsIssueFieldValueConfidence?>
    {
        /// <inheritdoc />
        public override global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsIssueFieldValueConfidence? Read(
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
                        return global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsIssueFieldValueConfidenceExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsIssueFieldValueConfidence)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsIssueFieldValueConfidence?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsIssueFieldValueConfidence? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsIssueFieldValueConfidenceExtensions.ToValueString(value.Value));
            }
        }
    }
}
