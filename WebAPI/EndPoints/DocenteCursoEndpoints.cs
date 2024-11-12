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

        routes.MapGet("/docente-curso/{id}", async (int id, DocenteCursoService docenteCursoService) =>
        {
            var docenteCurso = await docenteCursoService.Get(id);
            return docenteCurso is not null ? Results.Ok(docenteCurso) : Results.NotFound();
        });
        routes.MapGet("/cursos-pordocente/{iddocente}", async (int iddocente, DocenteCursoService docenteCursoService) =>
        {
            var docenteCursos = await docenteCursoService.GetAllByDocente(iddocente);
            return docenteCursos is not null ? Results.Ok(docenteCursos) : Results.NotFound();
        });
         
        routes.MapGet("/docente-cursos/{idDocente}", async (int idDocente,DocenteCursoService docenteCursoService) =>
        {
            var docenteCursos = await docenteCursoService.GetAll(idDocente);
            return Results.Ok(docenteCursos);
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

