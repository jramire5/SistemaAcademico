using Domain.Model.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services;

public class AutenticacionService
{
    private string errorMessage;
    public async Task<bool> Login(UsuarioLoginDto loginModel)
    {
        using var context = new AcademiaContext();

        var usuario = await context.usuarios.Where(u => u.nombre_usuario == loginModel.nombre_usuario).FirstOrDefaultAsync();

        if (usuario == null)
        {
            errorMessage = "Usuario o contraseña invalidos.";
            return false;
        }           

        if (!usuario.habilitado)
        {
            errorMessage = "Usuario no habilitado.";
            return false;
        }           

        if (usuario.clave!= loginModel.clave)
        {
            errorMessage = "Usuario o contraseña invalidos.";
            return false;
        }
        return true;
    }
    public string GetErrorMessage() => errorMessage;


}
