using Hoteles.Shared;
using System;

namespace Hoteles.AV.Response
{
    public class FormaPagoAV
    {
        public int FormaPagoId { get; set; }
        public int MetodoId { get; set; }
        public string MetodoDescripcion { get; set; }
        public decimal Valor { get; set; }
        public int Cuotas { get; set; }
        public EstadoMetodoPago EstadoMetodoPagoId { get; set; }
        //public int EstadoMetodoPagoId { get; set; }
        public string EstadoMetodoPago { get; set; }
        public int? Empleador { get; set; }
        public decimal? ValorCuotaMaxima { get; set; }
        public string PIN { get; set; }
        public string NAprobacion { get; set; }
        public string Observaciones { get; set; }
        public int? CantidadCuotaInicial { get; set; }
        public decimal? ValorCuotaInicial { get; set; }
        public decimal? PorcentajeCuotaInicial { get; set; }
        public decimal? SubTotalCuotaInicial { get; set; }
        public int? CantidadCuotaMensual { get; set; }
        public decimal? ValorCuotaMensual { get; set; }
        public decimal? ProcentajeCuotaMensual { get; set; }
        public decimal? SubtotaCuotaMensual { get; set; }
        public int? DiaCorte { get; set; }
        public int? CantidadCuotaNomina { get; set; }
        public decimal? ValorCuotaNomina { get; set; }
        public decimal? PorcentajeCuotaNomina { get; set; }
        public decimal? SubtotalCuotaNomina { get; set; }
        public DateTime? FechaOperacion { get; set; }
        public string UsuarioId { get; set; }
        public int? PagoAnterior { get; set; }
        public int? PagoNuevo { get; set; }
        public string TipoMovimiento { get; set; }
        public string DescripcionPA { get; set; }
        public string DescripcionPN { get; set; }
        public string UserEmail { get; set; }
    }
}