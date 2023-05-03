using Microsoft.AspNetCore.Mvc;
using WebApp_Tarde.Entidades;

namespace WebApp_Tarde.Controllers
{
    public class CategoriasController : Controller
    {
        private Contexto contexto;

        public CategoriasController(Contexto db)
        {
            contexto = db;
        }

        public IActionResult Lista()
        {
            return View(contexto.CATEGORIAS.ToList());
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarDados(CategoriaEntidade dados)
        {
            contexto.CATEGORIAS.Add(dados);
            contexto.SaveChanges();
            return RedirectToAction("Lista");
        }
    }
}
