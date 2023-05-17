using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Transactions;
using WebApp_Tarde.Entidades;
using WebApp_Tarde.Models;

namespace WebApp_Tarde.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly Contexto db;

        public ProdutosController(Contexto opt)
        {
            db = opt;
        }

        public IActionResult ListaP()
        {
            return View(db.Produtos.Include(a => a.Categoria).ToList() );
        }
        public IActionResult CadastroP()
        {
            NovoProdutoViewModel model = new NovoProdutoViewModel();
            model.Lista_Categorias = db.CATEGORIAS.ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult SalvarDados(ProdutoEntidade produto)
        {
            db.Produtos.Add(produto);
            db.SaveChanges();
            return RedirectToAction("ListaP");
        }
    }
}
