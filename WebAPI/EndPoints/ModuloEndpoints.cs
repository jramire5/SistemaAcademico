using Domain.Model;
using Domain.Services;

namespace WebAPI.EndPoints;

public static class ModuloEndpoints
{
    public static void MapModuloEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/modulos", async (Modulo modulo, ModuloService moduloService) =>
        {
            await moduloService.Add(modulo);
            return Results.Created($"/modulos/{modulo.Id_modulo}", modulo);
        });

        routes.MapGet("/modulos/{id}", async (int id, ModuloService moduloService) =>
        {
            var modulo = await moduloService.Get(id);
            return modulo is not null ? Results.Ok(modulo) : Results.NotFound();
        });

        routes.MapGet("/modulos", async (ModuloService moduloService) =>
        {
            var modulo = await moduloService.GetAll();
            return Results.Ok(modulo);
        });

        routes.MapPut("/modulos", async (Modulo modulo, ModuloService moduloService) =>
        {
            await moduloService.Update(modulo);
            return Results.NoContent();
        });

        routes.MapDelete("/modulos/{id}", async (int id, ModuloService moduloService) =>
        {
            await moduloService.Delete(id);
            return Results.NoContent();
        });
    }
}
