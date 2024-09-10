using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Usuario
    {
    public int id_usuario { get; set; }
    public string nombre_usuario { get; set; }

    public string clave {  get; set; }

    public Boolean cambia_clave { get; set; }

    public int id_persona { get; set; }
    public Persona persona { get; set; }
    }
}
