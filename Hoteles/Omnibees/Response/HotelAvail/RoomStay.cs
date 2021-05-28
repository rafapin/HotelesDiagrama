using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response.HotelAvail
{
    public partial class RoomStay
    {
        public long Rph { get; set; }
        public RoomType[] RoomTypes { get; set; }
        public RatePlan[] RatePlans { get; set; }
        public RoomRate[] RoomRates { get; set; }
        public Total Total { get; set; }
        public object GuestCountsType { get; set; }
        public BasicPropertyInfo BasicPropertyInfo { get; set; }
        public object Reference { get; set; }
        public object CommentsType { get; set; }
        public object SpecialRequestsType { get; set; }
        public object IndexNumber { get; set; }
        public object RoomStayStatus { get; set; }
        public TotalTpaExtensions TpaExtensions { get; set; }
        public object Guarantees { get; set; }
        public object RoomStayCandidateRph { get; set; }
        public object AvailabilityStatus { get; set; }
        public object WarningRph { get; set; }
        public object RoomStayLanguage { get; set; }
    }
}
