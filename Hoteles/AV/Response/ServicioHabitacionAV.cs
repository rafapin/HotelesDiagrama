using AV.Response.Hoteles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Response.AV
{
    public class ServicioHabitacionAV
    {
        public int ServicioHabitacionId { get; set; }
        public int HabitacionId { get; set; }
        public int ServicioId { get; set; }
        public string Nombre { get; set; }
        public string icon { get; set; }

        //Foreign Key
        public HabitacionAV habitacion { get; set; }
    }
}
