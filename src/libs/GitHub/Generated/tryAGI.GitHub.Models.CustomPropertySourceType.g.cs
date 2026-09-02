
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The source type of the property<br/>
    /// Example: organization
    /// </summary>
    public enum CustomPropertySourceType
    {
        /// <summary>
        ///
        /// </summary>
        Enterprise,
        /// <summary>
        ///
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomPropertySourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomPropertySourceType value)
        {
            return value switch
            {
                CustomPropertySourceType.Enterprise => "enterprise",
                CustomPropertySourceType.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomPropertySourceType? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => CustomPropertySourceType.Enterprise,
                "organization" => CustomPropertySourceType.Organization,
                _ => null,
            };
        }
    }
}