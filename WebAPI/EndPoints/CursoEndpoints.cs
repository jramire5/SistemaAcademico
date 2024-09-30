using Domain.Model;
using Domain.Services;

namespace WebAPI.EndPoints;

// Endpoints/CursoEndpoints.cs
public static class CursoEndpoints
{
    public static void MapCursoEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/cursos", async (Curso curso, CursoService cursoService) =>
        {
            await cursoService.Add(curso);
            return Results.Created($"/cursos/{curso.id_curso}", curso);
        });

        routes.MapGet("/cursos/{id}", async (int id, CursoService cursoService) =>
        {
            var curso = await cursoService.Get(id);
            return curso is not null ? Results.Ok(curso) : Results.NotFound();
        });

        routes.MapGet("/cursos", async (CursoService cursoService) =>
        {
            var cursos = await cursoService.GetAll();
            return Results.Ok(cursos);
        });

        routes.MapPut("/cursos", async (Curso curso, CursoService cursoService) =>
        {
            await cursoService.Update(curso);
            return Results.NoContent();
        });

        routes.MapDelete("/cursos/{id}", async (int id, CursoService cursoService) =>
        {
            await cursoService.Delete(id);
            return Results.NoContent();
        });
    }
}

