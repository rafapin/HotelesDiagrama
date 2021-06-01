using System;
using System.Collections.Generic;

namespace Hoteles.AV.Response
{
    public class DiaItinerarioAV
    {
        public int DiaItinerarioId { get; set; }
        public int ItinerarioId { get; set; }
        public DateTime FechaCreacion { get; set; }

        public int? HorasDisponibles { get; set; }

        public int? HorasOcupadas { get; set; }

        public int NumeroDia { get; set; }

        public bool? IncluyeDesayuno { get; set; }

        public bool? IncluyeAlmuerzo { get; set; }

        public bool? IncluyeCena { get; set; }

        public string Descripcion { get; set; }

        public int? TransporteLlegadaId { get; set; }

        public int? TransporteSalidaId { get; set; }

        public string HoraLlegada { get; set; }

        public string HoraSalida { get; set; }

        public string HoraInicioDia { get; set; }

        public string HoraFinDia { get; set; }

        public int? HotelId { get; set; }

        public IEnumerable<SitioInteresPorDiaAV> SitioInteresPorDia { get; set; }
    }
}