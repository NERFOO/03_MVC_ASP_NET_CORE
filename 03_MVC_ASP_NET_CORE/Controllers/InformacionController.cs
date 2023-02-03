using _03_MVC_ASP_NET_CORE.Models;
using Microsoft.AspNetCore.Mvc;

namespace _03_MVC_ASP_NET_CORE.Controllers
{
    public class InformacionController : Controller
    {
        [HttpGet]
        public IActionResult Index(string variable1, string variable2)
        {
            return View();
        }

        public IActionResult ControladorVista()
        {
            Persona persona = new Persona();
            persona.Nombre = "Jaime";
            persona.Edad = 21;
            persona.Email = "nerfo@gmail.com";

            ViewData["NOMBRE"] = "Jaime";
            ViewBag.Nombre = "NERFO";
            ViewData["EDAD"] = 21;

            return View(persona);
        }

        public IActionResult VistaControladorGet(string app, int? version)
        //(string app,System.Nullable<int> version)
        {
            //CON ESTE METODO M EDEVUELVE EL VALOR O EL PRIMITIVO POR DEFECTO
            //version.GetValueOrDefault();

            //IMAGINEMOS QUE LA OPCION ES OPCIONAL A VECES LA RECIBIMOS Y OTRAS NO
            if (version is not null)
            {
                //ES OPCIONAL
                ViewData["DATOS"] = "Aplication: " + app + ", Version: " + version.GetValueOrDefault();
            }
            else
            {
                ViewData["DATOS"] = "Solo aplicacion " + app;
            }

            return View();
        }

        public IActionResult VistaControladorPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VistaControladorPost(Persona persona) {
            ViewData["DATOS"] = "Nombre: " + persona.Nombre + ", Email: " + persona.Email + ", Edad: " + persona.Edad;

            return View();
        }
    }
}
