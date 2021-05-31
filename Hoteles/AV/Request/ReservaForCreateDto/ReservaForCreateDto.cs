using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.AV.Request.ReservaForCreateDto
{
    public class ReservaForCreateDto
    {
        public int PaqueteId { get; set; }

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
        public IEnumerable<TiqueteReservaForCreateDto> Tiquetes { get; set; }
        public IEnumerable<ReservaTourForCreateDto> Toures { get; set; }
        public IEnumerable<CaracteristicaReservaForCreateDto> Caracteristicas { get; set; }
        public ActividadUsuarioDto Eventos { get; set; }
        public int CircuitoId { get; set; }

        public int IdIntegracion { get; set; }
        public int HotelId { get; set; }

        public string dataHabitaciones { get; set; }
    }
}
