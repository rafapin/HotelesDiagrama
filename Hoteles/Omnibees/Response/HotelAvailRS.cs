using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response
{
    public class HotelAvailRS
    {
        public object MaxResponses { get; set; }
        public object PageNumber { get; set; }
        public string EchoToken { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
        public long Target { get; set; }
        public double Version { get; set; }
        public object PrimaryLangId { get; set; }
        public object Pos { get; set; }
        public object WarningsType { get; set; }
        public Success Success { get; set; }
        public object ErrorsType { get; set; }
        public HotelStaysType HotelStaysType { get; set; }
        public Criteria Criteria { get; set; }
        public RoomStaysType RoomStaysType { get; set; }
        public Service[] Services { get; set; }
        public object TpaExtensions { get; set; }
    }
    public partial class Success
    {
    }
}
