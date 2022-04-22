using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Api_Vindi.Models.Clientes
{
    public class MetodoPagamento
    {
        [Required]
        [JsonProperty("holder_name")]
        public string holder_name { get; set; }
        
        [Required]
        [MaxLength, MinLength(16, ErrorMessage = "Seu Numero do cartão deve ter 16 digitos")]
        [JsonProperty("card_expiration")]
        public string card_expiration { get; set; }
        
        [Required]        
        [JsonProperty("card_number")]
        [MaxLength, MinLength(16, ErrorMessage = "Seu Numero do cartão deve ter 16 digitos")]
        public string card_number { get; set; }


        [Required]
        [MaxLength(3, ErrorMessage = "Seu cvv deve ter no maximo 3 digitos")]
        [JsonProperty("card_cvv")]
        public string card_cvv { get; set; }


        [JsonProperty("payment_method_code")]
        public string payment_method_code { get; set; } = "credit_card";


        [JsonProperty("payment_company_code")]
        public string payment_company_code { get; set; } = "mastercard";


        [JsonProperty("customer_id")]
        public int customer_id { get; set; }

    }
}
