using System;
using System.Collections.Generic;

namespace ProyectoFinal2020.Models
{
    public partial class TipoMovimiento
    {
        public TipoMovimiento()
        {
            MovimientoMonedero = new HashSet<MovimientoMonedero>();
        }

        public int IdTipoMovimiento { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<MovimientoMonedero> MovimientoMonedero { get; set; }
    }
}
