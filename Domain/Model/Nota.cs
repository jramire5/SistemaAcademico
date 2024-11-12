using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model;

public class Nota
{
   public int id_nota { get; set; }
   [ForeignKey("DocenteCurso")]
   public int id_dictado { get; set; }
   [ForeignKey("Persona")]
   public int id_alumno { get; set; }
   public string descripcion { get; set; }
   public int nota { get; set; }

   public virtual Persona Persona { get; set; }
   public virtual DocenteCurso DocenteCurso { get; set; }
}   
