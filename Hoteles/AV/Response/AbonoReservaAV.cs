using System;

namespace Hoteles.AV.Response
{
    public class AbonoReservaAV
    {
        public int AbonosReservaId { get; set; }
        public int ReservaId { get; set; }
        public int TipoRegistroId { get; set; }
        public DateTime FechaAbono { get; set; }
        public int FormaPagoId { get; set; }
        public decimal Valor { get; set; }
        public string TipoRegistro { get; set; }
        public string MetodoPago { get; set; }
        public Guid UsuarioId { get; set; }
        public string Usuario { get; set; }
        public string Referencia { get; set; }
        public int TipoAbono { get; set; }
        public int FuenteId { get; set; }
        public int Resultado { get; set; }
        public string MediosPagosDescripcion { get; set; }
        public string DescricionEstadoMetodoPago { get; set; }
        public string ArchivoContable { get; set; }
        public string ArchivoCaja { get; set; }
    }
}