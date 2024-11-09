using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model;

public class Usuario
{
    public int id_usuario { get; set; }
    public string nombre_usuario { get; set; }
    public string clave {  get; set; }
    public string? nombre { get; set; }
    public string? apellido { get; set; }
    public string email { get; set; }
    public bool cambia_clave { get; set; }
    public bool habilitado { get; set; }
    [ForeignKey("Persona")]
    public int? id_persona { get; set; }
    public Persona Persona { get; set; }
}
