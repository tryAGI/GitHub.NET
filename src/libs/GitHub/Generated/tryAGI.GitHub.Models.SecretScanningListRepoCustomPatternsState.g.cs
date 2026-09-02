
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum SecretScanningListRepoCustomPatternsState
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
    public static class SecretScanningListRepoCustomPatternsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningListRepoCustomPatternsState value)
        {
            return value switch
            {
                SecretScanningListRepoCustomPatternsState.Published => "published",
                SecretScanningListRepoCustomPatternsState.Unpublished => "unpublished",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningListRepoCustomPatternsState? ToEnum(string value)
        {
            return value switch
            {
                "published" => SecretScanningListRepoCustomPatternsState.Published,
                "unpublished" => SecretScanningListRepoCustomPatternsState.Unpublished,
                _ => null,
            };
        }
    }
}