using System;
using System.Collections.Generic;

namespace ProyectoFinal2020.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            HijoCliente = new HashSet<HijoCliente>();
        }

        public int IdCliente { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        public string Sexo { get; set; }
        public string Casillero { get; set; }
        public string IdTarifa { get; set; }

        public virtual ICollection<HijoCliente> HijoCliente { get; set; }
    }
}
