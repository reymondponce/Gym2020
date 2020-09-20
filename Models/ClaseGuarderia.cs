using System;
using System.Collections.Generic;

namespace ProyectoFinal2020.Models
{
    public partial class ClaseGuarderia
    {
        public ClaseGuarderia()
        {
            MatriculaGuarderia = new HashSet<MatriculaGuarderia>();
        }

        public string IdClaseGuarderia { get; set; }
        public string Nombre { get; set; }
        public string IdSala { get; set; }
        public TimeSpan Hora { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Capacidad { get; set; }
        public string Duracion { get; set; }
        public string IdEmpleado { get; set; }

        public virtual ICollection<MatriculaGuarderia> MatriculaGuarderia { get; set; }
    }
}
