using Api_Vindi.Models.Produto;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api_Vindi.Models.Clientes
{
    public class SubscriptionPremium
    {
        public int plan_id { get; set; } = 67495;
        public int customer_id { get; set; }
        public string payment_method_code { get; set; } = "credit_card";

        [JsonProperty("product_items")]
        public List<ProductItemspremium> product_items { get; set; }
    }
}
