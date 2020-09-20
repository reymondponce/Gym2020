using System;
using System.Collections.Generic;

namespace ProyectoFinal2020.Models
{
    public partial class ClaseGym
    {
        public ClaseGym()
        {
            MatriculaClaseGym = new HashSet<MatriculaClaseGym>();
        }

        public string IdClaseGym { get; set; }
        public string IdSala { get; set; }
        public TimeSpan Hora { get; set; }
        public DateTime Fecha { get; set; }
        public string Cupo { get; set; }
        public string IdActividad { get; set; }
        public string IdEmpleado { get; set; }

        public virtual Actividad IdActividadNavigation { get; set; }
        public virtual ICollection<MatriculaClaseGym> MatriculaClaseGym { get; set; }
    }
}
