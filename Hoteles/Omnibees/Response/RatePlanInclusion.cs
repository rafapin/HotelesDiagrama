using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response
{
    public partial class RatePlanInclusion
    {
        public Iption RatePlanInclusionDesciption { get; set; }
        public object Start { get; set; }
        public object Duration { get; set; }
        public object End { get; set; }
        public long Id { get; set; }
    }
}
