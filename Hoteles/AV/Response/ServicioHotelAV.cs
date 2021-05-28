using AV.Response.Hoteles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Response.AV
{
    public class ServicioHotelAV
    {
        public int ServicioHotelId { get; set; }
        public int HotelId { get; set; }
        public int ServicioId { get; set; }
        public string Nombre { get; set; }
        public string icon { get; set; }

        public HotelAV hotel { get; set; }
    }
}
