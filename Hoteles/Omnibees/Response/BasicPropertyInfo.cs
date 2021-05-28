using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response
{
    public partial class BasicPropertyInfo
    {
        public long CurrencyCode { get; set; }
        public Position Position { get; set; }
        public Address Address { get; set; }
        public object ContactNumbersType { get; set; }
        public Award Award { get; set; }
        public object HotelAmenities { get; set; }
        public object Policy { get; set; }
        public HotelRef HotelRef { get; set; }
        public object VendorMessagesType { get; set; }
        public Uri ImageUrl { get; set; }
    }
}
