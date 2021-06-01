using Hoteles.AV.Request.ReservaForCreateDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response.HotelRes
{
    public class ReservaForCreateRS
    {
        public int PaqueteId { get; set; }

        public int HotelId { get; set; }

        public DateTime FechaEmision { get; set; }

        public int CantidadPersonasRangoEdad1 { get; set; }

        public int CantidadPersonasRangoEdad2 { get; set; }

        public int CantidadPersonasRangoEdad3 { get; set; }

        public decimal ValorTotal { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }
        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public IEnumerable<ViajeroForCreateDto> Viajeros { get; set; }
        public IEnumerable<MetodoPagoForCreateDto> MetodosDePago { get; set; }
        public IEnumerable<PorcionTerrestreReservaForCreateDto> PorcionesTerrestre { get; set; }
        public IEnumerable<CaracteristicaReservaForCreateDto> Caracteristicas { get; set; }
        public int CircuitoId { get; set; }
    }
}
