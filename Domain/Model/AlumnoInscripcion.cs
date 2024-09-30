using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Model;

public class AlumnoInscripcion
{
    [Key]
    public int id_inscripcion { get; set; }

    [ForeignKey("Persona")]
    public int id_alumno { get; set; }

    [ForeignKey("Curso")]
    public int id_curso { get; set; }

    [MaxLength(50)]
    public string condicion { get; set; }
    public int nota { get; set; }

    // Navegación
    public virtual Persona Persona { get; set; }
    public virtual Curso Curso { get; set; }
}
