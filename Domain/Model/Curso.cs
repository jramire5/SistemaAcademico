using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model;

public class Curso
{
    public int id_curso { get; set; }

    [ForeignKey("Materia")]
    public int id_materia { get; set; }

    [ForeignKey("Comision")]
    public int id_comision { get; set; }

    public int anio_calendario { get; set; }
    public int cupo { get; set; }

    // Navegación
    public virtual Materia Materia { get; set; }
    public virtual Comision Comision { get; set; }
}
