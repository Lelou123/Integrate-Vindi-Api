using Api_Vindi.Models.Clientes;
using Api_Vindi.Models.Produto;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System.Threading.Tasks;


namespace Api_Vindi.Models.Services
{
    public class PostBill
    {
        public string Conteudo { get; set; }
        public string Status { get; set; }

        public async Task<RestRequest> CreateBillBasic(int clienteId)
        {
            BillBasic billBasic = new();
            billBasic.customer_id = clienteId;
            
            BillItemsBasic billItemsBasic = new BillItemsBasic();

            billBasic.bill_items = new System.Collections.Generic.List<BillItemsBasic>();
            billBasic.bill_items.Add(billItemsBasic);

            string url = "https://sandbox-app.vindi.com.br/api/v1";
            var client = new RestClient(url)
            {
                Authenticator = new HttpBasicAuthenticator("4jgJEoE3M2B7_TExiEwKG4SOJ6bRABgQgf_qlPeCIl8", ""),
            };

            var request = new RestRequest("/bills", Method.Post);

            var body = new BillBasic()
            {
                customer_id = billBasic.customer_id,
                payment_method_code = billBasic.payment_method_code,
                bill_items = billBasic.bill_items
            };

            request.AddJsonBody(body);

            var response = await client.PostAsync(request);

            Conteudo = response.Content;
            Status = response.StatusCode.ToString();

            return new RestRequest();
        }


        public async Task<RestRequest> CreateBillPremium(int clienteId)
        {
            BillPremium billPremium = new();
            billPremium.customer_id = clienteId;

            BillItemsPremium billItemsPremium = new BillItemsPremium();

            billPremium.bill_items = new System.Collections.Generic.List<BillItemsPremium>();
            billPremium.bill_items.Add(billItemsPremium);

            string url = "https://sandbox-app.vindi.com.br/api/v1";
            var client = new RestClient(url)
            {
                Authenticator = new HttpBasicAuthenticator("4jgJEoE3M2B7_TExiEwKG4SOJ6bRABgQgf_qlPeCIl8", ""),
            };

            var request = new RestRequest("/bills", Method.Post);

            var body = new BillPremium()
            {
                customer_id = billPremium.customer_id,
                payment_method_code = billPremium.payment_method_code,
                bill_items = billPremium.bill_items
            };

            request.AddJsonBody(body);

            var response = await client.PostAsync(request);

            Conteudo = response.Content;
            Status = response.StatusCode.ToString();

            return new RestRequest();
        }
    }
}
