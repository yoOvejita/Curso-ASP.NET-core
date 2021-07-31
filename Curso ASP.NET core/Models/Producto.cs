using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_ASP.NET_core.Models
{
    /*
     Usado para la Clase 5
     */
    [Table("Producto")]
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public string imagen { get; set; }

        //NOTA: Nunca olvides que, si vas a trabajar con un formulario (osea usando un modelo) en la vista, debes agregar ese modelo/entidad en dicha vista con @model 
    }
}
