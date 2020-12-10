using System;
using System.Collections.Generic;

namespace EsmeraldaPlus.Infrastructure
{
    public partial class TipoDeInsumo
    {
        public TipoDeInsumo()
        {
            Insumos = new HashSet<Insumos>();
        }

        public int Id { get; set; }
        public string Insumo { get; set; }

        public virtual ICollection<Insumos> Insumos { get; set; }
    }
}
