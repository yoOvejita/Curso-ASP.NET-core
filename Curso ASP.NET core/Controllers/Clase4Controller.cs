using Curso_ASP.NET_core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_ASP.NET_core.Controllers
{
    public class Clase4Controller : Controller
    {
        public IActionResult Index()
        {
            return View("Index", new Estudiante());
        }

        public IActionResult Recibe(Estudiante estu) {
            ViewBag.est = estu;
            return View("Exitoclase4");
        }
    }
}
