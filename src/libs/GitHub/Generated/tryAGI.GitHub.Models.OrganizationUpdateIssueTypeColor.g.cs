
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Color for the issue type.
    /// </summary>
    public enum OrganizationUpdateIssueTypeColor
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
    public static class OrganizationUpdateIssueTypeColorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationUpdateIssueTypeColor value)
        {
            return value switch
            {
                OrganizationUpdateIssueTypeColor.Blue => "blue",
                OrganizationUpdateIssueTypeColor.Gray => "gray",
                OrganizationUpdateIssueTypeColor.Green => "green",
                OrganizationUpdateIssueTypeColor.Orange => "orange",
                OrganizationUpdateIssueTypeColor.Pink => "pink",
                OrganizationUpdateIssueTypeColor.Purple => "purple",
                OrganizationUpdateIssueTypeColor.Red => "red",
                OrganizationUpdateIssueTypeColor.Yellow => "yellow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationUpdateIssueTypeColor? ToEnum(string value)
        {
            return value switch
            {
                "blue" => OrganizationUpdateIssueTypeColor.Blue,
                "gray" => OrganizationUpdateIssueTypeColor.Gray,
                "green" => OrganizationUpdateIssueTypeColor.Green,
                "orange" => OrganizationUpdateIssueTypeColor.Orange,
                "pink" => OrganizationUpdateIssueTypeColor.Pink,
                "purple" => OrganizationUpdateIssueTypeColor.Purple,
                "red" => OrganizationUpdateIssueTypeColor.Red,
                "yellow" => OrganizationUpdateIssueTypeColor.Yellow,
                _ => null,
            };
        }
    }
}