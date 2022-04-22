using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api_Vindi.Models.Clientes
{
    public class SubscriptionBasic
    {
        public int plan_id { get; set; } = 67494;
        public int customer_id { get; set; }
        public string payment_method_code { get; set; } = "credit_card";

        [JsonProperty("product_items")]
        public List<ProductItemsbasic> product_items { get; set; }
    }
}
