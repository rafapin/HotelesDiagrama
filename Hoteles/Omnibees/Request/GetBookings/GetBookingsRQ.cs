using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Request.GetBookings
{
    public class GetBookingsRQ
    {
        public string EchoToken { get; set; }
        public DateTime TimeStamp { get; set; }
        public double Version { get; set; }
        public string PrimaryLangID { get; set; }
        public UniqueID UniqueID { get; set; }
        public ReadRequestsType ReadRequestsType { get; set; }
    }
}
