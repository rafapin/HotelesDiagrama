using Hoteles.Shared;
using System;
using System.Collections.Generic;

namespace Hoteles.AV.Response
{
    public class CircuitoAV
    {
        public int CircuitoId { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int? NumeroDias { get; set; }

        public decimal? ValorDesde { get; set; }

        public string Descripcion { get; set; }

        public string Nombre { get; set; }

        public bool Activo { get; set; }
        public IEnumerable<ItinerarioAV> Itinerarios { get; set; }
        public IEnumerable<RangoFechaCircuito> RangosFechaCircuito { get; set; }
        public CategoriaCircuito CategoriaCircuito { get; set; }
        public int CategoriaCircuitoId { get; set; }
        public TipoMoneda TipoMoneda { get; set; }
        public int TipoMonedaId { get; set; }
        public int LimiteEdadInfante { get; set; }
        public int LimiteEdadMenor { get; set; }
        public int LimiteEdadAdulto { get; set; }
        public string TextoLegal { get; set; }
        public EmpresaAV Empresa { get; set; }
        public int EmpresaId { get; set; }
    }
    public class CicuitoFilter
    {
        public DateTime? FechaInicio { get; set; }
        public DateTime? Fechafin { get; set; }
        public int DestinoId { get; set; }
    }
}