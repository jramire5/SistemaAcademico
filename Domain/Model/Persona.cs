using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model;

public class Persona
{
    public int id_persona { get; set; }
    public string nombre { get; set; }

    public string apellido { get; set; }

    public string direccion { get; set; }

    public string email { get; set; }

    public string telefono { get; set; }

    public DateTime fecha_nacimiento { get; set; }

    public int legajo { get; set; }
    [ForeignKey("Plan")]
    public int? id_plan {  get; set; }

    [ForeignKey("TipoPersona")]
    public int? tipo_persona { get; set; }
    public virtual TipoPersona TipoPersona { get; set; }
    public virtual Plan Plan { get; set; }
}
