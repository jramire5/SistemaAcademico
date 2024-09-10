using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model;

public class Persona
{
    public int id_persona { get; set; }
    public string nombre { get; set; }

    public string apellido { get; set; }

    public string direccion { get; set; }

    public string email { get; set; }

    public int telefono { get; set; }

    public DateTime fecha_nacimiento { get; set; }

    public int legajo { get; set; }

    public int? id_plan {  get; set; }

    public int? tipo_persona { get; set; }
}
