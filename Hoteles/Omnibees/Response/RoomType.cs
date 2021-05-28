using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Omnibees.Response
{
    public partial class RoomType
    {
        public long RoomId { get; set; }
        public string RoomName { get; set; }
        public Description RoomDescription { get; set; }
        public object AmenitiesType { get; set; }
        public Occupancy[] Occupancies { get; set; }
        public long NumberOfUnits { get; set; }
        public object MaxOccupancy { get; set; }
    }
}
