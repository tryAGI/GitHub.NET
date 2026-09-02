
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The color of the option.
    /// </summary>
    public enum IssueFieldOptionColor
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
    public static class IssueFieldOptionColorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssueFieldOptionColor value)
        {
            return value switch
            {
                IssueFieldOptionColor.Blue => "blue",
                IssueFieldOptionColor.Gray => "gray",
                IssueFieldOptionColor.Green => "green",
                IssueFieldOptionColor.Orange => "orange",
                IssueFieldOptionColor.Pink => "pink",
                IssueFieldOptionColor.Purple => "purple",
                IssueFieldOptionColor.Red => "red",
                IssueFieldOptionColor.Yellow => "yellow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssueFieldOptionColor? ToEnum(string value)
        {
            return value switch
            {
                "blue" => IssueFieldOptionColor.Blue,
                "gray" => IssueFieldOptionColor.Gray,
                "green" => IssueFieldOptionColor.Green,
                "orange" => IssueFieldOptionColor.Orange,
                "pink" => IssueFieldOptionColor.Pink,
                "purple" => IssueFieldOptionColor.Purple,
                "red" => IssueFieldOptionColor.Red,
                "yellow" => IssueFieldOptionColor.Yellow,
                _ => null,
            };
        }
    }
}