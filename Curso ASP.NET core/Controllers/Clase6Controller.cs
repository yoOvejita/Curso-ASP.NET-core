using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Curso_ASP.NET_core.Models;

namespace Curso_ASP.NET_core.Controllers
{
    public class Clase6Controller : Controller
    {
        public IActionResult Index()
        {
            return View("Index", new Cuenta());
        }

        public IActionResult Respuesta(Cuenta cuentaQueLlega) {
            if (ModelState.IsValid)
            {
                ViewBag.cuen = cuentaQueLlega;
                return View("Exitoclase6");
            }
            else
                return View("Index");
        }
    }
}
