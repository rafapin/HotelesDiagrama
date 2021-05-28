using AV.Hoteles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Shared
{
    public class ImagenHabitacion
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public int HabitacionId { get; set; }


        //Foreign Key
        public HabitacionAV habitacion { get; set; }
    }
}
