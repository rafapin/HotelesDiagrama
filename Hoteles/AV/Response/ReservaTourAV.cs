using System;

namespace Hoteles.AV.Response
{
    public class ReservaTourAV
    {
        public int ReservaTourId { get; set; }
        public int ReservaId { get; set; }
        public int TourId { get; set; }
        public int CantidadPersonas { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime FechaReserva { get; set; }
        public string Usuario { get; set; }
        // foreign Key
        public TourAV Tour { get; set; }
    }
}