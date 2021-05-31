using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Request.HotelAvail
{
    public class Criterion
    {
        public Address Address { get; set; }
        public bool GetPricesPerGuest { get; set; }
        public bool HotelAmenity { get; set; }
        public RoomStayCandidatesType RoomStayCandidatesType { get; set; }
        public StayDateRange StayDateRange { get; set; }
        public HotelRefsCriterion[] HotelRefs { get; set; }
        public ProfilesTypeAv ProfilesType { get; set; }
    }
}
