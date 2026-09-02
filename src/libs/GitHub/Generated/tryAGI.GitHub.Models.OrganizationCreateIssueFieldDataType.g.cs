
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The data type of the issue field.
    /// </summary>
    public enum OrganizationCreateIssueFieldDataType
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
    public static class OrganizationCreateIssueFieldDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationCreateIssueFieldDataType value)
        {
            return value switch
            {
                OrganizationCreateIssueFieldDataType.Date => "date",
                OrganizationCreateIssueFieldDataType.MultiSelect => "multi_select",
                OrganizationCreateIssueFieldDataType.Number => "number",
                OrganizationCreateIssueFieldDataType.SingleSelect => "single_select",
                OrganizationCreateIssueFieldDataType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationCreateIssueFieldDataType? ToEnum(string value)
        {
            return value switch
            {
                "date" => OrganizationCreateIssueFieldDataType.Date,
                "multi_select" => OrganizationCreateIssueFieldDataType.MultiSelect,
                "number" => OrganizationCreateIssueFieldDataType.Number,
                "single_select" => OrganizationCreateIssueFieldDataType.SingleSelect,
                "text" => OrganizationCreateIssueFieldDataType.Text,
                _ => null,
            };
        }
    }
}