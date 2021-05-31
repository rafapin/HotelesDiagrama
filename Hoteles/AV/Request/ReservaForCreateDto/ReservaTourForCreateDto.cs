using System;

namespace Hoteles.AV.Request.ReservaForCreateDto
{
    public class ReservaTourForCreateDto
    {
        public int TourId { get; set; }

        public int CantidadPersonas { get; set; }

        public decimal ValorTotal { get; set; }

        public DateTime FechaReserva { get; set; }
    }
}