
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model;

public class Materia
{
    public int id_materia { get; set; }

    public string desc_materia { get; set; }

    public int hs_semanales { get; set; }

    public int hs_totales { get; set; }
    [ForeignKey("Plan")]
    public int id_plan { get; set; }
       // Navegación
    public virtual Plan Plan { get; set; }
}