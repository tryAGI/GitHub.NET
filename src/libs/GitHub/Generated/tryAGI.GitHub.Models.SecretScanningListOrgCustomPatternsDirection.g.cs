
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum SecretScanningListOrgCustomPatternsDirection
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
    public static class SecretScanningListOrgCustomPatternsDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningListOrgCustomPatternsDirection value)
        {
            return value switch
            {
                SecretScanningListOrgCustomPatternsDirection.Asc => "asc",
                SecretScanningListOrgCustomPatternsDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningListOrgCustomPatternsDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => SecretScanningListOrgCustomPatternsDirection.Asc,
                "desc" => SecretScanningListOrgCustomPatternsDirection.Desc,
                _ => null,
            };
        }
    }
}