
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum GetBudgetBudgetTypeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        ProductPricing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetBudgetBudgetTypeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBudgetBudgetTypeVariant1 value)
        {
            return value switch
            {
                GetBudgetBudgetTypeVariant1.ProductPricing => "ProductPricing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBudgetBudgetTypeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "ProductPricing" => GetBudgetBudgetTypeVariant1.ProductPricing,
                _ => null,
            };
        }
    }
}