using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response.HotelAvail
{
    public partial class HotelRef
    {
        public long HotelCode { get; set; }
        public long ChainCode { get; set; }
        public string HotelName { get; set; }
        public object BrandName { get; set; }
        public string ChainName { get; set; }
    }
}
