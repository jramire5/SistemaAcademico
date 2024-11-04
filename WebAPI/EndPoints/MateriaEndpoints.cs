using Domain.Model;
using Domain.Services;

namespace WebAPI.EndPoints;

// Endpoints/MateriaEndpoints.cs
public static class MateriaEndpoints
{
    public static void MapMateriaEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/materias", async (Materia materia, MateriaService materiaService) =>
        {
            await materiaService.Add(materia);
            return Results.Created($"/materias/{materia.id_materia}", materia);
        });

        routes.MapGet("/materias/{id}", async (int id, MateriaService materiaService) =>
        {
            var materia = await materiaService.Get(id);
            return materia is not null ? Results.Ok(materia) : Results.NotFound();
        });

        routes.MapGet("/materias", async (MateriaService materiaService) =>
        {
            var materias = await materiaService.GetAll();
            return Results.Ok(materias);
        });

        routes.MapPut("/materias", async (Materia materia, MateriaService materiaService) =>
        {
            await materiaService.Update(materia);
            return Results.NoContent();
        });

        routes.MapDelete("/materias/{id}", async (int id, MateriaService materiaService) =>
        {
            await materiaService.Delete(id);
            return Results.NoContent();
        });
    }
}
