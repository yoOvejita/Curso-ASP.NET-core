using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Curso_ASP.NET_core.Models
{
    public class Cuenta
    {
        [Required]
        [MinLength(3)]
        [MaxLength(40)]
        public string nombre { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string password { get; set; }
        [Required]
        [Range(18, 55)]
        public int edad { get; set; }
        [Required]
        [EmailAddress]
        public string correo { get; set; }//abc@bla.algo
        [Url]
        public string pagina { get; set; }//cosa://algo.noseque.bla
    }
}
