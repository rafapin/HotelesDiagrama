using Hoteles.Shared;
using System;

namespace Hoteles.AV.Response
{
    public class TourAV
    {
        public int TourId { get; set; }
        public int DestinoId { get; set; }
        public int TipoTourId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion1 { get; set; }
        public string Descripcion2 { get; set; }
        public string ImagenUrl { get; set; }
        public decimal TarifaAdulto { get; set; }
        public decimal TarifaMenor { get; set; }
        public decimal TarifaInfante { get; set; }
        public DateTime FechaInicioDisponibilidad { get; set; }
        public DateTime FechaFinDisponibilidad { get; set; }
        public int Capacidad { get; set; }
        public decimal MarkUp { get; set; }
        public string NombreTipoTour { get; set; }
        public string NombreDestino { get; set; }
        public bool IsActive { get; set; }
        public int? EmpresaId { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string NombreSitio { get; set; }
        public string SitioWeb { get; set; }
        public string Horario { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Puntaje { get; set; }
        public int TipoMonedaId { get; set; }
        public decimal HorasVisitaSugeridas { get; set; }

        // foreign key relations
        public Destino Destino { get; set; }
        public TipoTour TipoTour { get; set; }
        public EmpresaAV Empresa { get; set; }
        public TipoMoneda TipoMoneda { get; set; }
    }
}