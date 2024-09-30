using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Model;

public class AlumnoInscripcion
{
    [Key]
    public int IdInscripcion { get; set; }

    [ForeignKey("Persona")]
    public int IdAlumno { get; set; }

    [ForeignKey("Curso")]
    public int IdCurso { get; set; }

    [MaxLength(50)]
    public string Condicion { get; set; }
    public int Nota { get; set; }

    // Navegación
    public virtual Persona Persona { get; set; }
    public virtual Curso Curso { get; set; }
}
