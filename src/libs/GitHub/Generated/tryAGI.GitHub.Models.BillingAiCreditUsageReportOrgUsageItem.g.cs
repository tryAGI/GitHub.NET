
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingAiCreditUsageReportOrgUsageItem
    {
        /// <summary>
        /// Product name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Product { get; set; }

        /// <summary>
        /// SKU name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sku")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sku { get; set; }

        /// <summary>
        /// Model name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Unit type of the usage line item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unitType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UnitType { get; set; }

        /// <summary>
        /// Price per unit of the usage line item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricePerUnit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PricePerUnit { get; set; }

        /// <summary>
        /// Gross quantity of the usage line item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grossQuantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double GrossQuantity { get; set; }

        /// <summary>
        /// Gross amount of the usage line item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grossAmount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double GrossAmount { get; set; }

        /// <summary>
        /// Discount quantity of the usage line item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discountQuantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DiscountQuantity { get; set; }

        /// <summary>
        /// Discount amount of the usage line item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discountAmount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DiscountAmount { get; set; }

        /// <summary>
        /// Net quantity of the usage line item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("netQuantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NetQuantity { get; set; }

        /// <summary>
        /// Net amount of the usage line item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("netAmount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NetAmount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAiCreditUsageReportOrgUsageItem" /> class.
        /// </summary>
        /// <param name="product">
        /// Product name.
        /// </param>
        /// <param name="sku">
        /// SKU name.
        /// </param>
        /// <param name="model">
        /// Model name.
        /// </param>
        /// <param name="unitType">
        /// Unit type of the usage line item.
        /// </param>
        /// <param name="pricePerUnit">
        /// Price per unit of the usage line item.
        /// </param>
        /// <param name="grossQuantity">
        /// Gross quantity of the usage line item.
        /// </param>
        /// <param name="grossAmount">
        /// Gross amount of the usage line item.
        /// </param>
        /// <param name="discountQuantity">
        /// Discount quantity of the usage line item.
        /// </param>
        /// <param name="discountAmount">
        /// Discount amount of the usage line item.
        /// </param>
        /// <param name="netQuantity">
        /// Net quantity of the usage line item.
        /// </param>
        /// <param name="netAmount">
        /// Net amount of the usage line item.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingAiCreditUsageReportOrgUsageItem(
            string product,
            string sku,
            string model,
            string unitType,
            double pricePerUnit,
            double grossQuantity,
            double grossAmount,
            double discountQuantity,
            double discountAmount,
            double netQuantity,
            double netAmount)
        {
            this.Product = product ?? throw new global::System.ArgumentNullException(nameof(product));
            this.Sku = sku ?? throw new global::System.ArgumentNullException(nameof(sku));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.UnitType = unitType ?? throw new global::System.ArgumentNullException(nameof(unitType));
            this.PricePerUnit = pricePerUnit;
            this.GrossQuantity = grossQuantity;
            this.GrossAmount = grossAmount;
            this.DiscountQuantity = discountQuantity;
            this.DiscountAmount = discountAmount;
            this.NetQuantity = netQuantity;
            this.NetAmount = netAmount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAiCreditUsageReportOrgUsageItem" /> class.
        /// </summary>
        public BillingAiCreditUsageReportOrgUsageItem()
        {
        }

    }
}