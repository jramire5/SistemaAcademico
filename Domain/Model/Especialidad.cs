using System.ComponentModel.DataAnnotations;

namespace Domain.Model;

public class Especialidad
{
    [Key]
    public int id_especialidad { get; set; }

    [MaxLength(50)]
    public string desc_especialidad { get; set; }
}
