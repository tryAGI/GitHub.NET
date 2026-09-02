
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The status of an autofix.
    /// </summary>
    public enum CodeScanningAutofixStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Outdated,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningAutofixStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningAutofixStatus value)
        {
            return value switch
            {
                CodeScanningAutofixStatus.Error => "error",
                CodeScanningAutofixStatus.Outdated => "outdated",
                CodeScanningAutofixStatus.Pending => "pending",
                CodeScanningAutofixStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningAutofixStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => CodeScanningAutofixStatus.Error,
                "outdated" => CodeScanningAutofixStatus.Outdated,
                "pending" => CodeScanningAutofixStatus.Pending,
                "success" => CodeScanningAutofixStatus.Success,
                _ => null,
            };
        }
    }
}