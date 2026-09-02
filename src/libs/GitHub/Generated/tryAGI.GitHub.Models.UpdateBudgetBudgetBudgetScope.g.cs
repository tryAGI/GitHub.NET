
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of scope for the budget<br/>
    /// Example: enterprise
    /// </summary>
    public enum UpdateBudgetBudgetBudgetScope
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
    public static class UpdateBudgetBudgetBudgetScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateBudgetBudgetBudgetScope value)
        {
            return value switch
            {
                UpdateBudgetBudgetBudgetScope.CostCenter => "cost_center",
                UpdateBudgetBudgetBudgetScope.Enterprise => "enterprise",
                UpdateBudgetBudgetBudgetScope.MultiUserCostCenter => "multi_user_cost_center",
                UpdateBudgetBudgetBudgetScope.MultiUserCustomer => "multi_user_customer",
                UpdateBudgetBudgetBudgetScope.Organization => "organization",
                UpdateBudgetBudgetBudgetScope.Repository => "repository",
                UpdateBudgetBudgetBudgetScope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateBudgetBudgetBudgetScope? ToEnum(string value)
        {
            return value switch
            {
                "cost_center" => UpdateBudgetBudgetBudgetScope.CostCenter,
                "enterprise" => UpdateBudgetBudgetBudgetScope.Enterprise,
                "multi_user_cost_center" => UpdateBudgetBudgetBudgetScope.MultiUserCostCenter,
                "multi_user_customer" => UpdateBudgetBudgetBudgetScope.MultiUserCustomer,
                "organization" => UpdateBudgetBudgetBudgetScope.Organization,
                "repository" => UpdateBudgetBudgetBudgetScope.Repository,
                "user" => UpdateBudgetBudgetBudgetScope.User,
                _ => null,
            };
        }
    }
}