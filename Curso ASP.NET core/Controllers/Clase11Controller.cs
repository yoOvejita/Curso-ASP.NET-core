using Curso_ASP.NET_core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_ASP.NET_core.Controllers
{
    public class Clase11Controller : Controller
    {
        private MiContexto db;
        public Clase11Controller(MiContexto db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            
            ViewBag.productitos = db.Productos.ToList();//Linq
            //Sobre consultas (query)
            var elemento = from prod
                           in db.Productos
                           where prod.precio > 20
                           select prod.nombre;
            var resultado = elemento.ToList();

            var elemento2 = db.Productos
                .Where(prod => prod.precio > 20)
                .Select(prod => prod.nombre).ToList();

            
            return View();
        }
        public IActionResult Agregar() {
            //Creación de registros en la Base de Datos.
            return View();
        }

        [HttpGet]
        public IActionResult Otro() {
            return View();
        }

        [HttpPost]
        public IActionResult Otro(Producto produ) {
            db.Productos.Add(produ);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
