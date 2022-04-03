namespace Api_Vindi.Models.Clientes
{
    public class Address
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string Additional_Details { get; set; } = null;
        public string ZipCode { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
