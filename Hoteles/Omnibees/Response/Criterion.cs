using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response
{
    public partial class Criterion
    {
        public object Position { get; set; }
        public Address Address { get; set; }
        public object HotelRefs { get; set; }
        public object Radius { get; set; }
        public object HotelAmenity { get; set; }
        public object RoomAmenity { get; set; }
        public object Award { get; set; }
        public object ProfilesType { get; set; }
        public object RateRanges { get; set; }
        public StayDateRange StayDateRange { get; set; }
        public RoomStayCandidatesType RoomStayCandidatesType { get; set; }
        public object RatePlanCandidatesType { get; set; }
        public object Location { get; set; }
        public bool GetPricesPerGuest { get; set; }
        public object TpaExtensions { get; set; }
        public object InfoSource { get; set; }
    }
}
