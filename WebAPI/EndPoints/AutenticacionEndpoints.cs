using Domain.Model.Dtos;
using Domain.Services;

namespace WebAPI.EndPoints;

public static class AutenticacionEndpoints
{
    public static void MapAutenticacionEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/login", async (UsuarioLoginDto loginModel, AutenticacionService autenticacionService) =>
        {
            bool success = await autenticacionService.Login(loginModel);
            return success ? Results.Ok() : Results.Unauthorized();
        });    
    }
}
