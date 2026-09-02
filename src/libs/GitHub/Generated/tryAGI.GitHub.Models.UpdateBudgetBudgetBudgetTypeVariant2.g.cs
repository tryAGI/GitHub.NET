
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateBudgetBudgetBudgetTypeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        SkuPricing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateBudgetBudgetBudgetTypeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateBudgetBudgetBudgetTypeVariant2 value)
        {
            return value switch
            {
                UpdateBudgetBudgetBudgetTypeVariant2.SkuPricing => "SkuPricing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateBudgetBudgetBudgetTypeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "SkuPricing" => UpdateBudgetBudgetBudgetTypeVariant2.SkuPricing,
                _ => null,
            };
        }
    }
}