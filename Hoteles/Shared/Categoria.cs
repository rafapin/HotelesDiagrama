using Hoteles.AV.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hoteles.Shared
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<PaqueteAV> Paquetes { get; set; }
    }
}
