using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response
{
    public partial class AmountPercent
    {
        public long NmbrOfNights { get; set; }
        public long Amount { get; set; }
        public long Percent { get; set; }
        public long CurrencyCode { get; set; }
    }
}
