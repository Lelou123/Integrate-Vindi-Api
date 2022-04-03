using Api_Vindi.Models.Clientes;
using Microsoft.Graph;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Threading.Tasks;

namespace Api_Vindi.Models.Services
{
    
    public class GetService
    {
        public int Id { get; set; }
        public string GetContent { get; set; }
        public async Task GetRequestAsync()
        {
            string url = "https://sandbox-app.vindi.com.br/api/v1/customers";

            var client = new RestClient(url)
            {
                Authenticator = new HttpBasicAuthenticator("4jgJEoE3M2B7_TExiEwKG4SOJ6bRABgQgf_qlPeCIl8", ""),
            };

            var request = new RestRequest();
           
            var response = await client.ExecuteAsync(request);
            GetContent = response.Content.ToString();            
        }
        


        public async Task PostRequest()
        {
            string url = "https://sandbox-app.vindi.com.br/api/v1/customers";
            var client = new RestClient(url)
            {
                Authenticator = new HttpBasicAuthenticator("4jgJEoE3M2B7_TExiEwKG4SOJ6bRABgQgf_qlPeCIl8", ""),
            };

            var request = new RestRequest();

            var body = new Cliente { Id = 1, Name = "teste" };
            request.AddJsonBody(body);

            var response =  await client.PostAsync(request);

            Console.WriteLine(response.StatusCode.ToString() + "           " + response.Content.ToString());
        }

    }
}
