using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model;

public class Curso
{
    [Key]
    public int id_curso { get; set; }

    [ForeignKey("Materia")]
    public int id_materia { get; set; }

    [ForeignKey("Comision")]
    public int id_comision { get; set; }

    public int anio_calendario { get; set; }
    public int cupo { get; set; }

    // Navegación
    public virtual Plan Materia { get; set; }
    public virtual Comision Comision { get; set; }
}
