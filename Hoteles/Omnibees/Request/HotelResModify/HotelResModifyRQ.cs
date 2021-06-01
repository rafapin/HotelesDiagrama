using Hoteles.Omnibees.Response.HotelRes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Request.HotelResModify
{
    public class HotelResModifies
    {
        public UniqueID UniqueID { get; set; }
        public RoomStaysType RoomStaysType { get;    set; }
        public ResGuestsType ResGuestsType { get; set; }
    }

    public class HotelResModifiesType
    {
        public HotelResModifies[] HotelResModifies { get; set; }
    }

    public class OtaHotelResModifyRQ
    {

        public string EchoToken { get; set; }

        public HotelResModifiesType HotelResModifiesType { get; set; }

        public string PrimaryLangID { get; set; }

        public string ResStatus { get; set; }

        public bool RetransmissionIndicator { get; set; }

        public string Target { get; set; }

        public DateTime TimeStamp { get; set; }

        public string TransactionIdentifier { get; set; }

        public int Version { get; set; }
    }
}
