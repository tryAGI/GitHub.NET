
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The frequency of the periodic analysis.
    /// </summary>
    public enum CodeQualitySetupSchedule
    {
        /// <summary>
        ///
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeQualitySetupScheduleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeQualitySetupSchedule value)
        {
            return value switch
            {
                CodeQualitySetupSchedule.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeQualitySetupSchedule? ToEnum(string value)
        {
            return value switch
            {
                "weekly" => CodeQualitySetupSchedule.Weekly,
                _ => null,
            };
        }
    }
}