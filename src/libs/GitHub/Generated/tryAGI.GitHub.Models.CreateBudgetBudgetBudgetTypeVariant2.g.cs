
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateBudgetBudgetBudgetTypeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        SkuPricing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBudgetBudgetBudgetTypeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBudgetBudgetBudgetTypeVariant2 value)
        {
            return value switch
            {
                CreateBudgetBudgetBudgetTypeVariant2.SkuPricing => "SkuPricing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBudgetBudgetBudgetTypeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "SkuPricing" => CreateBudgetBudgetBudgetTypeVariant2.SkuPricing,
                _ => null,
            };
        }
    }
}