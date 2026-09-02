
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum BillingUpdateBudgetOrgRequestBudgetTypeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        BundlePricing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingUpdateBudgetOrgRequestBudgetTypeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingUpdateBudgetOrgRequestBudgetTypeVariant1 value)
        {
            return value switch
            {
                BillingUpdateBudgetOrgRequestBudgetTypeVariant1.BundlePricing => "BundlePricing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingUpdateBudgetOrgRequestBudgetTypeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "BundlePricing" => BillingUpdateBudgetOrgRequestBudgetTypeVariant1.BundlePricing,
                _ => null,
            };
        }
    }
}