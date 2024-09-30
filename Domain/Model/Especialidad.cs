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
    public int IdEspecialidad { get; set; }

    [MaxLength(50)]
    public string DescEspecialidad { get; set; }
}
