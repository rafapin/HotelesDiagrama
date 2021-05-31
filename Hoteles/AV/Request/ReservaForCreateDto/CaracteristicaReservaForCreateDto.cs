namespace Hoteles.AV.Request.ReservaForCreateDto
{
    public class CaracteristicaReservaForCreateDto
    {
        public int CaracteristicaId { get; set; }
        public decimal SubTotalPersonas { get; set; }
        public decimal SubTotalCaracteristica { get; set; }
        public decimal ValorFeeBancario { get; set; }
        public decimal TotalCaracteristica { get; set; }
    }
}