using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response.HotelResCancel
{
    public class HotelResCancelRS
    {
        public Comment Comment { get; set; }

        public CancelInfoRS CancelInfoRS { get; set; }
    }

    public class Comment
    {
        public string Description { get; set; }
    }

    public class CancelInfoRS
    {
        public CancelRules[] CancelRules { get; set; }
    }

    public class CancelRules
    {
        public float Amount { get; set; }
        public int CurrencyCode { get; set; }
    }
}
