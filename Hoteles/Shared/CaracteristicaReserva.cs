using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Shared
{
    public class CaracteristicaReserva
    {
        public int CaracteristicaReservaId { get; set; }
        public int ReservaId { get; set; }
        public int CaracteristicaId { get; set; }
        public decimal SubTotalPersonas { get; set; }
        public decimal SubTotalCaracteristica { get; set; }
        public decimal ValorFeeBancario { get; set; }
        public decimal TotalCaracteristica { get; set; }
        public Caracteristica Caracteristica { get; set; }
    }
}
