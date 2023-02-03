using Microsoft.AspNetCore.Mvc;

namespace _03_MVC_ASP_NET_CORE.Controllers
{
    public class PruebaController : Controller
    {
        public IActionResult PrimeraPagina()
        {
            return View();
        }
    }
}
