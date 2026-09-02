
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum BillingCreateOrganizationBudgetRequestBudgetTypeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        BundlePricing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingCreateOrganizationBudgetRequestBudgetTypeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingCreateOrganizationBudgetRequestBudgetTypeVariant1 value)
        {
            return value switch
            {
                BillingCreateOrganizationBudgetRequestBudgetTypeVariant1.BundlePricing => "BundlePricing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingCreateOrganizationBudgetRequestBudgetTypeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "BundlePricing" => BillingCreateOrganizationBudgetRequestBudgetTypeVariant1.BundlePricing,
                _ => null,
            };
        }
    }
}