using Hoteles.Response.AV;
using Hoteles.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.AV.Response
{
    public class EmpresaAV
    {
        public int EmpresaId { get; set; }
        public string Nombre { get; set; }
        public int TipoDocumentoId { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public int NumeroDiasVigenciaOfertas { get; set; }
        public bool? IsActive { get; set; }

        public string RazonSocial { get; set; }

        public string RepresentanteLegal { get; set; }

        public string NitRepresentante { get; set; }

        public string NombreComercial { get; set; }

        public string PrefijoAsignado { get; set; }

        public int? CiudadId { get; set; }

        public CityAV Ciudad { get; set; }
        public string Zona { get; set; }

        public string Latitud { get; set; }

        public string Longitud { get; set; }

        public string TelefonoMovil { get; set; }

        public string RepresentanteComercial { get; set; }

        public string CargoRepreComercial { get; set; }

        public string TelMovReprComercial { get; set; }

        public string TelFijoReprComercial { get; set; }

        public string EmailComercial { get; set; }

        public string RepresentanteFinanciero { get; set; }

        public string CargoRepreFinaciero { get; set; }

        public string TelMovilFinanciero { get; set; }

        public string TelFijoFinanciero { get; set; }

        public string EmailFinanciero { get; set; }

        public bool? Notificar { get; set; }

        public string EmailNotificacion { get; set; }

        public IEnumerable<DocumentosEmpresa> Documentos { get; set; }
        public string PaginaWeb { get; set; }

        public int TipoClienteId { get; set; }

        public string UrlLogoEmpresa { get; set; }

        public string OfficeId { get; set; }
        public int TicketFP { get; set; }
        public bool TicketAutoEmit { get; set; }
        public string Aprovador { get; set; }
        public bool TicketTarifaIt { get; set; }
        public bool TicketImpuesto { get; set; }
        public decimal DescuentoContractual { get; set; }
        public decimal DescuentoContractualInter { get; set; }
        public IEnumerable<ProveedorGDSCliente> ProveedoresGDSCliente { get; set; }
    }
}
