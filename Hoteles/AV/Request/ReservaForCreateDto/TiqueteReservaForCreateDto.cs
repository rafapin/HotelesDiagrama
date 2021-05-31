namespace Hoteles.AV.Request.ReservaForCreateDto
{
    public class TiqueteReservaForCreateDto
    {
        public int TiqueteId { get; set; }
        public decimal SubTotalTarifaBase { get; set; }
        public decimal ValorIva { get; set; }
        public decimal SubTotalTarifaAdministrativa { get; set; }
        public decimal ValorIvaTarifaAdministrativa { get; set; }
        public decimal SubTotalTasa { get; set; }
        public decimal SubTotalMaletas { get; set; }
        public decimal SubTotalValorCheckIn { get; set; }
        public decimal SubTotalValorSillas { get; set; }
        public decimal TotalTiquetes { get; set; }
    }
}