
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum BillingCreateOrganizationBudgetRequestBudgetTypeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        ProductPricing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingCreateOrganizationBudgetRequestBudgetTypeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingCreateOrganizationBudgetRequestBudgetTypeVariant2 value)
        {
            return value switch
            {
                BillingCreateOrganizationBudgetRequestBudgetTypeVariant2.ProductPricing => "ProductPricing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingCreateOrganizationBudgetRequestBudgetTypeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "ProductPricing" => BillingCreateOrganizationBudgetRequestBudgetTypeVariant2.ProductPricing,
                _ => null,
            };
        }
    }
}