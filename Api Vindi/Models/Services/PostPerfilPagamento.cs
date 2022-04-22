using Api_Vindi.Models.Clientes;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System.Threading.Tasks;


namespace Api_Vindi.Models.Services
{
    public class PostPerfilPagamento
    {

        public string Conteudo { get; set; }
        public string Status { get; set; }

        public async Task<RestRequest> CreatePerfilPagamento(Cliente cliente, int clienteId)
        {

            MetodoPagamento metodo = cliente.MetodoPagamento;
            
            metodo.holder_name = cliente.FullName;
            metodo.customer_id = clienteId;

            string url = "https://sandbox-app.vindi.com.br/api/v1";
            var client = new RestClient(url)
            {
                Authenticator = new HttpBasicAuthenticator("4jgJEoE3M2B7_TExiEwKG4SOJ6bRABgQgf_qlPeCIl8", ""),
            };

            var request = new RestRequest("/payment_profiles", Method.Post);


            var body = new MetodoPagamento()
            {
                holder_name = metodo.holder_name,
                card_expiration = metodo.card_expiration,
                card_number = metodo.card_number,
                card_cvv = metodo.card_cvv,
                payment_method_code = metodo.payment_method_code,
                payment_company_code = metodo.payment_company_code,
                customer_id = metodo.customer_id
            };

            request.AddJsonBody(body);

            var response = await client.ExecuteAsync(request);
            
            
            Conteudo = response.Content;
            Status = response.StatusCode.ToString();

            return new RestRequest();
        }
    }
}
