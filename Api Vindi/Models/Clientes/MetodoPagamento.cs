namespace Api_Vindi.Models.Clientes
{
    public class MetodoPagamento
    {
        public string ExpiracaoCartao { get; set; }
        public string NumeroCartao { get; set; }
        public string CVVCartao { get; set; }
        public int PagamentoMetodo { get; set; } = 3300;
        public string CompanhiaMetodo { get; set; }

    }
}
