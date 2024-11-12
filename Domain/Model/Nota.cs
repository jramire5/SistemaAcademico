using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model;

public class Nota
{
   public int id_nota { get; set; }
   [ForeignKey("DocenteCurso")]
   public int id_dictado { get; set; }
   [ForeignKey("AlumnoInscripcion")]
   public int id_inscripcion { get; set; }
   public string descripcion { get; set; }

   public virtual AlumnoInscripcion AlumnoInscripcion { get; set; }
   public virtual DocenteCurso DocenteCurso { get; set; }
}   
