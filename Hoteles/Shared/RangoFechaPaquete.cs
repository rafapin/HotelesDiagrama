using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Shared
{
    public class RangoFechaPaquete
    {
        public int RangoId { get; set; }
        public int PaqueteId { get; set; }

        public DateTime FechaSalida { get; set; }
        public DateTime FechaRegreso { get; set; }
    }
}
