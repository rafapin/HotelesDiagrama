using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response.HotelRes
{
    public class CaracteristicaReservaForCreateRS
    {
        public int CaracteristicaId { get; set; }
        public decimal SubTotalPersonas { get; set; }
        public decimal SubTotalCaracteristica { get; set; }
        public decimal ValorFeeBancario { get; set; }
        public decimal TotalCaracteristica { get; set; }
    }
}
