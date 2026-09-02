
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum GetBudgetBudgetTypeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        SkuPricing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetBudgetBudgetTypeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBudgetBudgetTypeVariant2 value)
        {
            return value switch
            {
                GetBudgetBudgetTypeVariant2.SkuPricing => "SkuPricing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBudgetBudgetTypeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "SkuPricing" => GetBudgetBudgetTypeVariant2.SkuPricing,
                _ => null,
            };
        }
    }
}