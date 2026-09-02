
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum BudgetBudgetTypeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        SkuPricing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BudgetBudgetTypeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BudgetBudgetTypeVariant1 value)
        {
            return value switch
            {
                BudgetBudgetTypeVariant1.SkuPricing => "SkuPricing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BudgetBudgetTypeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "SkuPricing" => BudgetBudgetTypeVariant1.SkuPricing,
                _ => null,
            };
        }
    }
}