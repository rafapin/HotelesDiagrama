using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response.GetLocation
{
    public class PositionCity
    {
        public int CountryUID { get; set; }
        public int Code { get; set; }
        public string SearchCode { get; set; }
        public string SearchZoneCode { get; set; }
        public string Name { get; set; }
        public object Latitude { get; set; }
        public object Longitude { get; set; }
    }

    public class PositionsTypeCity
    {
        public List<PositionCity> Positions { get; set; }
    }

    public class CitiesRS
    {
        public string EchoToken { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Target { get; set; }
        public double Version { get; set; }
        public int PrimaryLangID { get; set; }
        public object ErrorsType { get; set; }
        public object WarningsType { get; set; }
        public Success Success { get; set; }
        public PositionsTypeCity PositionsType { get; set; }
    }
}
