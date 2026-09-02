
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    public enum SecretScanningListRepoCustomPatternsSort
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
    public static class SecretScanningListRepoCustomPatternsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningListRepoCustomPatternsSort value)
        {
            return value switch
            {
                SecretScanningListRepoCustomPatternsSort.Created => "created",
                SecretScanningListRepoCustomPatternsSort.Name => "name",
                SecretScanningListRepoCustomPatternsSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningListRepoCustomPatternsSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => SecretScanningListRepoCustomPatternsSort.Created,
                "name" => SecretScanningListRepoCustomPatternsSort.Name,
                "updated" => SecretScanningListRepoCustomPatternsSort.Updated,
                _ => null,
            };
        }
    }
}