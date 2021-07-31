using Curso_ASP.NET_core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_ASP.NET_core.Controllers
{
    public class Clase10Controller : Controller
    {
        private MiContexto db;
        public Clase10Controller(MiContexto db) {
            this.db = db;
        }
        public IActionResult Index()
        {
            ViewBag.productitos = db.Productos.ToList();//List<Producto>
            return View();
        }
    }
}
