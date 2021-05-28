using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response
{
    public partial class CancelPenalty
    {
        public bool NonRefundable { get; set; }
        public DeadLine DeadLine { get; set; }
        public AmountPercent AmountPercent { get; set; }
        public PenaltyDescription PenaltyDescription { get; set; }
    }
}
