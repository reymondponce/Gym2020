using System;
using System.Collections.Generic;

namespace ProyectoFinal2020.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            Pedido = new HashSet<Pedido>();
            Producto = new HashSet<Producto>();
        }

        public string IdProveedor { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public string NombreRepresentante { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<Pedido> Pedido { get; set; }
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
