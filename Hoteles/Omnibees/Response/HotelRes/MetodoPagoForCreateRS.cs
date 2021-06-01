using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response.HotelRes
{
    public class MetodoPagoForCreateRS
    {
        public int MetodoId { get; set; }
        public decimal Valor { get; set; }
        public int Cuotas { get; set; }
    }
}
