using Microsoft.AspNetCore.Mvc;
using WebApp_Tarde.Entidades;
using WebApp_Tarde.Models;

namespace WebApp_Tarde.Controllers
{
    public class VendasController : Controller
    {
        private Contexto db;
        public VendasController(Contexto contexto)
        {
            db = contexto;
        }
        public IActionResult Lista()
        {
            NovaVendaViewModel model = new NovaVendaViewModel();
            model.Lista_Produtos = db.Produtos.ToList();
            return View(model);
        }

        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SalvarDados(VendasEntidade dados)
        {
            return RedirectToAction("Lista");
        }
    }
}
