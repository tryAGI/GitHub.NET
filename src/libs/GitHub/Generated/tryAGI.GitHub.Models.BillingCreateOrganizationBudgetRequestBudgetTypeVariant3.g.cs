
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum BillingCreateOrganizationBudgetRequestBudgetTypeVariant3
    {
        /// <summary>
        ///
        /// </summary>
        SkuPricing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingCreateOrganizationBudgetRequestBudgetTypeVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingCreateOrganizationBudgetRequestBudgetTypeVariant3 value)
        {
            return value switch
            {
                BillingCreateOrganizationBudgetRequestBudgetTypeVariant3.SkuPricing => "SkuPricing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingCreateOrganizationBudgetRequestBudgetTypeVariant3? ToEnum(string value)
        {
            return value switch
            {
                "SkuPricing" => BillingCreateOrganizationBudgetRequestBudgetTypeVariant3.SkuPricing,
                _ => null,
            };
        }
    }
}