using System.ComponentModel.DataAnnotations;

namespace Api_Vindi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "É necessario preencher o seu nome de usuario ")]        
        public string Username { get; set; }

        

        [Required(ErrorMessage = "É necessario preencher o seu email")]
        [EmailAddress(ErrorMessage ="Insira um Email Valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "É necessario preencher A sua senha")]
        [MinLength(5, ErrorMessage = "Sua senha deve ter no minimo 5 caracteres")]
        public string Password { get; set; }

        public int ClienteId { get; set; }
        public User()
        {
        }

        public User(int id, string username, string email)
        {
            Id = id;
            Username = username;
            Email = email;
        }

		
	}
}
