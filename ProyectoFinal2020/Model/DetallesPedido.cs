using System;
using System.Collections.Generic;

namespace ProyectoFinal2020.Model
{
    public partial class DetallesPedido
    {
        public int IdDetalles { get; set; }
        public int? IdPedido { get; set; }

        public virtual Pedido IdPedidoNavigation { get; set; }
    }
}
