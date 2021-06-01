using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Request.HotelSearch
{
    public class Address
    {
        public int CityCode { get; set; }
        public int CountryCode { get; set; }
        public int StateProvCode { get; set; }
    }

    public class Criterion
    {
        public Address Address { get; set; }
    }

    public class Criteria
    {
        public Criterion Criterion { get; set; }
    }

    public class HotelSearchRQ
    {
        public Criteria Criteria { get; set; }
        public string EchoToken { get; set; }
        public int MaxResponses { get; set; }
        public int PageNumber { get; set; }
        public string PrimaryLangID { get; set; }
        public string Target { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Version { get; set; }
    }
}
