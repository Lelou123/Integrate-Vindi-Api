

using Api_Vindi.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Api_Vindi.Models.Clientes
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "É necessario preencher o seu email")]
        [EmailAddress(ErrorMessage = "Insira um Email Valido")]
        public string FullName { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "É necessario preencher o seu nome Completo ")]
        [MinLength(3, ErrorMessage = "Sua senha deve ter no minimo 3 caracteres")]
        public string Name { get; set; }

        public string Registry_Code { get; set; }
        public string Code { get; set; } = null;
        public string Notes { get; set; } = null;        
        public Address Address { get; set; }
        public MetodoPagamento MetodoPagamento { get; set; }
    }
}
