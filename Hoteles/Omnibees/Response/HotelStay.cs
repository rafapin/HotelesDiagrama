using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response
{
    public partial class HotelStay
    {
        public string Status { get; set; }
        public long RoomStayRph { get; set; }
        public object Availability { get; set; }
        public BasicPropertyInfo BasicPropertyInfo { get; set; }
        public Price Price { get; set; }
        public HotelStayTpaExtensions TpaExtensions { get; set; }
    }
}
