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
using Newtonsoft.Json;

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
            if (User.Identity.IsAuthenticated)
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
            PostCliente postCliente = new();
            await postCliente.CreateCliente(user);


            if (ModelState.IsValid)
            {
                user.ClienteId = postCliente.ClienteId;
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
            User usuario = new();
            // puxar a senha do sql server primeiro e depois usar o converte nela 
            senha = EncryptMethod.ConvertToEncrypt(senha);

            usuario = _context.User.AsNoTracking().FirstOrDefault(x => x.Username == username && x.Password == senha);

            if (usuario != null)
            {
                int usuarioId = usuario.ClienteId;
                string nome = usuario.Username;

                List<Claim> direitosAcesso = new()
                {
                    new Claim(ClaimTypes.NameIdentifier, usuarioId.ToString()),
                    new Claim(ClaimTypes.Name, nome)
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
        public IActionResult AboutAsync()
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



        [HttpGet]
        public IActionResult ConcluirPlanoBasico()
        {

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ConcluirPlanoBasico(Cliente cliente, bool MinifyBool)
        {

            PostPerfilPagamento postPPagamento = new();
            PostSubscription postSub = new();
            GetPerfilPagamento getPerfil = new();
            PostBill postBill = new();
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);


            int clienteId = int.Parse(userId);

            await getPerfil.GetPerfilPagamentoAsync(clienteId);



            if (getPerfil.ContentLen < 30)
            {
                await postPPagamento.CreatePerfilPagamento(cliente, clienteId);
            }
            if (MinifyBool == true)
            {
                await postSub.CreateSubscriptionBasic(clienteId);
                if (postSub.Status == "Created")
                {
                    TempData["Sucesso"] = "   ";
                }
                else
                {
                    TempData["Falha"] = "   ";
                }
            }
            else
            {
                await postBill.CreateBillBasic(clienteId);
                if (postBill.Status == "Created")
                {
                    TempData["Sucesso"] = "   ";

                }
                else
                {
                    TempData["Falha"] = "   ";
                }
            }

            return View();
        }



        [HttpGet]
        public IActionResult ConcluirPlanoPremium()
        {

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ConcluirPlanoPremiumAsync(Cliente cliente, bool MinifyBool)
        {

            PostPerfilPagamento postPPagamento = new();
            PostSubscription postSub = new();
            GetPerfilPagamento getPerfil = new();
            PostBill postBill = new();

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            int clienteId = int.Parse(userId);

            await getPerfil.GetPerfilPagamentoAsync(clienteId);

            if (getPerfil.ContentLen < 30)
            {
                await postPPagamento.CreatePerfilPagamento(cliente, clienteId);
            }
            if (MinifyBool == true)
            {
                await postSub.CreateSubscriptionPremium(clienteId);
                if (postSub.Status == "Created")
                {
                    TempData["Sucesso"] = "   ";
                }
                else
                {
                    TempData["Falha"] = "   ";
                }
            }
            else
            {
                await postBill.CreateBillPremium(clienteId);
                if (postBill.Status == "Created")
                {
                    TempData["Sucesso"] = "   ";
                }
                else
                {
                    TempData["Falha"] = "   ";
                }
            }

            return View();
        }


        public IActionResult ConcluirPagamento()
        {
            return View();
        }




        [HttpPost]
        public async Task<IActionResult> Desinscrever()
        {

            PostSubscription postSub = new();

            GetSubscription s = new();

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            int clienteId = int.Parse(userId);


            await s.GetSubscriptionId(clienteId);

            int planId = int.Parse(s.PlanId);
            try
            {
                await postSub.DeleteSubscription(planId);
            }
            catch (Exception ex)
            {

            }

            if (postSub.Status == "canceled")
            {
                TempData["sucesso"] = "Cancelado";
            }

            return RedirectToAction(nameof(PerfilUsuario));
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
        public async Task<IActionResult> PerfilUsuario()
        {

            if (User.Identity.IsAuthenticated)
            {
                TempData["UsuarioLogado"] = User.Identity.Name;

                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

                int clienteId = int.Parse(userId);

                GetSubscription s = new();
                try
                {
                    await s.GetSubscriptionDate(clienteId);

                    if (s != null && s.Status != "canceled")
                    {
                        TempData["plandate"] = s.SubDate;
                        TempData["planame"] = s.PlanName;
                    }
                }
                catch (Exception ex)
                {

                }

                GetBill b = new();

                try
                {
                    await b.GetBillDate(clienteId);
                    if (s == null && b.Status == "paid")
                    {
                        TempData["billdate"] = b.BillDate;
                        TempData["billname"] = b.PlanName;

                    }
                }
                catch (Exception ex)
                {

                }

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