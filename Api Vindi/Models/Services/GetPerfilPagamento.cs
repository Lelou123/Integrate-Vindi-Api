
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace Api_Vindi.Models.Services
{
    public class GetPerfilPagamento
    {
        public string Conteudo { get; set; }
        public string Status { get; set; }
        public int ContentLen { get; set; }
        public async Task<RestResponse> GetPerfilPagamentoAsync(int clienteId)
        {
            string url = "https://sandbox-app.vindi.com.br/api/v1";

            var client = new RestClient(url)
            {
                Authenticator = new HttpBasicAuthenticator("4jgJEoE3M2B7_TExiEwKG4SOJ6bRABgQgf_qlPeCIl8", ""),
            };

            var request = new RestRequest($"/payment_profiles/?query=customer_id={clienteId}", Method.Get);

            var response = await client.ExecuteAsync(request);

            

            Conteudo = response.Content.ToString();
            Status = response.ResponseStatus.ToString();
            ContentLen = int.Parse(response.ContentLength.ToString());
            return new RestResponse();
        }
    }
}
