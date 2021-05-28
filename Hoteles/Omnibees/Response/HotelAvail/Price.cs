using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response.HotelAvail
{
    public partial class Price
    {
        public DateTimeOffset? Start { get; set; }
        public object Duration { get; set; }
        public DateTimeOffset? End { get; set; }
        public long AmountBeforeTax { get; set; }
        public long AmountAfterTax { get; set; }
        public long CurrencyCode { get; set; }
    }
}
