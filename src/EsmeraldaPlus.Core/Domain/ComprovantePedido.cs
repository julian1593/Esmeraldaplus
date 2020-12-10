using System;
using System.Collections.Generic;

namespace EsmeraldaPlus.Infrastructure
{
    public partial class ComprovantePedido
    {
        public int IdComprovante { get; set; }
        public int? Cantidad { get; set; }
        public int? CostoUnitario { get; set; }
        public int? Total { get; set; }
        public int IdCliente { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
