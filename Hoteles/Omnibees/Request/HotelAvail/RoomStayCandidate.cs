using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Request.HotelAvail
{
    public class RoomStayCandidate
    {
        public GuestCountsType GuestCountsType { get; set; }
        public int Quantity { get; set; }
        public int RPH { get; set; }
        public string BookingCode { get; set; }
    }
}
