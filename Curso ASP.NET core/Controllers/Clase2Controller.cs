using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_ASP.NET_core.Controllers
{
    public class Clase2Controller : Controller
    {
        public IActionResult Index()
        {
            //Estas 6 líneas se explican en la página /Clase2/Index
            ViewBag.texto = "Un buen texto que tengo acá";
            ViewBag.numero = 777;
            ViewBag.caracter = 'F';
            ViewBag.arreglo = new string[]{ "a", "b", "c", "d"};
            ViewBag.boole = true;
            ViewBag.decim = 3.1416;
            return View();
        }
    }
}
