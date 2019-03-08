using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaExamen.Collections
{
    public class Pelicula
    {
        public Pelicula(string name, DateTime anio, string type)
        {
            this.name = name;
            this.anio = anio;
            this.type = type;
        }

        public string name { get; set; }

        public DateTime anio { get; set; }

        public string type { get; set; }
        
    }
}