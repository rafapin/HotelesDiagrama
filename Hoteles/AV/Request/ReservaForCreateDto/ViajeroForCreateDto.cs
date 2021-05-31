using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.AV.Request.ReservaForCreateDto
{
    public class ViajeroForCreateDto
    {
        public string PrimerNombre { get; set; }

        public string SegundoNombre { get; set; }

        public string PrimerApellido { get; set; }

        public string SegundoApellido { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int PorcionIndex { get; set; }
    }
}
