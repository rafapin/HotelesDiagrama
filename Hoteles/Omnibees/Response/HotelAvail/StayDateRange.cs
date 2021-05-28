using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response.HotelAvail
{
    public partial class StayDateRange
    {
        public DateTimeOffset Start { get; set; }
        public object Duration { get; set; }
        public DateTimeOffset End { get; set; }
    }
}
