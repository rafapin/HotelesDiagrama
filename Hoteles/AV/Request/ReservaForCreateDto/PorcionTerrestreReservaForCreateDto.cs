namespace Hoteles.AV.Request.ReservaForCreateDto
{
    public class PorcionTerrestreReservaForCreateDto
    {
        public int TarifaHabitacionId { get; set; }
        public int CantidadPersonasRangoEdad1 { get; set; }
        public int CantidadPersonasRangoEdad2 { get; set; }
        public int CantidadPersonasRangoEdad3 { get; set; }
        public decimal TotalAlojamiento { get; set; }
        public int HabitacionId { get; set; }
        public int TipoAlimentoId { get; set; }
    }
}