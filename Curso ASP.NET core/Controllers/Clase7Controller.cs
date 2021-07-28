using Curso_ASP.NET_core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_ASP.NET_core.Controllers
{
    public class Clase7Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Ya que no devuelve ActionResult, no es un método acción 
        //Es un simple método.
        public ContentResult Ejemplo1() {
            return Content("Este es el elemplo 1", "text/plain");
        }

        
        public ContentResult Ejemplo2(string id)
        {
            return Content("El ejemplo 2 te saluda " + id, "text/plain");
        }

        public IActionResult Ejemplo3()
        {
            Estudiante est = new Estudiante() {
                id = 7,
                nombre = "Sofia Peralta",
                fechaNac = new DateTime(1999,4,5)
            };
            return new JsonResult(est);
        }

        public IActionResult Ejemplo4()
        {

            List<Estudiante> listEst = new List<Estudiante>() {
            new Estudiante(){
                id = 1,
                nombre = "Sofia Peralta",
                fechaNac = new DateTime(1999, 4, 5)
            },
            new Estudiante(){
                id = 2,
                nombre = "Pepe Pepales",
                fechaNac = new DateTime(1999, 12, 25)
            },
            new Estudiante(){
                id = 3,
                nombre = "Ana Mendez",
                fechaNac = new DateTime(1987, 1, 5)
            },
            new Estudiante(){
                id = 4,
                nombre = "Juan Ramos",
                fechaNac = new DateTime(1990, 2, 15)
            }
        };
           
            return new JsonResult(listEst);
        }
    }
}
