using System;
using System.Collections.Generic;

namespace ProyectoFinal2020.Models
{
    public partial class Tarifa
    {
        public string IdTarifa { get; set; }
        public double PrecioTarifa { get; set; }
        public string Duracion { get; set; }
        public string Estado { get; set; }
        public string Descripcion { get; set; }
    }
}
