using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model;

public class Plan
{
    [Key]
    public int id_plan { get; set; }

    [MaxLength(50)]
    public string desc_plan { get; set; }
    [ForeignKey("Especialidad")]
    public int id_especialidad { get; set; }

    // Navegación
    public virtual Especialidad Especialidad { get; set; }
}
