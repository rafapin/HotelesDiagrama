using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response.HotelAvail.HotelAvail
{
    public partial class AcceptedPayment
    {
        public long Rph { get; set; }
        public long GuaranteeTypeCode { get; set; }
        public object PaymentCard { get; set; }
        public object GuaranteeId { get; set; }
    }
}
