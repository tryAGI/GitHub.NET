
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum BillingUpdateBudgetOrgRequestBudgetTypeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        ProductPricing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingUpdateBudgetOrgRequestBudgetTypeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingUpdateBudgetOrgRequestBudgetTypeVariant2 value)
        {
            return value switch
            {
                BillingUpdateBudgetOrgRequestBudgetTypeVariant2.ProductPricing => "ProductPricing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingUpdateBudgetOrgRequestBudgetTypeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "ProductPricing" => BillingUpdateBudgetOrgRequestBudgetTypeVariant2.ProductPricing,
                _ => null,
            };
        }
    }
}