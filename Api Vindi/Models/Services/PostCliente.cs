using Api_Vindi.Models.Clientes;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System.Threading.Tasks;

namespace Api_Vindi.Models.Services
{
    public class PostCliente
    {
        public string Conteudo { get; set; }
        public string Status { get; set; }
        public int ClienteId { get; set; }
        public async Task<RestRequest> CreateCliente(User user)
        {
            string url = "https://sandbox-app.vindi.com.br/api/v1/customers";
            var client = new RestClient(url)
            {
                Authenticator = new HttpBasicAuthenticator("4jgJEoE3M2B7_TExiEwKG4SOJ6bRABgQgf_qlPeCIl8", ""),
            };

            var request = new RestRequest();

            var body = new Cliente
            {
                Id = user.Id,
                Name = user.Username,               
                Email = user.Email                
            };

            request.AddJsonBody(body);

            var response = await client.PostAsync(request);
            string json = response.Content.ToString();

            var cliente1 = JsonConvert.DeserializeObject<Customer>(json);

            ClienteId  = cliente1.Clientes.Id;
            

            Conteudo = response.Content;
            Status = response.StatusCode.ToString();

            return new RestRequest();
        }
    }
}
