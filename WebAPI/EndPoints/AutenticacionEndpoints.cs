using Domain.Model.Dtos;
using Domain.Services;

namespace WebAPI.EndPoints;

public static class AutenticacionEndpoints
{
    public static void MapAutenticacionEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/login", async (UsuarioLoginDto loginModel, AutenticacionService autenticacionService, UsuarioService usuarioService) =>
        {
            bool success = await autenticacionService.Login(loginModel);
            if (success)            
                return Results.Ok(await usuarioService.GetByName(loginModel.nombre_usuario));//Obtine el usuario por nombre de usuario.
            
            return  Results.Unauthorized();
        });    
    }
}
