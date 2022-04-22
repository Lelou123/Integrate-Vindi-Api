
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace Api_Vindi.Models.Services
{
    public class GetBill
    {
        public string BillDate { get; set; }
        public string Status { get; set; }
        public string PlanName { get; set; }
        

        public async Task<RestResponse> GetBillDate(int clienteId)
        {
            string url = "https://sandbox-app.vindi.com.br/api/v1";

            var client = new RestClient(url)
            {
                Authenticator = new HttpBasicAuthenticator("4jgJEoE3M2B7_TExiEwKG4SOJ6bRABgQgf_qlPeCIl8", ""),
            };

            var request = new RestRequest($"/bills/?query=customer_id={clienteId}", Method.Get);

            var response = await client.ExecuteAsync(request);

            string json = response.Content;
            dynamic dados = JsonConvert.DeserializeObject<dynamic>(json).bills[0];
            string end_at = dados.created_at.ToString();
            var parsedData = DateTime.Parse(end_at);
            var newdate = parsedData.AddMonths(1);

            string product_name = dados.bill_items[0].product.name.ToString();
            string status = dados.status.ToString();
            BillDate = newdate.ToString();
            
            
            
            Status = status;
            PlanName = product_name;
            
            
            return new RestResponse();
        }
    }
}
