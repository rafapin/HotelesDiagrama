using Hoteles.Response.AV;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Shared
{
    public class Destino
    {
        public int DestinoId { get; set; }
        public int CiudadId { get; set; }
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
        public CityAV City { get; set; }
    }
}
