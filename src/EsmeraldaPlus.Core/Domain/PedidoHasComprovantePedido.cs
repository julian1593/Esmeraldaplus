using System;
using System.Collections.Generic;

namespace EsmeraldaPlus.Infrastructure
{
    public partial class PedidoHasComprovantePedido
    {
        public int IdPedido { get; set; }
        public int IdComprovante { get; set; }

        public virtual ComprovantePedido IdComprovanteNavigation { get; set; }
        public virtual Pedido IdPedidoNavigation { get; set; }
    }
}
