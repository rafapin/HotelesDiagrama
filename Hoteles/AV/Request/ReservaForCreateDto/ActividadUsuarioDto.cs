using System;

namespace Hoteles.AV.Request.ReservaForCreateDto
{
    public class ActividadUsuarioDto
    {
        public int ActividadUsuarioId { get; set; }
        public int ActividadId { get; set; }
        public string UsuarioId { get; set; }
        public int EmpresaId { get; set; }
        public DateTime Fecha { get; set; }
        public int Personas { get; set; }
        public int HorarioActividad { get; set; }
        public int ReservaId { get; set; }
        public decimal ValorTotal { get; set; }

        // Propiedades Referencias para listas rapidas
        public string Actividad { get; set; }
        public string Usuario { get; set; }
        public string Empresa { get; set; }
    }
}