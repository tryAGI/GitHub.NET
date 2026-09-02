
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum BillingUpdateBudgetOrgRequestBudgetTypeVariant3
    {
        /// <summary>
        ///
        /// </summary>
        SkuPricing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingUpdateBudgetOrgRequestBudgetTypeVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingUpdateBudgetOrgRequestBudgetTypeVariant3 value)
        {
            return value switch
            {
                BillingUpdateBudgetOrgRequestBudgetTypeVariant3.SkuPricing => "SkuPricing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingUpdateBudgetOrgRequestBudgetTypeVariant3? ToEnum(string value)
        {
            return value switch
            {
                "SkuPricing" => BillingUpdateBudgetOrgRequestBudgetTypeVariant3.SkuPricing,
                _ => null,
            };
        }
    }
}