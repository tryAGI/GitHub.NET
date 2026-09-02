
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Whether AI findings run for Code Quality on this repository.
    /// </summary>
    public enum CodeQualitySetupUpdateAiFindingsOption
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
    public static class CodeQualitySetupUpdateAiFindingsOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeQualitySetupUpdateAiFindingsOption value)
        {
            return value switch
            {
                CodeQualitySetupUpdateAiFindingsOption.Disabled => "disabled",
                CodeQualitySetupUpdateAiFindingsOption.OnPush => "on_push",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeQualitySetupUpdateAiFindingsOption? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeQualitySetupUpdateAiFindingsOption.Disabled,
                "on_push" => CodeQualitySetupUpdateAiFindingsOption.OnPush,
                _ => null,
            };
        }
    }
}