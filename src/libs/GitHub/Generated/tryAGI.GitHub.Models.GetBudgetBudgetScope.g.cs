
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of scope for the budget<br/>
    /// Example: enterprise
    /// </summary>
    public enum GetBudgetBudgetScope
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
    public static class GetBudgetBudgetScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBudgetBudgetScope value)
        {
            return value switch
            {
                GetBudgetBudgetScope.CostCenter => "cost_center",
                GetBudgetBudgetScope.Enterprise => "enterprise",
                GetBudgetBudgetScope.MultiUserCostCenter => "multi_user_cost_center",
                GetBudgetBudgetScope.MultiUserCustomer => "multi_user_customer",
                GetBudgetBudgetScope.Organization => "organization",
                GetBudgetBudgetScope.Repository => "repository",
                GetBudgetBudgetScope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBudgetBudgetScope? ToEnum(string value)
        {
            return value switch
            {
                "cost_center" => GetBudgetBudgetScope.CostCenter,
                "enterprise" => GetBudgetBudgetScope.Enterprise,
                "multi_user_cost_center" => GetBudgetBudgetScope.MultiUserCostCenter,
                "multi_user_customer" => GetBudgetBudgetScope.MultiUserCustomer,
                "organization" => GetBudgetBudgetScope.Organization,
                "repository" => GetBudgetBudgetScope.Repository,
                "user" => GetBudgetBudgetScope.User,
                _ => null,
            };
        }
    }
}