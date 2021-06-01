using Hoteles.Omnibees.Response.HotelDescriptiveInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Request.HotelDescriptiveInfo
{
    public class HotelInfoRQ
    {
        public bool SendData { get; set; }
    }

    public class HotelDescriptiveInfo
    {
        public HotelRef HotelRef { get; set; }
        public FacilityInfo FacilityInfo { get; set; }
        public HotelInfoRQ HotelInfo { get; set; }
        public MultimediaObjects MultimediaObjects { get; set; }

        public MultimediaObjects ContactInfo { get; set; }
    }

    public class MultimediaObjects
    {
        public bool SendData { get; set; }
    }
    public class HotelDescriptiveInfosType
    {
        public string LangRequested { get; set; }
        public List<HotelDescriptiveInfo> HotelDescriptiveInfos { get; set; }
    }

    public class HotelDescriptiveInfoRQ
    {
        public string EchoToken { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Target { get; set; }
        public double Version { get; set; }
        public string PrimaryLangID { get; set; }
        public HotelDescriptiveInfosType HotelDescriptiveInfosType { get; set; }
    }
}
