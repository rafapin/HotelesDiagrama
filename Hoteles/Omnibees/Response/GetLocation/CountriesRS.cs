using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response.GetLocation
{
    public class Country
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }

    public class CountriesType
    {
        public List<Country> Countries { get; set; }
    }

    public class Success
    {
    }

    public class CountriesRS
    {
        public string EchoToken { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Target { get; set; }
        public double Version { get; set; }
        public int PrimaryLangID { get; set; }
        public CountriesType CountriesType { get; set; }
        public Success Success { get; set; }
        public object WarningsType { get; set; }
        public object ErrorsType { get; set; }
    }
}
