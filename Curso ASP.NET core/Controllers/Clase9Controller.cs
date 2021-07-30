using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_ASP.NET_core.Controllers
{
    public class Clase9Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string user, string pass)
        {
            string userValido = "PEPEX";
            string passValido = "abc123";
            if (user.Equals(userValido) && pass.Equals(passValido))
            {
                HttpContext.Session.SetString("usuario", user);
                return View("Loggeado");
            }
            else {
                ViewBag.mensaje = "El nombre de usuario y/o la contraseña no son validos.";
                return View("Index");
            }
        }

        public IActionResult Logout() {
            HttpContext.Session.Remove("usuario");
            return View("Index");
        }

        public IActionResult Ejemplo1() {
            return View();
        }
        public IActionResult Ejemplo2()
        {
            return View();
        }
        public IActionResult Ejemplo3()
        {
            return View();
        }
    }
}
