﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model;

public class Comision
{
    public int id_comision { get; set; }
    public string desc_comision { get; set; }

    public int anio_especialidad { get; set; }
    [ForeignKey("Plan")]
    public int id_plan { get; set; }
    // Navegación
    public virtual Plan Plan { get; set; }
}
