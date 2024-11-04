using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model;
public class DocenteCurso
{
    public int id_dictado { get; set; }
    [ForeignKey("Curso")]

    public int id_curso { get; set; }
    [ForeignKey("Persona")]

    public int id_docente { get; set; }
    [ForeignKey("Cargo")]
    public int? id_cargo { get; set; }

    public virtual Curso Curso { get; set; }
    public virtual Persona Persona { get; set; }

    public virtual Cargo Cargo { get; set; }


}
