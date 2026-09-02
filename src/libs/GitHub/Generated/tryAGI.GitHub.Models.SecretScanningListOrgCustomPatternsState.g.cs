
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum SecretScanningListOrgCustomPatternsState
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
    public static class SecretScanningListOrgCustomPatternsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningListOrgCustomPatternsState value)
        {
            return value switch
            {
                SecretScanningListOrgCustomPatternsState.Published => "published",
                SecretScanningListOrgCustomPatternsState.Unpublished => "unpublished",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningListOrgCustomPatternsState? ToEnum(string value)
        {
            return value switch
            {
                "published" => SecretScanningListOrgCustomPatternsState.Published,
                "unpublished" => SecretScanningListOrgCustomPatternsState.Unpublished,
                _ => null,
            };
        }
    }
}