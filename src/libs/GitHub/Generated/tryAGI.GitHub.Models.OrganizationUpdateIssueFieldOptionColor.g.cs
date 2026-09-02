
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Color for the option.
    /// </summary>
    public enum OrganizationUpdateIssueFieldOptionColor
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
    public static class OrganizationUpdateIssueFieldOptionColorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationUpdateIssueFieldOptionColor value)
        {
            return value switch
            {
                OrganizationUpdateIssueFieldOptionColor.Blue => "blue",
                OrganizationUpdateIssueFieldOptionColor.Gray => "gray",
                OrganizationUpdateIssueFieldOptionColor.Green => "green",
                OrganizationUpdateIssueFieldOptionColor.Orange => "orange",
                OrganizationUpdateIssueFieldOptionColor.Pink => "pink",
                OrganizationUpdateIssueFieldOptionColor.Purple => "purple",
                OrganizationUpdateIssueFieldOptionColor.Red => "red",
                OrganizationUpdateIssueFieldOptionColor.Yellow => "yellow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationUpdateIssueFieldOptionColor? ToEnum(string value)
        {
            return value switch
            {
                "blue" => OrganizationUpdateIssueFieldOptionColor.Blue,
                "gray" => OrganizationUpdateIssueFieldOptionColor.Gray,
                "green" => OrganizationUpdateIssueFieldOptionColor.Green,
                "orange" => OrganizationUpdateIssueFieldOptionColor.Orange,
                "pink" => OrganizationUpdateIssueFieldOptionColor.Pink,
                "purple" => OrganizationUpdateIssueFieldOptionColor.Purple,
                "red" => OrganizationUpdateIssueFieldOptionColor.Red,
                "yellow" => OrganizationUpdateIssueFieldOptionColor.Yellow,
                _ => null,
            };
        }
    }
}