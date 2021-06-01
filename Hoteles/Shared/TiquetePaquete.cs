using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Shared
{
    public class TiquetePaquete
    {
        public int Id { get; set; }
        public int ProveedorId { get; set; }
        public string Nombre { get; set; }
        public string ImagenUrl { get; set; }
        public int Puntaje { get; set; }
        public DateTime FechaVueloIda { get; set; }
        public string HoraVueloIda { get; set; }
        public string HoraArriboIda { get; set; }
        public DateTime FechaVueloRegreso { get; set; }
        public string HoraVueloRegreso { get; set; }
        public decimal TarifaBaseAdulto { get; set; }
        public decimal TarifaBaseMenor { get; set; }
        public decimal TarifaBaseInfante { get; set; }
        public decimal TarifaIva { get; set; }
        public decimal TarifaAdministrativa { get; set; }
        public decimal IvaTarifaAdministrativa { get; set; }
        public decimal TasaPersona { get; set; }
        public decimal ValorMaletaPersona { get; set; }
        public decimal ValorCheckInPersona { get; set; }
        public decimal ValorSillaPersona { get; set; }
        public decimal MarkUp { get; set; }
        public int DisponibilidadInicial { get; set; }
        public int DisponibilidadReal { get; set; }
        public int TiqueteId { get; set; }
    }
}
