
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The color of the issue type.
    /// </summary>
    public enum IssueTypeColor
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
    public static class IssueTypeColorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssueTypeColor value)
        {
            return value switch
            {
                IssueTypeColor.Blue => "blue",
                IssueTypeColor.Gray => "gray",
                IssueTypeColor.Green => "green",
                IssueTypeColor.Orange => "orange",
                IssueTypeColor.Pink => "pink",
                IssueTypeColor.Purple => "purple",
                IssueTypeColor.Red => "red",
                IssueTypeColor.Yellow => "yellow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssueTypeColor? ToEnum(string value)
        {
            return value switch
            {
                "blue" => IssueTypeColor.Blue,
                "gray" => IssueTypeColor.Gray,
                "green" => IssueTypeColor.Green,
                "orange" => IssueTypeColor.Orange,
                "pink" => IssueTypeColor.Pink,
                "purple" => IssueTypeColor.Purple,
                "red" => IssueTypeColor.Red,
                "yellow" => IssueTypeColor.Yellow,
                _ => null,
            };
        }
    }
}