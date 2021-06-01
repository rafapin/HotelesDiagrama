namespace Hoteles.AV.Response
{
    public class PorcionTerrestreReservaAV
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public int CantidadPersonasRangoEdad1 { get; set; }
        public int CantidadPersonasRangoEdad2 { get; set; }
        public int CantidadPersonasRangoEdad3 { get; set; }
        public decimal TotalAlojamiento { get; set; }
        public int TipoAcomodacionId { get; set; }
        public string TipoAcomodacion { get; set; }
        public int TipoCamaId { get; set; }
        public string TipoCama { get; set; }
        public int HabitacionId { get; set; }
        public string NombreHab { get; set; }
        public int HotelId { get; set; }
        public string NombreHotel { get; set; }
        public int TipoAlimentoId { get; set; }
        public string TiposAlimento { get; set; }
    }
}