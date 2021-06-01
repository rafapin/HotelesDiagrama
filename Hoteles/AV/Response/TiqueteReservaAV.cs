namespace Hoteles.AV.Response
{
    public class TiqueteReservaAV
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
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
        public string Proveedor { get; set; }
        public string FechaVueloIda { get; set; }
        public string NumeroVuelo { get; set; }
        public string HoraArriboIda { get; set; }
        public string HoraVueloIda { get; set; }
    }
}