using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model;

public class AlumnoInscripcion
{   
    public int id_inscripcion { get; set; }
    [ForeignKey("Persona")]
    public int id_alumno { get; set; }
    [ForeignKey("Curso")]
    public int id_curso { get; set; }   
    public string condicion { get; set; }
    public int nota { get; set; }

    // Navegación
    public virtual Persona Persona { get; set; }
    public virtual Curso Curso { get; set; }
}
