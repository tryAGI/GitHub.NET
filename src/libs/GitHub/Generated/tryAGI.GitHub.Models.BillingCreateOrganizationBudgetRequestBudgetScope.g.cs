
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The scope of the budget for this organization.<br/>
    /// - `organization`: Apply the budget to the organization.<br/>
    /// - `repository`: Apply the budget to a specific repository in the organization.<br/>
    /// - `multi_user_customer`: Apply a universal budget to all users in the organization.<br/>
    /// - `user`: Apply the budget to a single user in the organization.<br/>
    /// `user` and `multi_user_customer` scopes are only supported when<br/>
    /// `budget_product_sku` is `ai_credits` or `premium_requests`.
    /// </summary>
    public enum BillingCreateOrganizationBudgetRequestBudgetScope
    {
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
    public static class BillingCreateOrganizationBudgetRequestBudgetScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingCreateOrganizationBudgetRequestBudgetScope value)
        {
            return value switch
            {
                BillingCreateOrganizationBudgetRequestBudgetScope.MultiUserCustomer => "multi_user_customer",
                BillingCreateOrganizationBudgetRequestBudgetScope.Organization => "organization",
                BillingCreateOrganizationBudgetRequestBudgetScope.Repository => "repository",
                BillingCreateOrganizationBudgetRequestBudgetScope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingCreateOrganizationBudgetRequestBudgetScope? ToEnum(string value)
        {
            return value switch
            {
                "multi_user_customer" => BillingCreateOrganizationBudgetRequestBudgetScope.MultiUserCustomer,
                "organization" => BillingCreateOrganizationBudgetRequestBudgetScope.Organization,
                "repository" => BillingCreateOrganizationBudgetRequestBudgetScope.Repository,
                "user" => BillingCreateOrganizationBudgetRequestBudgetScope.User,
                _ => null,
            };
        }
    }
}