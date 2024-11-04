namespace Domain.Model.Dtos;

public class CursoDto
{
    public int id_curso { get; set; }
    public int anio_calendario { get; set; }
    public int cupo { get; set; }
    public string materia_desc { get; set; }
    public string comision_desc { get; set; }
}
