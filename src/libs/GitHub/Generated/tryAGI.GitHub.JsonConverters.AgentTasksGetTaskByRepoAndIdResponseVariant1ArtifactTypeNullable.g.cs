#nullable enable

namespace tryAGI.GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentTasksGetTaskByRepoAndIdResponseVariant1ArtifactTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1ArtifactType?>
    {
        /// <inheritdoc />
        public override global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1ArtifactType? Read(
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
                        return global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1ArtifactTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1ArtifactType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1ArtifactType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1ArtifactType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1ArtifactTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
