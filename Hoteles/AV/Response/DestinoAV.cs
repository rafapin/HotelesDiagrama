using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Response.AV
{
    public class DestinoAV
    {
        public int DestinoId { get; set; }
        public int CiudadId { get; set; }
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
        public CityAV City { get; set; }
    }
}
