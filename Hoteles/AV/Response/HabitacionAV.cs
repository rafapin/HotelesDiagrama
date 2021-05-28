using Hoteles.Response.AV;
using Hoteles.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Response.Hoteles
{
    public class HabitacionAV
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TipoAcomodacionId { get; set; }
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
        public IEnumerable<ImagenHabitacion> Imagenes { get; set; }
        public IEnumerable<ServicioHabitacionAV> Servicios { get; set; }


        // Foreing Key
        public TipoAcomodacionAV TipoAcomodacion { get; set; }
        public TipoCamaAV TipoCama { get; set; }
        public HotelAV Hotel { get; set; }
    }
}