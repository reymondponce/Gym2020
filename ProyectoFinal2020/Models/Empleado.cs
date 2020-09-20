using System;
using System.Collections.Generic;

namespace ProyectoFinal2020.Models
{
    public partial class Empleado
    {
        public string IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Telefono { get; set; }
        public string Area { get; set; }
        public string TipoDeEmp { get; set; }
        public string NumeroSocial { get; set; }
        public string NumeroBancario { get; set; }
        public string Profesion { get; set; }
        public DateTime FechaContrato { get; set; }
        public string Estado { get; set; }
    }
}
