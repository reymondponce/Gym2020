using System;
using System.Collections.Generic;

namespace ProyectoFinal2020.Models
{
    public partial class MatriculaClaseGym
    {
        public int IdMatriculaGym { get; set; }
        public string IdCliente { get; set; }
        public string IdClaseGym { get; set; }
        public DateTime Fecha { get; set; }
        public double Costo { get; set; }

        public virtual ClaseGym IdClaseGymNavigation { get; set; }
    }
}
