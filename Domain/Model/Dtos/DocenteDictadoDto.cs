namespace Domain.Model.Dtos;
public class DocenteDictadoDto
{
    public int id_dictado { get; set; }
    public string desc_materia { get; set; }
    public string desc_comision { get; set; }
    public int anio_calendario { get; set; }
    public string docente { get; set; }

    public string desc_cargo { get; set; }
}
