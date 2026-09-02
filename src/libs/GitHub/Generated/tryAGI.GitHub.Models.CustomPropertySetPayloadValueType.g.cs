
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of the value for the property<br/>
    /// Example: single_select
    /// </summary>
    public enum CustomPropertySetPayloadValueType
    {
        /// <summary>
        ///
        /// </summary>
        MultiSelect,
        /// <summary>
        ///
        /// </summary>
        SingleSelect,
        /// <summary>
        ///
        /// </summary>
        String,
        /// <summary>
        ///
        /// </summary>
        TrueFalse,
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomPropertySetPayloadValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomPropertySetPayloadValueType value)
        {
            return value switch
            {
                CustomPropertySetPayloadValueType.MultiSelect => "multi_select",
                CustomPropertySetPayloadValueType.SingleSelect => "single_select",
                CustomPropertySetPayloadValueType.String => "string",
                CustomPropertySetPayloadValueType.TrueFalse => "true_false",
                CustomPropertySetPayloadValueType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomPropertySetPayloadValueType? ToEnum(string value)
        {
            return value switch
            {
                "multi_select" => CustomPropertySetPayloadValueType.MultiSelect,
                "single_select" => CustomPropertySetPayloadValueType.SingleSelect,
                "string" => CustomPropertySetPayloadValueType.String,
                "true_false" => CustomPropertySetPayloadValueType.TrueFalse,
                "url" => CustomPropertySetPayloadValueType.Url,
                _ => null,
            };
        }
    }
}