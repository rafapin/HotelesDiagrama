using System;

namespace Hoteles.AV.Response
{
    public class SitioInteresPorDiaAV
    {
        public int DiaItinerarioId { get; set; }

        public int SitioInteresId { get; set; }

        public TimeSpan HoraVisita { get; set; }

        public int? TiempoVisita { get; set; }

        public string TravelMode { get; set; }

        public int? DuracionSegundos { get; set; }

        public string DuracionTexto { get; set; }
        public int TipoProducto { get; set; }
        public TourAV Tour { get; set; }
        public SitioInteresAV SitioInteres { get; set; }
    }
}