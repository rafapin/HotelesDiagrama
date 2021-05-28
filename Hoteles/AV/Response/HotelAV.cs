using Hoteles.Response.AV;
using Hoteles.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Response.Hoteles
{
    public class HotelAV
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Caracteristicas { get; set; }

        public bool IsActive { get; set; }

        public int DestinoId { get; set; }

        public IEnumerable<HabitacionAV> Habitaciones { get; set; }

        public double Puntaje { get; set; }

        public IEnumerable<ServicioHotelAV> Servicios { get; set; }

        // Referencias
        public IEnumerable<ImagenHotel> Imagenes { get; set; }
        public DestinoAV Destino { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int CadenaHoteleraId { get; set; }
        public CadenaHoteleraAV CadenaHotelera { get; set; }
        public int PrioridadId { get; set; }
        public string Prioridad { get; set; }
        public int EdadInfate { get; set; }
        public int EdadMenor { get; set; }
        public int CategoriaHotel { get; set; }
        public int IdIntegracion { get; set; }
        public List<HabitacionConTarifasAV> HabitacionesHotel { get; set; }
    }
}