
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum BillingGetAllBudgetsOrgScope
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
        /// Universal budgets that apply to all users in the organization.
        /// </summary>
        MultiUserCustomer,
        /// <summary>
        /// Budgets scoped to the organization.
        /// </summary>
        Organization,
        /// <summary>
        /// Budgets scoped to a repository.
        /// </summary>
        Repository,
        /// <summary>
        /// Universal budgets that apply to all users in the organization.
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingGetAllBudgetsOrgScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingGetAllBudgetsOrgScope value)
        {
            return value switch
            {
                BillingGetAllBudgetsOrgScope.CostCenter => "cost_center",
                BillingGetAllBudgetsOrgScope.Enterprise => "enterprise",
                BillingGetAllBudgetsOrgScope.MultiUserCustomer => "multi_user_customer",
                BillingGetAllBudgetsOrgScope.Organization => "organization",
                BillingGetAllBudgetsOrgScope.Repository => "repository",
                BillingGetAllBudgetsOrgScope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingGetAllBudgetsOrgScope? ToEnum(string value)
        {
            return value switch
            {
                "cost_center" => BillingGetAllBudgetsOrgScope.CostCenter,
                "enterprise" => BillingGetAllBudgetsOrgScope.Enterprise,
                "multi_user_customer" => BillingGetAllBudgetsOrgScope.MultiUserCustomer,
                "organization" => BillingGetAllBudgetsOrgScope.Organization,
                "repository" => BillingGetAllBudgetsOrgScope.Repository,
                "user" => BillingGetAllBudgetsOrgScope.User,
                _ => null,
            };
        }
    }
}