using Hoteles.Response.AV;
using Hoteles.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.AV.Response
{
    public class ReservaAV
    {
        public int ReservaId { get; set; }
        public int PaqueteId { get; set; }
        public DateTime FechaEmision { get; set; }
        public int EstadoReservaId { get; set; }
        public string UsuarioId { get; set; }
        public decimal ValorTotal { get; set; }
        public string NumeroAprobacion { get; set; }
        public string UsuarioFullName { get; set; }
        public string UsuarioEmail { get; set; }
        public string EmpresaNombre { get; set; }
        public string EstadoReservaNombre { get; set; }
        public int CantidadPersonasRangoEdad1 { get; set; }
        public int CantidadPersonasRangoEdad2 { get; set; }
        public int CantidadPersonasRangoEdad3 { get; set; }
        public Guid UsuarioActualizacionId { get; set; }
        public Guid? UsuarioEvaluacionId { get; set; }
        public string UsuarioEvaluacion { get; set; }
        public DateTime? FechaEvaluacion { get; set; }
        public int EstadoReservaUsuarioFinalId { get; set; }
        public string EstadoReservaUsuarioFinal { get; set; }
        public int EstadoReservaAgenciaId { get; set; }
        public string EstadoReservaAgencia { get; set; }
        public string CodigoReserva { get; set; }
        // Para uso de la app mobile
        public string ReservaImagenUrl { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public PaqueteAV Paquete { get; set; }
        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public IEnumerable<ViajeroAV> Viajeros { get; set; }

        public List<ViajeroAV> ViajerosActualizer { get; set; }
        public IEnumerable<FormaPagoAV> MetodosDePago { get; set; }
        public IEnumerable<PorcionTerrestreReservaAV> PorcionesTerrestre { get; set; }
        public IEnumerable<TiqueteReservaAV> Tiquetes { get; set; }
        public IEnumerable<AbonoReservaAV> Abonos { get; set; }
        public IEnumerable<ReservaTourAV> Toures { get; set; }
        public IEnumerable<CaracteristicaReserva> Caracteristicas { get; set; }
        public ActividadUsuario Eventos { get; set; }
        public string NombreReserva { get; set; }
        public int CircuitoId { get; set; }
        public CircuitoAV Circuito { get; set; }
        public HabitacionConTarifasAV[] HabitacionesDisponibles { get; set; }

        public HabitacionConTarifasAV[] HabitacionesDetalles { get; set; }

        public int IdIntegracion { get; set; }
        public string Integracion { get; set; }

    }
}
