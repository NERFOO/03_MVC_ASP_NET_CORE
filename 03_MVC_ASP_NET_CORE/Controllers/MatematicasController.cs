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

        public IActionResult ConjeturaCollatz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConjeturaCollatz(int numero)
        {
            List<int> numeros = new List<int>();
            while (numero != 1)
            {
                if (numero % 2 == 0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = numero * 3 + 1;
                }
                numeros.Add(numero);
            }
            return View(numeros);
        }

        public IActionResult TablaMultiplicar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicar(int number)
        {
            List<string> tabla = new List<string>();
            int resultado;

            for(int i = 1; i < 11; i++)
            {
                resultado = i * number;
                tabla.Add(number + " * " + i + " = " + resultado);
            }

            return View(tabla);
        }


    }
}
