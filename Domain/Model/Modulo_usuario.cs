using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class ModuloUsuario
    {
        public int IdModuloUsuario { get; set; } // Primary Key

        // Foreign Keys
        public int IdModulo { get; set; } // Foreign key to Modulo
        public int IdUsuario { get; set; } // Foreign key to Usuario

        // Permisos
        public bool Alta { get; set; }
        public bool Baja { get; set; }
        public bool Modificacion { get; set; }
        public bool Consulta { get; set; }

        public Modulo Modulo { get; set; } // Navigation property for the Modulo entity
        public Usuario Usuario { get; set; } // Navigation property for the Usuario entity
    }

}
