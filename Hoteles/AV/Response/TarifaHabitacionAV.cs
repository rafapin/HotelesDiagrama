using AV.Response.Hoteles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Response.AV
{
    public class TarifaHabitacionAV
    {
        public int TarifaHabitacionId { get; set; }
        public int HabitacionId { get; set; }
        public int TipoAcomodacionId { get; set; }
        public HabitacionAV Habitacion { get; set; }
        public decimal ValorNocheRangoEdad1 { get; set; }
        public decimal ValorNocheRangoEdad2 { get; set; }
        public decimal ValorNocheRangoEdad3 { get; set; }
        public decimal TarifaIva { get; set; }
        public decimal SeguroHotelero { get; set; }
        public decimal ValorImpoconsumo { get; set; }
        public decimal MarkUp { get; set; }
        public decimal TarifaFeeBancario { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int TipoMonedaId { get; set; }
        public string TipoMonedaDescripcion { get; set; }
        public int HabitacionesDisponibles { get; set; }
        public decimal ValorNocheDesayunoRangoEdad1 { get; set; }
        public decimal ValorNocheDesayunoRangoEdad2 { get; set; }
        public decimal ValorNocheDesayunoRangoEdad3 { get; set; }
        public decimal ValorNocheTodoIncluidoRangoEdad1 { get; set; }
        public decimal ValorNocheTodoIncluidoRangoEdad2 { get; set; }
        public decimal ValorNocheTodoIncluidoRangoEdad3 { get; set; }

        //NUEVAS COLUMNAS
        public int? TipoAlimentoId { get; set; }
        public TiposAlimentosAV TipoAlimento { get; set; }

        public int? NocheMinima { get; set; }

        public int? NocheMaxima { get; set; }

        public bool? AplicaPaquete { get; set; }

        public DateTime? FechaVentaInicio { get; set; }

        public DateTime? FechaVentaFin { get; set; }

        public bool? Lunes { get; set; }

        public bool? Martes { get; set; }

        public bool? Miercoles { get; set; }

        public bool? Jueves { get; set; }

        public bool? Viernes { get; set; }

        public bool? Sabado { get; set; }

        public bool? Domingo { get; set; }

        public IEnumerable<TarifaHabitacionBlackoutAV> Blackouts { get; set; }
        public decimal? TarifaPersona1R1 { get; set; }
        public decimal? TarifaPersona2R1 { get; set; }
        public decimal? TarifaPersona3R1 { get; set; }
        public decimal? TarifaPersona1R2 { get; set; }
        public decimal? TarifaPersona2R2 { get; set; }
        public decimal? TarifaPersona3R2 { get; set; }
        public decimal? TarifaPersona1R3 { get; set; }
        public decimal? TarifaPersona2R3 { get; set; }
        public decimal? TarifaPersona3R3 { get; set; }
        public int diasAplica { get; set; }
    }

    public class CopyOfTarifaHabitacionAV
    {
        public int TarifaHabitacionId { get; set; }
        public int HabitacionId { get; set; }
        public int TipoAcomodacionId { get; set; }
        public HabitacionAV Habitacion { get; set; }
        public decimal ValorNocheRangoEdad1 { get; set; }
        public decimal ValorNocheRangoEdad2 { get; set; }
        public decimal ValorNocheRangoEdad3 { get; set; }
        public decimal TarifaIva { get; set; }
        public decimal SeguroHotelero { get; set; }
        public decimal ValorImpoconsumo { get; set; }
        public decimal MarkUp { get; set; }
        public decimal TarifaFeeBancario { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int TipoMonedaId { get; set; }
        public string TipoMonedaDescripcion { get; set; }
        public int HabitacionesDisponibles { get; set; }
        public decimal ValorNocheDesayunoRangoEdad1 { get; set; }
        public decimal ValorNocheDesayunoRangoEdad2 { get; set; }
        public decimal ValorNocheDesayunoRangoEdad3 { get; set; }
        public decimal ValorNocheTodoIncluidoRangoEdad1 { get; set; }
        public decimal ValorNocheTodoIncluidoRangoEdad2 { get; set; }
        public decimal ValorNocheTodoIncluidoRangoEdad3 { get; set; }

        //NUEVAS COLUMNAS
        public int? TipoAlimentoId { get; set; }
        public TiposAlimentosAV TipoAlimento { get; set; }

        public int? NocheMinima { get; set; }

        public int? NocheMaxima { get; set; }

        public bool? AplicaPaquete { get; set; }

        public DateTime? FechaVentaInicio { get; set; }

        public DateTime? FechaVentaFin { get; set; }

        public bool? Lunes { get; set; }

        public bool? Martes { get; set; }

        public bool? Miercoles { get; set; }

        public bool? Jueves { get; set; }

        public bool? Viernes { get; set; }

        public bool? Sabado { get; set; }

        public bool? Domingo { get; set; }

        public IEnumerable<TarifaHabitacionBlackoutAV> Blackouts { get; set; }
        public decimal? TarifaPersona1R1 { get; set; }
        public decimal? TarifaPersona2R1 { get; set; }
        public decimal? TarifaPersona3R1 { get; set; }
        public decimal? TarifaPersona1R2 { get; set; }
        public decimal? TarifaPersona2R2 { get; set; }
        public decimal? TarifaPersona3R2 { get; set; }
        public decimal? TarifaPersona1R3 { get; set; }
        public decimal? TarifaPersona2R3 { get; set; }
        public decimal? TarifaPersona3R3 { get; set; }
        public int diasAplica { get; set; }
    }

    public class TarifaHabitacionBlackoutAV
    {
        public int TarifaHabBlackoutId { get; set; }

        public int TarifaHabitacionId { get; set; }

        public DateTime Fecha { get; set; }
    }
    public class TiposAlimentosAV
    {
        public int TipoAlimentoId { get; set; }

        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

    }

    public class CopyOfTiposAlimentosAV
    {
        public int TipoAlimentoId { get; set; }

        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

    }
}
