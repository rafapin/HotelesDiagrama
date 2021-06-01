using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Shared
{
    public class ProveedorGDSCliente
    {
        public int ProveedorGDSClienteId { get; set; }

        public int ProveedorGDSId { get; set; }

        public int MetodoPagoGDSId { get; set; }
        public int EmpresaId { get; set; }
        public bool Activo { get; set; }
    }
}
