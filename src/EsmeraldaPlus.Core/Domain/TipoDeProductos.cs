using System;
using System.Collections.Generic;

namespace EsmeraldaPlus.Web
{
    public partial class TipoDeProductos
    {
        public TipoDeProductos()
        {
            Productos = new HashSet<Productos>();
        }

        public int IdTipoDeProductos { get; set; }
        public string Producto { get; set; }

        public virtual ICollection<Productos> Productos { get; set; }
    }
}
