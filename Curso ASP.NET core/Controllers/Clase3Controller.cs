using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Curso_ASP.NET_core.Models;

namespace Curso_ASP.NET_core.Controllers
{
    public class Clase3Controller : Controller
    {
        public IActionResult Index()
        {
            /*
             * Vamos a crear una clase para usarla acá, la clase se llamará Estudiante
             * y tendrá los atributos: id, nombre, fecha de nacimiento.
             * 
             * Para crearlo solo damos click derecho sobre Models, Agregar > clase... y lo guardamos como Estudiante
             * 
             * Vea en el folder de Models para que lo crea
            */

            //Instancio un objeto y lo paso al ViweBag ¡Ojo! Debe incluir using hacia el folder Models para que reconozca directamente la clase Estudiante (y todos los modelos ó entidades ahí halladas) vea la linea 6 de acá
            ViewBag.est = new Estudiante{id=1, nombre = "Pepe", fechaNac = new DateTime()};

            //Ahora para el manejo de arreglos y listas
            ViewBag.arreglo = new string[] {"a", "b", "c", "d" };
            ViewBag.listita = new List<Estudiante>() {
                new Estudiante{id=1, nombre = "Ana", fechaNac = new DateTime(1999,12,24)},
                new Estudiante{id=2, nombre = "Pepe", fechaNac = new DateTime(2001,1,1)},
                new Estudiante{id=3, nombre = "Sofía", fechaNac = new DateTime(2002,4,12)},
                new Estudiante{id=4, nombre = "Sandra", fechaNac = new DateTime(1982,7,14)},
                new Estudiante{id=5, nombre = "Juan", fechaNac = new DateTime(1984,10,10)}
            };
            return View();
        }
    }
}
