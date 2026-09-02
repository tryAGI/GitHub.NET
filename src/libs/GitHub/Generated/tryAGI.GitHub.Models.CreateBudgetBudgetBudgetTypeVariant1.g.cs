
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateBudgetBudgetBudgetTypeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        ProductPricing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBudgetBudgetBudgetTypeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBudgetBudgetBudgetTypeVariant1 value)
        {
            return value switch
            {
                CreateBudgetBudgetBudgetTypeVariant1.ProductPricing => "ProductPricing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBudgetBudgetBudgetTypeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "ProductPricing" => CreateBudgetBudgetBudgetTypeVariant1.ProductPricing,
                _ => null,
            };
        }
    }
}