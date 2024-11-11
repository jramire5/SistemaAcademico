using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model;

public class ModuloUsuario
{
    public int IdModuloUsuario { get; set; } // Primary Key

    [ForeignKey("Modulo")]
    public int IdModulo { get; set; } 
    [ForeignKey("Usuario")]
    public int IdUsuario { get; set; } 

    // Permisos
    public bool Alta { get; set; }
    public bool Baja { get; set; }
    public bool Modificacion { get; set; }
    public bool Consulta { get; set; }

    public virtual Modulo Modulo { get; set; } 
    public virtual Usuario Usuario { get; set; } 
}
