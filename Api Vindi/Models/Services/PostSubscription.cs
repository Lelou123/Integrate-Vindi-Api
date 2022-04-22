using Api_Vindi.Models.Clientes;
using Api_Vindi.Models.Produto;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System.Threading.Tasks;


namespace Api_Vindi.Models.Services
{
    public class PostSubscription
    {
        public string Conteudo { get; set; }
        public string Status { get; set; }
        public string DeleteStatus { get; set; }
        public async Task<RestRequest> CreateSubscriptionBasic(int clienteId)
        {
            SubscriptionBasic subscriptionBasic = new();
            subscriptionBasic.customer_id = clienteId;


            ProductItemsbasic productItemsbasic = new();
            subscriptionBasic.product_items = new System.Collections.Generic.List<ProductItemsbasic>
            {
                productItemsbasic
            };

            string url = "https://sandbox-app.vindi.com.br/api/v1";
            var client = new RestClient(url)
            {
                Authenticator = new HttpBasicAuthenticator("4jgJEoE3M2B7_TExiEwKG4SOJ6bRABgQgf_qlPeCIl8", ""),
            };

            var request = new RestRequest("/subscriptions", Method.Post);


            var body = new SubscriptionBasic()
            {
                plan_id = subscriptionBasic.plan_id,
                customer_id = subscriptionBasic.customer_id,
                payment_method_code = subscriptionBasic.payment_method_code,
                product_items = subscriptionBasic.product_items
            };

            request.AddJsonBody(body);

            var response = await client.PostAsync(request);
            

            Conteudo = response.Content;
            Status = response.StatusCode.ToString();

            return new RestRequest();
        }


        public async Task<RestRequest> CreateSubscriptionPremium(int clienteId)
        {
            SubscriptionPremium subscriptionPremium = new();
            subscriptionPremium.customer_id = clienteId;


            ProductItemspremium productItemspremium = new();
            subscriptionPremium.product_items = new System.Collections.Generic.List<ProductItemspremium>
            {
                productItemspremium
            };

            string url = "https://sandbox-app.vindi.com.br/api/v1";
            var client = new RestClient(url)
            {
                Authenticator = new HttpBasicAuthenticator("4jgJEoE3M2B7_TExiEwKG4SOJ6bRABgQgf_qlPeCIl8", ""),
            };

            var request = new RestRequest("/subscriptions", Method.Post);


            var body = new SubscriptionPremium()
            {
                plan_id = subscriptionPremium.plan_id,
                customer_id = subscriptionPremium.customer_id,
                payment_method_code = subscriptionPremium.payment_method_code,
                product_items = subscriptionPremium.product_items
            };

            request.AddJsonBody(body);

            var response = await client.PostAsync(request);


            Conteudo = response.Content;
            Status = response.StatusCode.ToString();

            return new RestRequest();
        }



        public async Task<RestRequest> DeleteSubscription(int planId)
        {
            
            string url = "https://sandbox-app.vindi.com.br/api/v1";
            var client = new RestClient(url)
            {
                Authenticator = new HttpBasicAuthenticator("4jgJEoE3M2B7_TExiEwKG4SOJ6bRABgQgf_qlPeCIl8", ""),
            };
            
            var request = new RestRequest($"/subscriptions/{planId}", Method.Delete);

            var response = await client.ExecuteAsync(request);

            Conteudo = response.Content;
            Status = response.StatusCode.ToString();

            string json = response.Content;
            dynamic dados = JsonConvert.DeserializeObject<dynamic>(json).subscriptions[0];
            
            string status = dados.status.ToString();
            DeleteStatus = status;

            return new RestRequest();
        }

    }
}
