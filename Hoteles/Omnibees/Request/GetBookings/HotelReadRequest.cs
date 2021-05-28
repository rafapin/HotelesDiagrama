using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Request.GetBookings
{
    public class HotelReadRequest
    {
        public HoteRef HoteRef { get; set; }
        public SelectionCriteria SelectionCriteria { get; set; }
    }
}
