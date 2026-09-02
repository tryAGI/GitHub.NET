
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum SecretScanningListRepoCustomPatternsDirection
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningListRepoCustomPatternsDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningListRepoCustomPatternsDirection value)
        {
            return value switch
            {
                SecretScanningListRepoCustomPatternsDirection.Asc => "asc",
                SecretScanningListRepoCustomPatternsDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningListRepoCustomPatternsDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => SecretScanningListRepoCustomPatternsDirection.Asc,
                "desc" => SecretScanningListRepoCustomPatternsDirection.Desc,
                _ => null,
            };
        }
    }
}