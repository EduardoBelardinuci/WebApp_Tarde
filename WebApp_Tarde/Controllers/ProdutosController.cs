using Microsoft.AspNetCore.Mvc;

namespace WebApp_Tarde.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult ListaP()
        {
            return View();
        }
        public IActionResult CadastroP()
        {
            return View();
        }
    }
}
