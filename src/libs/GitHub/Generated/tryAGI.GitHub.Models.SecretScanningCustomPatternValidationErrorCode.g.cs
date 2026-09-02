
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A machine-readable code describing the error.
    /// </summary>
    public enum SecretScanningCustomPatternValidationErrorCode
    {
        /// <summary>
        ///
        /// </summary>
        CustomPatternVersionMismatch,
        /// <summary>
        ///
        /// </summary>
        EndDelimiter,
        /// <summary>
        ///
        /// </summary>
        Invalid,
        /// <summary>
        ///
        /// </summary>
        MustMatch,
        /// <summary>
        ///
        /// </summary>
        MustNotMatch,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        StartDelimiter,
        /// <summary>
        ///
        /// </summary>
        Unprocessable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningCustomPatternValidationErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningCustomPatternValidationErrorCode value)
        {
            return value switch
            {
                SecretScanningCustomPatternValidationErrorCode.CustomPatternVersionMismatch => "custom_pattern_version_mismatch",
                SecretScanningCustomPatternValidationErrorCode.EndDelimiter => "end_delimiter",
                SecretScanningCustomPatternValidationErrorCode.Invalid => "invalid",
                SecretScanningCustomPatternValidationErrorCode.MustMatch => "must_match",
                SecretScanningCustomPatternValidationErrorCode.MustNotMatch => "must_not_match",
                SecretScanningCustomPatternValidationErrorCode.Name => "name",
                SecretScanningCustomPatternValidationErrorCode.StartDelimiter => "start_delimiter",
                SecretScanningCustomPatternValidationErrorCode.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningCustomPatternValidationErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "custom_pattern_version_mismatch" => SecretScanningCustomPatternValidationErrorCode.CustomPatternVersionMismatch,
                "end_delimiter" => SecretScanningCustomPatternValidationErrorCode.EndDelimiter,
                "invalid" => SecretScanningCustomPatternValidationErrorCode.Invalid,
                "must_match" => SecretScanningCustomPatternValidationErrorCode.MustMatch,
                "must_not_match" => SecretScanningCustomPatternValidationErrorCode.MustNotMatch,
                "name" => SecretScanningCustomPatternValidationErrorCode.Name,
                "start_delimiter" => SecretScanningCustomPatternValidationErrorCode.StartDelimiter,
                "unprocessable" => SecretScanningCustomPatternValidationErrorCode.Unprocessable,
                _ => null,
            };
        }
    }
}