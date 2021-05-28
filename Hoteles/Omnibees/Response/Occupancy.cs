using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response
{
    public partial class Occupancy
    {
        public long MinOccupancy { get; set; }
        public long MaxOccupancy { get; set; }
        public long AgeQualifyingCode { get; set; }
        public object MinAge { get; set; }
        public object MaxAge { get; set; }
    }
}
