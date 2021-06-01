using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Shared
{
   public class PorcionTerrestrePaquete
    {
        public int Id { get; set; }
        public int PaqueteId { get; set; }
        public int TipoAcomodacionId { get; set; }
        public int TipoCamaId { get; set; }
        public int Capacidad { get; set; }
        public decimal ValorNocheRangoEdad1 { get; set; }
        public decimal ValorNocheRangoEdad2 { get; set; }
        public decimal ValorNocheRangoEdad3 { get; set; }
        public decimal TarifaIva { get; set; }
        public decimal SeguroHotelero { get; set; }
        public decimal AlimentacionNoche { get; set; }
        public decimal ValorImpoconsumo { get; set; }
        public decimal MarkUp { get; set; }
        public decimal TarifaFeeBancario { get; set; }
        public int DisponibilidadInicial { get; set; }
        public int DisponibilidadReal { get; set; }
        public string TipoAcomodacion { get; set; }
        public string TipoCama { get; set; }
        public int TarifaHabitacionId { get; set; }
        public string NombreHab { get; set; }
        public string HotelId { get; set; }
        public string NombreHotel { get; set; }
    }
}
