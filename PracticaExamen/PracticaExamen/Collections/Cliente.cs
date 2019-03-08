using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaExamen.Collections
{
    public class Cliente
    {
        public int id { get; set; }

        public string name { get; set; }

        public int phone { get; set; }

        public IList <Renta> renta { get; set; }

    }
}