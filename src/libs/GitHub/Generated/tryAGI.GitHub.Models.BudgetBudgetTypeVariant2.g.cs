
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum BudgetBudgetTypeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        ProductPricing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BudgetBudgetTypeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BudgetBudgetTypeVariant2 value)
        {
            return value switch
            {
                BudgetBudgetTypeVariant2.ProductPricing => "ProductPricing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BudgetBudgetTypeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "ProductPricing" => BudgetBudgetTypeVariant2.ProductPricing,
                _ => null,
            };
        }
    }
}