using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model;

public class Comision
{
    [Key]
    public int id_comision { get; set; }

    [MaxLength(50)]
    public string desc_comision { get; set; }

    public int anio_especialidad { get; set; }
    [ForeignKey("Plan")]
    public int id_plan { get; set; }

    // Navegación
    public virtual Plan Plan { get; set; }
}
