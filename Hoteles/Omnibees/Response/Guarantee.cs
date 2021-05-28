using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response
{
    public partial class Guarantee
    {
        public DateTimeOffset? Start { get; set; }
        public object Duration { get; set; }
        public DateTimeOffset? End { get; set; }
        public Iption GuaranteeDescription { get; set; }
        public GuaranteesAcceptedType GuaranteesAcceptedType { get; set; }
        public DeadLine DeadLine { get; set; }
        public AmountPercent AmountPercent { get; set; }
        public long GuaranteeCode { get; set; }
    }
}
