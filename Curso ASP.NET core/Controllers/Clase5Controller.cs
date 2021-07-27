using Curso_ASP.NET_core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Curso_ASP.NET_core.Controllers
{
    public class Clase5Controller : Controller
    {
        //Para usar IWebHostEnvironment agregamos el using Microsoft.AspNetCore.Hosting
        IWebHostEnvironment web;
        //Necesitamos el constructor para recibir una interface que tiene datos del entorno del servidor
        public Clase5Controller(IWebHostEnvironment webRecibido) {
            web = webRecibido;
        }
        public IActionResult Index()
        {
            return View("Index", new Producto());
        }

        [HttpPost]
        public IActionResult subir(Producto prod, IFormFile img) {
            //IFormFile es la interface que nos ayuda a recibir binarios desde un formulario
            //Para usarlo debemos agregar el using Microsoft.AspNetCore.Http
            if (img != null && img.Length > 0)
            { //exito
                //Para usar Path debe ponerse using System.IO
                var direccion = Path.Combine(web.WebRootPath, "imagenes", img.FileName);// "imagenes" es el nombre del folder en wwwroot
                var flujo = new FileStream(direccion, FileMode.Create);//Se prepara un flujo de archivo para crear archivo
                img.CopyToAsync(flujo);
                prod.imagen = img.FileName;//Guardamos el nombre de la img en el objeto para luego almacenarlo en una DDBB por ejemplo.
            }
            else
                return Content("No se envió ningun archivo, regrese atrás");
            //Hasta acá ya se guardó la imagen en el servidor, ahora solo mostramos esta imagen del servidor en una vista
            ViewBag.prod = prod;
            return View("Exitoclase5");
        }
    }
}
