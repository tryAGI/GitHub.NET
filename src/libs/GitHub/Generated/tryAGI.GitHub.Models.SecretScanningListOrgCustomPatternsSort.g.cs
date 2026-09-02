
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    public enum SecretScanningListOrgCustomPatternsSort
    {
        /// <summary>
        ///
        /// </summary>
        Created,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningListOrgCustomPatternsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningListOrgCustomPatternsSort value)
        {
            return value switch
            {
                SecretScanningListOrgCustomPatternsSort.Created => "created",
                SecretScanningListOrgCustomPatternsSort.Name => "name",
                SecretScanningListOrgCustomPatternsSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningListOrgCustomPatternsSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => SecretScanningListOrgCustomPatternsSort.Created,
                "name" => SecretScanningListOrgCustomPatternsSort.Name,
                "updated" => SecretScanningListOrgCustomPatternsSort.Updated,
                _ => null,
            };
        }
    }
}