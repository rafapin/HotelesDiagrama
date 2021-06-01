using System;

namespace Hoteles.AV.Response
{
    public class ViajeroAV
    {
        public int ViajeroId { get; set; }
        public int ReservaId { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}