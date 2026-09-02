
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The state of the custom pattern.
    /// </summary>
    public enum SecretScanningCustomPatternState
    {
        /// <summary>
        ///
        /// </summary>
        Published,
        /// <summary>
        ///
        /// </summary>
        Unpublished,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningCustomPatternStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningCustomPatternState value)
        {
            return value switch
            {
                SecretScanningCustomPatternState.Published => "published",
                SecretScanningCustomPatternState.Unpublished => "unpublished",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningCustomPatternState? ToEnum(string value)
        {
            return value switch
            {
                "published" => SecretScanningCustomPatternState.Published,
                "unpublished" => SecretScanningCustomPatternState.Unpublished,
                _ => null,
            };
        }
    }
}