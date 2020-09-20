using System;
using System.Collections.Generic;

namespace ProyectoFinal2020.Models
{
    public partial class MatriculaGuarderia
    {
        public int IdMatricula { get; set; }
        public string IdClaseGuarderia { get; set; }
        public string IdHijo { get; set; }
        public DateTime Fecha { get; set; }

        public virtual ClaseGuarderia IdClaseGuarderiaNavigation { get; set; }
    }
}
