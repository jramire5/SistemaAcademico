using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model;

public class Plan
{
    public int id_plan { get; set; }
    public string desc_plan { get; set; }
    [ForeignKey("Especialidad")]
    public int id_especialidad { get; set; }

    // Navegación
    public virtual Especialidad Especialidad { get; set; }
}
