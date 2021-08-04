using Curso_ASP.NET_core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_ASP.NET_core.Controllers
{
    public class Clase12Controller : Controller
    {
        private MiContexto db;
        public Clase12Controller(MiContexto db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            ViewBag.productitos = db.Productos.ToList();
            return View();
        }
        [HttpGet]
        public IActionResult Editar(int id) {
            //¿Cómo lleno el formulario "Editar" con
            //campos del registro de id "id"?-
            ViewBag.prod = db.Productos.
                Select(pr => pr).
                Where(pr => pr.id == id).
                ToList().
                FirstOrDefault();
            return View();
        }

        [HttpPost]
        public IActionResult Editar(Producto prd) {
            db.Entry(prd).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Eliminar(int id) {
            db.Productos.Remove(db.Productos.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
