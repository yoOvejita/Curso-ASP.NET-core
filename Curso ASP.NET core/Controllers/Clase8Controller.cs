using Curso_ASP.NET_core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_ASP.NET_core.Controllers
{
    public class Clase8Controller : Controller
    {
        public IActionResult Index()
        {

            HttpContext.Session.SetString("nombre", "Pepe");
            HttpContext.Session.SetInt32("numero", 77);


            //Uso de la clase estática Jsonificador para enviar objetos
            Estudiante est = new Estudiante() { 
                id = 23,
                nombre = "Ana",
                fechaNac = new DateTime()
            };
            Jsonificador.objetoAjson(HttpContext.Session, "estudiante", est);
            return View();
        }
    }
}
