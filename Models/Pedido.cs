﻿using System;
using System.Collections.Generic;

namespace ProyectoFinal2020.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            DetallesPedido = new HashSet<DetallesPedido>();
        }

        public string IdProveedor { get; set; }
        public string IdPedido { get; set; }
        public string IdProducto { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCompra { get; set; }
        public decimal? PrecioUnidad { get; set; }
        public int? UnidadSolicitada { get; set; }
        public decimal? Importe { get; set; }
        public string Estado { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
        public virtual Proveedor IdProveedorNavigation { get; set; }
        public virtual ICollection<DetallesPedido> DetallesPedido { get; set; }
    }
}
