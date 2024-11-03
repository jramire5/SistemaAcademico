using Domain.Model;
using Domain.Services;

namespace WebAPI.EndPoints;

public static class ModuloUsuarioEndpoints
{
    public static void MapModuloUsuarioEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/modulo-usuarios", async (ModuloUsuario moduloUsuario, ModuloUsuarioService moduloUsuarioService) =>
        {
            await moduloUsuarioService.Add(moduloUsuario);
            return Results.Created($"/modulo-usuarios/{moduloUsuario.IdModuloUsuario}", moduloUsuario);
        });

        routes.MapGet("/modulo-usuarios/{id}", async (int id, ModuloUsuarioService moduloUsuarioService) =>
        {
            var moduloUsuario = await moduloUsuarioService.Get(id);
            return moduloUsuario is not null ? Results.Ok(moduloUsuario) : Results.NotFound();
        });

        routes.MapGet("/modulo-usuarios", async (ModuloUsuarioService moduloUsuarioService) =>
        {
            var moduloUsuario = await moduloUsuarioService.GetAll();
            return Results.Ok(moduloUsuario);
        });

        routes.MapPut("/modulo-usuarios", async (ModuloUsuario moduloUsuario, ModuloUsuarioService moduloUsuarioService) =>
        {
            await moduloUsuarioService.Update(moduloUsuario);
            return Results.NoContent();
        });

        routes.MapDelete("/modulo-usuarios/{id}", async (int id, ModuloUsuarioService moduloUsuarioService) =>
        {
            await moduloUsuarioService.Delete(id);
            return Results.NoContent();
        });
    }
}
