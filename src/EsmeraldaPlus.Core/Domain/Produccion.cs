using System;
using System.Collections.Generic;

namespace EsmeraldaPlus.Infrastructure
{
    public partial class Produccion
    {
        public int IdProduccion { get; set; }
        public int IdEstado { get; set; }
        public int IdEmpleado { get; set; }
        public int IdInsumos { get; set; }
        public string UnidadDeMedida { get; set; }
        public int? CantidadInsumos { get; set; }
        public string ProductoP { get; set; }

        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual Estado IdEstadoNavigation { get; set; }
        public virtual Insumos IdInsumosNavigation { get; set; }
    }
}
