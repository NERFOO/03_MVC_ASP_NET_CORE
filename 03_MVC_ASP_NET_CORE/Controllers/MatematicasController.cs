using Microsoft.AspNetCore.Mvc;

namespace _03_MVC_ASP_NET_CORE.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Menu()
        {
            return View();
        }
        public IActionResult SumarNumerosGet(int num1, int num2)
        {
            ViewData["NUMEROS"] = "Numero 1: " + num1 + ", Numero 2: " + num2 + ", La suma es: " + (num1 + num2);
            return View();
        }

        public IActionResult SumarNumerosPost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SumarNumerosPost(int num1, int num2)
        {
            ViewData["SUMA"] = "La suma es " + (num1 + num2);
            return View();
        }
    }
}
