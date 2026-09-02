
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateBudgetBudgetBudgetTypeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        ProductPricing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateBudgetBudgetBudgetTypeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateBudgetBudgetBudgetTypeVariant1 value)
        {
            return value switch
            {
                UpdateBudgetBudgetBudgetTypeVariant1.ProductPricing => "ProductPricing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateBudgetBudgetBudgetTypeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "ProductPricing" => UpdateBudgetBudgetBudgetTypeVariant1.ProductPricing,
                _ => null,
            };
        }
    }
}