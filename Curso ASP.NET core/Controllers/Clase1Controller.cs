using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_ASP.NET_core.Controllers
{
    public class Clase1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
