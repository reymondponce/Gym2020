using System;
using System.Collections.Generic;

namespace ProyectoFinal2020.Models
{
    public partial class DetallesPedido
    {
        public string IdDetalles { get; set; }
        public string IdPedido { get; set; }

        public virtual Pedido IdPedidoNavigation { get; set; }
    }
}
