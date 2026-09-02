
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The scope of the budget for this organization.<br/>
    /// - `organization`: Apply the budget to the organization.<br/>
    /// - `repository`: Apply the budget to a specific repository in the organization.<br/>
    /// - `multi_user_customer`: Apply a universal budget to all users in the organization.<br/>
    /// - `user`: Apply the budget to a single user in the organization.
    /// </summary>
    public enum BillingUpdateBudgetOrgRequestBudgetScope
    {
        /// <summary>
        ///
        /// </summary>
        CostCenter,
        /// <summary>
        ///
        /// </summary>
        Enterprise,
        /// <summary>
        /// Apply a universal budget to all users in the organization.
        /// </summary>
        MultiUserCustomer,
        /// <summary>
        /// Apply the budget to the organization.
        /// </summary>
        Organization,
        /// <summary>
        /// Apply the budget to a specific repository in the organization.
        /// </summary>
        Repository,
        /// <summary>
        /// Apply a universal budget to all users in the organization.
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingUpdateBudgetOrgRequestBudgetScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingUpdateBudgetOrgRequestBudgetScope value)
        {
            return value switch
            {
                BillingUpdateBudgetOrgRequestBudgetScope.CostCenter => "cost_center",
                BillingUpdateBudgetOrgRequestBudgetScope.Enterprise => "enterprise",
                BillingUpdateBudgetOrgRequestBudgetScope.MultiUserCustomer => "multi_user_customer",
                BillingUpdateBudgetOrgRequestBudgetScope.Organization => "organization",
                BillingUpdateBudgetOrgRequestBudgetScope.Repository => "repository",
                BillingUpdateBudgetOrgRequestBudgetScope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingUpdateBudgetOrgRequestBudgetScope? ToEnum(string value)
        {
            return value switch
            {
                "cost_center" => BillingUpdateBudgetOrgRequestBudgetScope.CostCenter,
                "enterprise" => BillingUpdateBudgetOrgRequestBudgetScope.Enterprise,
                "multi_user_customer" => BillingUpdateBudgetOrgRequestBudgetScope.MultiUserCustomer,
                "organization" => BillingUpdateBudgetOrgRequestBudgetScope.Organization,
                "repository" => BillingUpdateBudgetOrgRequestBudgetScope.Repository,
                "user" => BillingUpdateBudgetOrgRequestBudgetScope.User,
                _ => null,
            };
        }
    }
}