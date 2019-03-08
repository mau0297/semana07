using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaExamen.Collections
{
    public class Renta
    {
        public Renta(DateTime start_date, DateTime end_date, DateTime return_date, int delay_days, IList<Pelicula> pelicula)
        {
            this.start_date = start_date;
            this.end_date = end_date;
            this.return_date = return_date;
            this.delay_days = delay_days;
            this.pelicula = pelicula;
        }

        public DateTime start_date { get; set; }

        public DateTime end_date { get; set; }

        public DateTime return_date { get; set; }

        public int delay_days { get; set; }

        public IList <Pelicula> pelicula { get; set; }

    }
}