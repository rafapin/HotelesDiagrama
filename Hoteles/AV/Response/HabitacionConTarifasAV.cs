using Hoteles.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Response.AV
{

    public class HabitacionConTarifasAV
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TipoAcomodacionId { get; set; }
        public string TipoAcomodacion { get; set; }
        public int TipoCamaId { get; set; }
        public int Capacidad { get; set; }
        public bool IsActive { get; set; }
        public int HotelId { get; set; }
        public int CapMax { get; set; }
        public int CapMin { get; set; }
        public int MinAdultos { get; set; }
        public int MaxAdultos { get; set; }
        public int MinMenores { get; set; }
        public int MaxMenores { get; set; }
        public int MinInfantes { get; set; }
        public int MaxInfantes { get; set; }
        public int HabitacionesDisponibles { get; set; }
        public IEnumerable<ImagenHabitacion> Imagenes { get; set; }
        public IEnumerable<ServicioHabitacionAV> Servicios { get; set; }
        public List<TarifaHabitacionAV> TarifasHabitacion { get; set; }
        public IEnumerable<TiposAlimentosAV> TiposAlimento { get; set; }

        public int habitacionIndex { get; set; }
        public bool Principal { get; set; }
        public List<HabitacionConTarifasAV> HabitacionesHijas { get; set; }
    }

    public class CopyOfHabitacionConTarifasAV
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TipoAcomodacionId { get; set; }
        public string TipoAcomodacion { get; set; }
        public int TipoCamaId { get; set; }
        public int Capacidad { get; set; }
        public bool IsActive { get; set; }
        public int HotelId { get; set; }
        public int CapMax { get; set; }
        public int CapMin { get; set; }
        public int MinAdultos { get; set; }
        public int MaxAdultos { get; set; }
        public int MinMenores { get; set; }
        public int MaxMenores { get; set; }
        public int MinInfantes { get; set; }
        public int MaxInfantes { get; set; }
        public int HabitacionesDisponibles { get; set; }
        public IEnumerable<ImagenHabitacion> Imagenes { get; set; }
        public IEnumerable<ServicioHabitacionAV> Servicios { get; set; }
        public List<TarifaHabitacionAV> TarifasHabitacion { get; set; }
        public IEnumerable<TiposAlimentosAV> TiposAlimento { get; set; }

        public int habitacionIndex { get; set; }
        public bool Principal { get; set; }
        public List<CopyOfHabitacionConTarifasAV> HabitacionesHijas { get; set; }
    }
}
