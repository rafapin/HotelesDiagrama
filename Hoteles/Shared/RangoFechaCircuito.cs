using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Shared
{
    public class RangoFechaCircuito
    {
        public int RangoFechaCircuitoId { get; set; }

        public DateTime FechaSalida { get; set; }

        public DateTime FechaRegreso { get; set; }

        public int CircuitoId { get; set; }
    }
}
