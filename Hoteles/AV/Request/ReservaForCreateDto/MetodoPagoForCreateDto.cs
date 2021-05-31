using System;

namespace Hoteles.AV.Request.ReservaForCreateDto
{
    public class MetodoPagoForCreateDto
    {
        public int MetodoId { get; set; }
        public decimal Valor { get; set; }
        public int Cuotas { get; set; }
        public string EstadoMetodoPago { get; set; }
        // public int EstadoMetodoPagoId { get; set; }
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
    }
}