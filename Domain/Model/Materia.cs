
namespace Domain.Model;

public class Materia
{

    public int id_materia { get; set; }

    public string desc_materia { get; set; }

    public int hs_semanales { get; set; }

    public int hs_totales { get; set; }

    public int id_plan { get; set; }
}