using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Request.GetLocation
{
    public class StatesRQ
    {
        public string EchoToken { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Target { get; set; }
        public double Version { get; set; }
        public string PrimaryLangID { get; set; }
        public int Country_UID { get; set; }
    }
}
