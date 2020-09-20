using System;
using System.Collections.Generic;

namespace ProyectoFinal2020.Models
{
    public partial class Producto
    {
        public Producto()
        {
            Pedido = new HashSet<Pedido>();
        }

        public string IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string IdProveedor { get; set; }
        public string Existencia { get; set; }
        public DateTime FechaCadu { get; set; }
        public string IdCategoria { get; set; }
        public string PrecioUnidad { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Proveedor IdProveedorNavigation { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
