using Hoteles.AV.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Shared
{
    public class Subcategoria
    {
        public int SubcategoriaId { get; set; }
        public string Nombre { get; set; }
        public bool IsActive { get; set; }
        public int CategoriaId { get; set; }
        public string Categoria { get; set; }
        public string ImagenUrl { get; set; }
        public IEnumerable<PaqueteAV> Paquetes { get; set; }
    }
}
