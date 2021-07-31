using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_ASP.NET_core.Models
{
    public class MiContexto : DbContext
    {
        public MiContexto() { }
        public MiContexto(DbContextOptions<MiContexto> opciones) : base(opciones){ }

        public virtual DbSet<Producto> Productos { get; set; }
    }
}
