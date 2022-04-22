using Newtonsoft.Json;

namespace Api_Vindi.Models.Clientes
{
    public class Customer
    {
        [JsonProperty("customer")]
        public Cliente Clientes { get; set; }
    }
}
