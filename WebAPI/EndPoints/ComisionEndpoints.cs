using Domain.Model;
using Domain.Services;

namespace WebAPI.EndPoints;

public static class ComisionEndpoints
{
    public static void MapComisionEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/comisiones", async (Comision comision, ComisionService comisionService) =>
        {
            await comisionService.Add(comision);
            return Results.Created($"/comisiones/{comision.id_comision}", comision);
        });

        routes.MapGet("/comisiones/{id}", async (int id, ComisionService comisionService) =>
        {
            var comision = await comisionService.Get(id);
            return comision is not null ? Results.Ok(comision) : Results.NotFound();
        });

        routes.MapGet("/comisiones", async (ComisionService comisionService) =>
        {
            var comisiones = await comisionService.GetAll();
            return Results.Ok(comisiones);
        });

        routes.MapPut("/comisiones", async (Comision comision, ComisionService comisionService) =>
        {
            await comisionService.Update(comision);
            return Results.NoContent();
        });

        routes.MapDelete("/comisiones/{id}", async (int id, ComisionService comisionService) =>
        {
            await comisionService.Delete(id);
            return Results.NoContent();
        });
    }
}
