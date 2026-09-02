
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Color for the option.
    /// </summary>
    public enum OrganizationCreateIssueFieldOptionColor
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
    public static class OrganizationCreateIssueFieldOptionColorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationCreateIssueFieldOptionColor value)
        {
            return value switch
            {
                OrganizationCreateIssueFieldOptionColor.Blue => "blue",
                OrganizationCreateIssueFieldOptionColor.Gray => "gray",
                OrganizationCreateIssueFieldOptionColor.Green => "green",
                OrganizationCreateIssueFieldOptionColor.Orange => "orange",
                OrganizationCreateIssueFieldOptionColor.Pink => "pink",
                OrganizationCreateIssueFieldOptionColor.Purple => "purple",
                OrganizationCreateIssueFieldOptionColor.Red => "red",
                OrganizationCreateIssueFieldOptionColor.Yellow => "yellow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationCreateIssueFieldOptionColor? ToEnum(string value)
        {
            return value switch
            {
                "blue" => OrganizationCreateIssueFieldOptionColor.Blue,
                "gray" => OrganizationCreateIssueFieldOptionColor.Gray,
                "green" => OrganizationCreateIssueFieldOptionColor.Green,
                "orange" => OrganizationCreateIssueFieldOptionColor.Orange,
                "pink" => OrganizationCreateIssueFieldOptionColor.Pink,
                "purple" => OrganizationCreateIssueFieldOptionColor.Purple,
                "red" => OrganizationCreateIssueFieldOptionColor.Red,
                "yellow" => OrganizationCreateIssueFieldOptionColor.Yellow,
                _ => null,
            };
        }
    }
}