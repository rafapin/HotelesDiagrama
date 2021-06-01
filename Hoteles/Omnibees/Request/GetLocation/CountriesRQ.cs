using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Request.GetLocation
{
    public class CountriesRQ
    {
        public string EchoToken { get; set; }
        public DateTime TimeStamp { get; set; }
        public double Version { get; set; }
        public string PrimaryLangID { get; set; }
    }
}
