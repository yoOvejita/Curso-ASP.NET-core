using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_ASP.NET_core.Models
{
    public class Estudiante
    {
        public int id { get; set; }//Atributo identificador, solo lo pongo por traumas de bases de datos, no es obligatorio de los modelos
        public string nombre { get; set; }//un atributo del tipo cadena
        public DateTime fechaNac { get; set; } //Este tipo de dato también se puede enviar junto a las primitivas vistas en ViewBag simple... observe cómo debe manejarse
    }
}
