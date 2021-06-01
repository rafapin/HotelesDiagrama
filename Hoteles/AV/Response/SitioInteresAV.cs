namespace Hoteles.AV.Response
{
    public class SitioInteresAV
    {
        public int SitioInteresId { get; set; }
        public int DestinoId { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public decimal Costo { get; set; }
        public int TipoMoneda { get; set; }
        public string Horarios { get; set; }
        public string SitioWeb { get; set; }
        public float Puntaje { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int HorasVisitaSugeridas { get; set; }
        public int? CiudadId { get; set; }

        public string CityName { get; set; }
        public string DescripcionDestino { get; set; }
        public string DescripcionSI { get; set; }
        public string DescripcionTM { get; set; }
        public string ImagenUrl { get; set; }
    }
}