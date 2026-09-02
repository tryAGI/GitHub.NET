
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The scope of the budget<br/>
    /// Example: enterprise
    /// </summary>
    public enum BudgetBudgetScope
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
        ///
        /// </summary>
        MultiUserCostCenter,
        /// <summary>
        ///
        /// </summary>
        MultiUserCustomer,
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        Repository,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BudgetBudgetScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BudgetBudgetScope value)
        {
            return value switch
            {
                BudgetBudgetScope.CostCenter => "cost_center",
                BudgetBudgetScope.Enterprise => "enterprise",
                BudgetBudgetScope.MultiUserCostCenter => "multi_user_cost_center",
                BudgetBudgetScope.MultiUserCustomer => "multi_user_customer",
                BudgetBudgetScope.Organization => "organization",
                BudgetBudgetScope.Repository => "repository",
                BudgetBudgetScope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BudgetBudgetScope? ToEnum(string value)
        {
            return value switch
            {
                "cost_center" => BudgetBudgetScope.CostCenter,
                "enterprise" => BudgetBudgetScope.Enterprise,
                "multi_user_cost_center" => BudgetBudgetScope.MultiUserCostCenter,
                "multi_user_customer" => BudgetBudgetScope.MultiUserCustomer,
                "organization" => BudgetBudgetScope.Organization,
                "repository" => BudgetBudgetScope.Repository,
                "user" => BudgetBudgetScope.User,
                _ => null,
            };
        }
    }
}