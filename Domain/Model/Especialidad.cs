using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model;

public class Especialidad
{
    [Key]
    public int id_especialidad { get; set; }

    [MaxLength(50)]
    public string desc_especialidad { get; set; }
}
