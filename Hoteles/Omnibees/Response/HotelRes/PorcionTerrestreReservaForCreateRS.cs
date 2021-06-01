using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response.HotelRes
{
    public class PorcionTerrestreReservaForCreateRS
    {
        public int TarifaHabitacionId { get; set; }
        public int CantidadPersonasRangoEdad1 { get; set; }
        public int CantidadPersonasRangoEdad2 { get; set; }
        public int CantidadPersonasRangoEdad3 { get; set; }
        public decimal TotalAlojamiento { get; set; }
        public long HabitacionId { get; set; }
    }
}
