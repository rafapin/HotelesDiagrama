using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Request.HotelAvail
{
    public class HotelAvailRQ
    {
        public string PrimaryLangID { get; set; }
        public bool AvailRatesOnly { get; set; }
        public bool BestOnly { get; set; }
        public string EchoToken { get; set; }
        public HotelSearchCriteria HotelSearchCriteria { get; set; }
        public DateTime TimeStamp { get; set; }
        public double Version { get; set; }
        public bool? IsModify { get; set; }
    }
}
