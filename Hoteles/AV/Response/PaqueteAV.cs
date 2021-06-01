using AV.Response.Hoteles;
using Hoteles.Response.AV;
using Hoteles.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.AV.Response
{
    public class PaqueteAV
    {
        public int PaqueteId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int ProveedorHotelId { get; set; }
        public HotelAV hotel { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string CodigoPaquete { get; set; }
        public int EmpresaId { get; set; }
        public EmpresaAV Empresa { get; set; }
        public int EstadoPaqueteId { get; set; }
        public EstadoPaquete EstadoPaquete { get; set; }
        public int CategoriaId { get; set; }
        public Subcategoria Subcategoria { get; set; }
        public int SubcategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int Cupos { get; set; }
        public int CiudadOrigenId { get; set; }
        public CityAV CiudadOrigen { get; set; }
        public int CiudadDestinoId { get; set; }
        public Destino CiudadDestino { get; set; }
        public int CiudadArriboId { get; set; }
        public CityAV CiudadArribo { get; set; }
        public string TextoLegal { get; set; }
        public int LimiteEdadInfante { get; set; }
        public int LimiteEdadMenor { get; set; }
        public int LimiteEdadAdulto { get; set; }
        public int TipoMonedaId { get; set; }
        public decimal Trm { get; set; }
        public string CiudadOrigenNombre { get; set; }
        public string CiudadDestinoNombre { get; set; }
        public string CiudadArriboNombre { get; set; }
        public bool TieneReservas { get; set; }
        public IEnumerable<Imagen> Imagenes { get; set; }
        public IEnumerable<Caracteristica> Caracteristicas { get; set; }
        public IEnumerable<TiquetePaquete> Tiquetes { get; set; }
        public IEnumerable<PorcionTerrestrePaquete> PorcionesTerrestre { get; set; }
        public IEnumerable<RangoFechaPaquete> RangosFecha { get; set; }
        public IEnumerable<ExcepcionPaquete> Excepciones { get; set; }
    }
}
