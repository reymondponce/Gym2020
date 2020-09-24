using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal2020.Models
{
    public partial class Actividad
    {
        public Actividad()
        {
            ClaseGym = new HashSet<ClaseGym>();
        }

        public int IdActividad { get; set; }
        [Required(ErrorMessage ="Ingrese un Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese una Descripcion")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Ingrese una Duracion")]
        public string Duracion { get; set; }

        public virtual ICollection<ClaseGym> ClaseGym { get; set; }
    }
}
