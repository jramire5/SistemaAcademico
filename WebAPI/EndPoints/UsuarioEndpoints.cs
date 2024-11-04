using Domain.Model;
using Domain.Services;

namespace WebAPI.EndPoints;

public static class UsuarioEndpoints
{
    public static void MapUsuarioEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/usuarios", async (Usuario usuario, UsuarioService usuarioService) =>
        {
            await usuarioService.Add(usuario);
            return Results.Created($"/usuarios/{usuario.id_usuario}", usuario);
        });

        routes.MapGet("/usuarios/{id}", async (int id, UsuarioService usuarioService) =>
        {
            var usuario = await usuarioService.Get(id);
            return usuario is not null ? Results.Ok(usuario) : Results.NotFound();
        });

        routes.MapGet("/usuarios", async (UsuarioService usuarioService) =>
        {
            var usuarios = await usuarioService.GetAll();
            return Results.Ok(usuarios);
        });

        routes.MapPut("/usuarios", async (Usuario usuario, UsuarioService usuarioService) =>
        {
            await usuarioService.Update(usuario);
            return Results.NoContent();
        });

        routes.MapDelete("/usuarios/{id}", async (int id, UsuarioService usuarioService) =>
        {
            await usuarioService.Delete(id);
            return Results.NoContent();
        });
    }
}
