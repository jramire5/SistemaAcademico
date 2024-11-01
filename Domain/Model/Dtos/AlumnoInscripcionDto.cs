namespace Domain.Model.Dtos;
public class AlumnoInscripcionDto
{
    public int id_inscripcion { get; set; }
    public string alumno { get; set; }    
    public string desc_materia { get; set; }
    public string desc_comision { get; set; }
    public int anio_calendario { get; set; }


}
