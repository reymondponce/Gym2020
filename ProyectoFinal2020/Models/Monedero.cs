using System;
using System.Collections.Generic;

namespace ProyectoFinal2020.Models
{
    public partial class Monedero
    {
        public int IdMonedero { get; set; }
        public int IdCliente { get; set; }
        public double? Saldo { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
