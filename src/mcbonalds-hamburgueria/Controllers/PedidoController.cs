using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mcbonalds_hamburgueria.Controllers
{
    public class PedidoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarPedido(IFormCollection formularioPedido)
        {
            Console.WriteLine($"{formularioPedido["nome"]}, {formularioPedido["endereco"]}, {formularioPedido["telefone"]},{formularioPedido["email"]},{formularioPedido["hamburguer"]}, {formularioPedido["shake"]}");
            
            return RedirectToAction("Index", "Home");
        }
    }
}