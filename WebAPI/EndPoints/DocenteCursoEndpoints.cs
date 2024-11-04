using Domain.Model;
using Domain.Services;

namespace WebAPI.EndPoints;

// Endpoints/DocenteCursoEndpoints.cs
public static class DocenteCursoEndpoints
{
    public static void MapDocenteCursoEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/docente-cursos", async (DocenteCurso docenteCurso, DocenteCursoService docenteCursoService) =>
        {
            await docenteCursoService.Add(docenteCurso);
            return Results.Created($"/docente-cursos/{docenteCurso.id_dictado}", docenteCurso);
        });

        routes.MapGet("/docente-cursos/{id}", async (int id, DocenteCursoService docenteCursoService) =>
        {
            var inscripcion = await docenteCursoService.Get(id);
            return inscripcion is not null ? Results.Ok(inscripcion) : Results.NotFound();
        });

        routes.MapGet("/docente-cursos", async (DocenteCursoService docenteCursoService) =>
        {
            var inscripciones = await docenteCursoService.GetAll();
            return Results.Ok(inscripciones);
        });

        routes.MapPut("/docente-cursos", async (DocenteCurso docenteCurso, DocenteCursoService docenteCursoService) =>
        {
            await docenteCursoService.Update(docenteCurso);
            return Results.NoContent();
        });

        routes.MapDelete("/docente-cursos/{id}", async (int id, DocenteCursoService docenteCursoService) =>
        {
            await docenteCursoService.Delete(id);
            return Results.NoContent();
        });
    }
}

