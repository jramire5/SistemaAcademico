namespace Domain.Model.Dtos;

public class ModuloUsuarioDto
{
    public int IdModuloUsuario { get; set; } 
    public string nombre_usuario { get; set; } 
    public string nombre_modulo { get; set; }
    public bool Alta { get; set; }
    public bool Baja { get; set; }
    public bool Modificacion { get; set; }
    public bool Consulta { get; set; }
}
