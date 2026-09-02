
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The color of the issue type.
    /// </summary>
    public enum IssueTypeWebhookColor
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
    public static class IssueTypeWebhookColorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssueTypeWebhookColor value)
        {
            return value switch
            {
                IssueTypeWebhookColor.Blue => "blue",
                IssueTypeWebhookColor.Gray => "gray",
                IssueTypeWebhookColor.Green => "green",
                IssueTypeWebhookColor.Orange => "orange",
                IssueTypeWebhookColor.Pink => "pink",
                IssueTypeWebhookColor.Purple => "purple",
                IssueTypeWebhookColor.Red => "red",
                IssueTypeWebhookColor.Yellow => "yellow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssueTypeWebhookColor? ToEnum(string value)
        {
            return value switch
            {
                "blue" => IssueTypeWebhookColor.Blue,
                "gray" => IssueTypeWebhookColor.Gray,
                "green" => IssueTypeWebhookColor.Green,
                "orange" => IssueTypeWebhookColor.Orange,
                "pink" => IssueTypeWebhookColor.Pink,
                "purple" => IssueTypeWebhookColor.Purple,
                "red" => IssueTypeWebhookColor.Red,
                "yellow" => IssueTypeWebhookColor.Yellow,
                _ => null,
            };
        }
    }
}