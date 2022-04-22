
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace Api_Vindi.Models.Services
{
    public class GetSubscription
    {
       
        public string SubDate { get; set; }
        public string PlanId { get; set; }
        public string PlanName { get; set; }
        public string Status { get; set; }

        public async Task<RestResponse> GetSubscriptionDate(int clienteId)
        {
            string url = "https://sandbox-app.vindi.com.br/api/v1";

            var client = new RestClient(url)
            {
                Authenticator = new HttpBasicAuthenticator("4jgJEoE3M2B7_TExiEwKG4SOJ6bRABgQgf_qlPeCIl8", ""),
            };

            var request = new RestRequest($"/subscriptions/?query=customer_id={clienteId}", Method.Get);

            var response = await client.ExecuteAsync(request);

            string json = response.Content;
            dynamic dados = JsonConvert.DeserializeObject<dynamic>(json).subscriptions[0];
            string end_at = dados.end_at.ToString();
            string status = dados.status.ToString();
            string planName = dados.plan.name.ToString();

            SubDate = end_at;
            PlanName = planName;
            Status = status;
            return new RestResponse();
        }


        public async Task<RestResponse> GetSubscriptionId(int clienteId)
        {
            string url = "https://sandbox-app.vindi.com.br/api/v1";

            var client = new RestClient(url)
            {
                Authenticator = new HttpBasicAuthenticator("4jgJEoE3M2B7_TExiEwKG4SOJ6bRABgQgf_qlPeCIl8", ""),
            };

            var request = new RestRequest($"/subscriptions/?query=customer_id={clienteId}", Method.Get);

            var response = await client.ExecuteAsync(request);


            string json = response.Content;
            dynamic dados = JsonConvert.DeserializeObject<dynamic>(json).subscriptions[0];
            string planId = dados.id.ToString();

            PlanId = planId;
            
            return new RestResponse();
        }


    }
}
