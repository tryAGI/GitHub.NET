
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The data type of the issue field<br/>
    /// Example: text
    /// </summary>
    public enum IssueFieldValueDataType
    {
        /// <summary>
        ///
        /// </summary>
        Date,
        /// <summary>
        ///
        /// </summary>
        MultiSelect,
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        SingleSelect,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssueFieldValueDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssueFieldValueDataType value)
        {
            return value switch
            {
                IssueFieldValueDataType.Date => "date",
                IssueFieldValueDataType.MultiSelect => "multi_select",
                IssueFieldValueDataType.Number => "number",
                IssueFieldValueDataType.SingleSelect => "single_select",
                IssueFieldValueDataType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssueFieldValueDataType? ToEnum(string value)
        {
            return value switch
            {
                "date" => IssueFieldValueDataType.Date,
                "multi_select" => IssueFieldValueDataType.MultiSelect,
                "number" => IssueFieldValueDataType.Number,
                "single_select" => IssueFieldValueDataType.SingleSelect,
                "text" => IssueFieldValueDataType.Text,
                _ => null,
            };
        }
    }
}