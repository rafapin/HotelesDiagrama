using AV.Response.Hoteles;
using Hoteles.Shared;
using System;
using System.Collections.Generic;

namespace Hoteles.AV.Response
{
    public class ItinerarioAV
    {
        public int ItinerarioId { get; set; }

        public string UsuarioCreador { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int DestinoId { get; set; }
        public Destino Destino { get; set; }

        public int? NumeroDias { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public bool Activo { get; set; }
        public int HotelId { get; set; }
        public HotelAV Hotel { get; set; }
        public int? CategoriaCircuitoId { get; set; }
        public CategoriaCircuito CategoriaCirciuto { get; set; }
        public IEnumerable<DiaItinerarioAV> DiasItinerario { get; set; }
    }
}