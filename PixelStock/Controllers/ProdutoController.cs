using Microsoft.AspNetCore.Mvc;

namespace PixelStock.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarProduto()
        {
            return View();
        }
    }
}
