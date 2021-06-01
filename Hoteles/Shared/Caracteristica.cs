using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Shared
{
    public class Caracteristica
    {
        public int CaracteristicaPaqueteId { get; set; }
        public int PaqueteId { get; set; }
        public int ProveedorId { get; set; }
        public string Proveedor { get; set; }
        public string Descripcion1 { get; set; }
        public string Descripcion2 { get; set; }
        public string Descripcion3 { get; set; }
        public decimal ValorRangoEdad1 { get; set; }
        public decimal ValorRangoEdad2 { get; set; }
        public decimal ValorRangoEdad3 { get; set; }
        public decimal MarkUp { get; set; }
        public decimal TarifaFeeBancario { get; set; }

        public int TipoProveedorId { get; set; }
    }
}
