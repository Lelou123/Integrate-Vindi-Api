using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api_Vindi.Models.Clientes
{
    public class BillBasic
    {        
        public int customer_id { get; set; }
        public string payment_method_code { get; set; } = "credit_card";

        [JsonProperty("bill_items")]
        public List<BillItemsBasic> bill_items { get; set; }

    }
}
