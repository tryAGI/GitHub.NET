
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The AI findings configuration for the repository.
    /// </summary>
    public enum CodeQualitySetupAiFindingsOption
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        OnPush,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeQualitySetupAiFindingsOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeQualitySetupAiFindingsOption value)
        {
            return value switch
            {
                CodeQualitySetupAiFindingsOption.Disabled => "disabled",
                CodeQualitySetupAiFindingsOption.OnPush => "on_push",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeQualitySetupAiFindingsOption? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeQualitySetupAiFindingsOption.Disabled,
                "on_push" => CodeQualitySetupAiFindingsOption.OnPush,
                _ => null,
            };
        }
    }
}