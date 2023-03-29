using Microsoft.AspNetCore.Mvc;

namespace WebApp_Tarde.Controllers
{
    public class FornecedoresController : Controller
    {
        public IActionResult ListaF()
        {
            return View();
        }
        public IActionResult CadastroF()
        {
            return View();
        }
    }
}
