
namespace Domain.Model.Dtos;

public class NotaDto
{
   public int id_nota { get; set; }
   public string nombre_docente { get; set; }
   public string materia { get; set; }
   public string comision { get; set; }
   public int anio_calendario { get; set; }
   public string nota_descr { get; set; }
   public string nombre_alumno { get; set; }
   public int nota { get; set; }
}   
