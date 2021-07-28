using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_ASP.NET_core.Models
{
    public static class Jsonificador
    {
        //Metodo que convierte objeto a Json
        public static void objetoAjson(ISession sesion, string llave, object objeto) {
            sesion.SetString(llave, JsonConvert.SerializeObject(objeto));
        }
        //Metodo que convierte Json a objeto
        public static Tipo jsonAobjeto<Tipo>(ISession sesion, string llave) {
            var objetito = sesion.GetString(llave);
            return objetito == null ? default(Tipo) : JsonConvert.DeserializeObject<Tipo>(objetito);
        }
    }
}
