
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Color for the issue type.
    /// </summary>
    public enum OrganizationCreateIssueTypeColor
    {
        /// <summary>
        ///
        /// </summary>
        Blue,
        /// <summary>
        ///
        /// </summary>
        Gray,
        /// <summary>
        ///
        /// </summary>
        Green,
        /// <summary>
        ///
        /// </summary>
        Orange,
        /// <summary>
        ///
        /// </summary>
        Pink,
        /// <summary>
        ///
        /// </summary>
        Purple,
        /// <summary>
        ///
        /// </summary>
        Red,
        /// <summary>
        ///
        /// </summary>
        Yellow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationCreateIssueTypeColorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationCreateIssueTypeColor value)
        {
            return value switch
            {
                OrganizationCreateIssueTypeColor.Blue => "blue",
                OrganizationCreateIssueTypeColor.Gray => "gray",
                OrganizationCreateIssueTypeColor.Green => "green",
                OrganizationCreateIssueTypeColor.Orange => "orange",
                OrganizationCreateIssueTypeColor.Pink => "pink",
                OrganizationCreateIssueTypeColor.Purple => "purple",
                OrganizationCreateIssueTypeColor.Red => "red",
                OrganizationCreateIssueTypeColor.Yellow => "yellow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationCreateIssueTypeColor? ToEnum(string value)
        {
            return value switch
            {
                "blue" => OrganizationCreateIssueTypeColor.Blue,
                "gray" => OrganizationCreateIssueTypeColor.Gray,
                "green" => OrganizationCreateIssueTypeColor.Green,
                "orange" => OrganizationCreateIssueTypeColor.Orange,
                "pink" => OrganizationCreateIssueTypeColor.Pink,
                "purple" => OrganizationCreateIssueTypeColor.Purple,
                "red" => OrganizationCreateIssueTypeColor.Red,
                "yellow" => OrganizationCreateIssueTypeColor.Yellow,
                _ => null,
            };
        }
    }
}