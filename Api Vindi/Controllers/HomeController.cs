using Api_Vindi.Models;
using Api_Vindi.Models.Services;
using Api_Vindi.Models.Produto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Api_Vindi.Data;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Api_Vindi.Models.Clientes;
using RestSharp;
using RestSharp.Authenticators;

namespace Api_Vindi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Api_VindiContext _context;
        public HomeController(ILogger<HomeController> logger, Api_VindiContext context)
        {
            _logger = logger;
            _context = context;
        }



        public IActionResult Index()
        {
            if(User.Identity.IsAuthenticated)
            {
                ViewData["Usuario"] = "Usuario está logado";
                TempData["UsuarioLogado"] = User.Identity.Name;
                return View();
            }
            else
            {
                TempData["mensagemErro"] = null;
                return View();
            }
        }





        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CadastrarUsuario([Bind("Id,Username,Email,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                user.Password = EncryptMethod.ConvertToEncrypt(user.Password);
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }




        [HttpPost]
        public async Task<IActionResult> Logar(string username, string senha, bool manterlogado)
        {
            User usuario = new User();
            // puxar a senha do sql server primeiro e depois usar o converte nela 
            senha = EncryptMethod.ConvertToEncrypt(senha);

            usuario = _context.User.AsNoTracking().FirstOrDefault(x => x.Username == username && x.Password == senha);

            if (usuario != null)
            {
                int usuarioId = usuario.Id;
                string nome = usuario.Username;

                List<Claim> direitosAcesso = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier,usuarioId.ToString()),
                    new Claim(ClaimTypes.Name,nome)
                };                
                var identity = new ClaimsIdentity(direitosAcesso, "Identity.Login");
                var userPrincipal = new ClaimsPrincipal(new[] { identity });

                await HttpContext.SignInAsync(userPrincipal,
                    new AuthenticationProperties
                    {
                        IsPersistent = manterlogado,
                        ExpiresUtc = DateTime.Now.AddHours(1)
                    });

                return RedirectToAction(nameof(PerfilUsuario));
            }

            TempData["MensagemLoginInvalido"] = "Dados de login inválidos.";
            return RedirectToAction(nameof(Index));

        }


        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await HttpContext.SignOutAsync();
            }
            return RedirectToAction("Index", "Home");
        }



        [HttpGet]
        public IActionResult About()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Category()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        /*
        [HttpGet]
        public IActionResult ConcluirCadastro(string plano)
        {
            if (plano == "Premium")
            {

                return View();
            }
            else if (plano == "Basico")
            {
                RedirectToAction(nameof(ConcluirCadastro));
            }
           return RedirectToAction(nameof(PerfilUsuario));
        }
        */


        [HttpGet]
        public IActionResult ConcluirPlanoBasico()
        {

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ConcluirPlanoBasico(Cliente cliente, PlanoBasico pB)
        {

            string url = "https://sandbox-app.vindi.com.br/api/v1/customers";
            var client = new RestClient(url)
            {
                Authenticator = new HttpBasicAuthenticator("4jgJEoE3M2B7_TExiEwKG4SOJ6bRABgQgf_qlPeCIl8", ""),
            };

            var request = new RestRequest();

            var body = new Cliente {Name = cliente.Name, Email = cliente.Email, Registry_Code = cliente.Registry_Code, Code = cliente.Code,
                Notes = cliente.Notes, Address = cliente.Address };

            request.AddJsonBody(body);

            var response = await client.PostAsync(request);

            TempData["Response"] = response.StatusCode.ToString() + " " + response.Content.ToString();

                        
            return View();
        }





        [HttpGet]
        public IActionResult ConcluirPlanoPremium()
        {

            return View();
        }


        [HttpPost]
        public IActionResult ConcluirPlanoPremium(Cliente cliente, PlanoDigitalPlus pPlus)
        {

            string teste = cliente.Registry_Code;

            return View();
        }
        /*
                [HttpPost]
                public IActionResult ConcluirPagamento(Cliente cliente, MetodoPagamento metodo)
                {
                    string teste = cliente.CPF;
                    string teste2 = metodo.CVVCartao;
                    return View();
                }

        */
        public IActionResult ConcluirPagamento()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Noticia1()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Premium()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PerfilUsuario()
        {

            if (User.Identity.IsAuthenticated)
            {
                TempData["UsuarioLogado"] = User.Identity.Name;                

                
                return View();
            }
            return RedirectToAction(nameof(Index));
            
        }
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }


        [HttpGet]
        public IActionResult SearchResult()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
