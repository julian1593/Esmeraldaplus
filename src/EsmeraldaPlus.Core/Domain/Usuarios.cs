using System;
using System.Collections.Generic;

namespace EsmeraldaPlus.Infrastructure
{
    public partial class Usuarios
    {
        public int IdUsuarios { get; set; }
        public int IdRoles { get; set; }

        public virtual Roles IdRolesNavigation { get; set; }
    }
}
