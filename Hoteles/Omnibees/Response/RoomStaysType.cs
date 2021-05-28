using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response
{
    public partial class RoomStaysType
    {
        public RoomStay[] RoomStays { get; set; }
        public bool MoreIndicator { get; set; }
    }
}
