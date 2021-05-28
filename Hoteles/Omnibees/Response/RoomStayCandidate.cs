using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response
{
    public partial class RoomStayCandidate
    {
        public GuestCountsType GuestCountsType { get; set; }
        public object RoomId { get; set; }
        public long Quantity { get; set; }
        public long Rph { get; set; }
        public object BookingCode { get; set; }
    }
}
