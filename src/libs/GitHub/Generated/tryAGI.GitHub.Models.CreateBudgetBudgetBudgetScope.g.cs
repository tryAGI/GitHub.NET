
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of scope for the budget<br/>
    /// Example: enterprise
    /// </summary>
    public enum CreateBudgetBudgetBudgetScope
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
    public static class CreateBudgetBudgetBudgetScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBudgetBudgetBudgetScope value)
        {
            return value switch
            {
                CreateBudgetBudgetBudgetScope.CostCenter => "cost_center",
                CreateBudgetBudgetBudgetScope.Enterprise => "enterprise",
                CreateBudgetBudgetBudgetScope.MultiUserCostCenter => "multi_user_cost_center",
                CreateBudgetBudgetBudgetScope.MultiUserCustomer => "multi_user_customer",
                CreateBudgetBudgetBudgetScope.Organization => "organization",
                CreateBudgetBudgetBudgetScope.Repository => "repository",
                CreateBudgetBudgetBudgetScope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBudgetBudgetBudgetScope? ToEnum(string value)
        {
            return value switch
            {
                "cost_center" => CreateBudgetBudgetBudgetScope.CostCenter,
                "enterprise" => CreateBudgetBudgetBudgetScope.Enterprise,
                "multi_user_cost_center" => CreateBudgetBudgetBudgetScope.MultiUserCostCenter,
                "multi_user_customer" => CreateBudgetBudgetBudgetScope.MultiUserCustomer,
                "organization" => CreateBudgetBudgetBudgetScope.Organization,
                "repository" => CreateBudgetBudgetBudgetScope.Repository,
                "user" => CreateBudgetBudgetBudgetScope.User,
                _ => null,
            };
        }
    }
}