using AV.Hoteles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Shared
{
    public class ImagenHotel : ImagenBase
    {
        public int HotelId { get; set; }
    }

    public class ImagenBase
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public HotelAV hotel { get; set; }
    }
}
