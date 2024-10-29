
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model;

public class MateriaDto
{
    public int id_materia { get; set; }

    public string desc_materia { get; set; }

    public int hs_semanales { get; set; }

    public int hs_totales { get; set; }

    public string plan { get; set; }
}