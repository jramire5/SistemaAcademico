namespace Domain.Model.Dtos;

public class UsuarioAutenticadoDto
{
    public int id_usuario { get; set; }
    public int? id_persona { get; set; }
    public int? tipo_persona { get; set; }
    public List<ModuloUsuarioAutenticadoDto>? modulos { get; set; }

}
