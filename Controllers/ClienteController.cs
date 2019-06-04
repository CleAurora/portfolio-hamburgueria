using Hamburgueria.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hamburgueria.Controllers
{
    public class ClienteController: Controller
    {
        private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE = "_CLIENTE";//atribui a chave

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            var usuario = form["email"];
            var senha = form["senha"];

            var cliente = clienteRepositorio.ObterPor(usuario);

            if (cliente != null && cliente.Senha.Equals(senha)){
                HttpContext.Session.SetString(SESSION_EMAIL, usuario);
                HttpContext.Session.SetString(SESSION_CLIENTE, cliente.Nome);//atribui o valor

            }
            return RedirectToAction("Index", "Home");
        }
    }
}