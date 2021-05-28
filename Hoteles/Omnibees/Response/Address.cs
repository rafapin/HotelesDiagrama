using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response
{
    public partial class Address
    {
        public long? CountryCode { get; set; }
        public long? StateProvCode { get; set; }
        public long? CityCode { get; set; }
        public string AddressLine { get; set; }
        public object CityName { get; set; }
        public object PostalCode { get; set; }
        public object StateProv { get; set; }
        public object CountryName { get; set; }
        public object ZoneCode { get; set; }
        public object ZoneName { get; set; }
    }
}
