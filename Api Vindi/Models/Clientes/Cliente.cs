

using Api_Vindi.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Api_Vindi.Models.Clientes
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }        
        public string Email { get; set; }
        public string Name { get; set; }
        public string Registry_Code { get; set; }
        public string Code { get; set; } = null;
        public string Notes { get; set; } = null;        
        public Address Address { get; set; }
        public MetodoPagamento MetodoPagamento { get; set; }
    }
}
