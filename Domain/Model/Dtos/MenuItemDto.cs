namespace Domain.Model.Dtos;

public class MenuItemDto
{
    public string label { get; set; }
    public string ejecuta { get; set; }
    public int secuencia { get; set; }
    public bool Alta { get; set; }
    public bool Baja { get; set; }
    public bool Modificacion { get; set; }
    public bool Consulta { get; set; }
}
