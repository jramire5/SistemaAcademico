namespace Domain.Model.Dtos;

public class ModuloUsuarioAutenticadoDto
{
    public string nombre_modulo_ejecuta { get; set; }
    public bool Alta { get; set; }
    public bool Baja { get; set; }
    public bool Modificacion { get; set; }
    public bool Consulta { get; set; }
}
