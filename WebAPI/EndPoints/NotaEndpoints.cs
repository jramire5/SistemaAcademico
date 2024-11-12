using Domain.Model;
using Domain.Services;

namespace WebAPI.EndPoints;

public static class NotaEndpoints
{
    public static void MapNotaEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/notas", async (NotaUpdateDto nota, NotaService notaService) =>
        {
            await notaService.Add(nota);
            return Results.Created($"/notas/{nota.id_nota}", nota);
        });

        routes.MapGet("/notas/{id}", async (int id, NotaService notaService) =>
        {
            var nota = await notaService.Get(id);
            return nota is not null ? Results.Ok(nota) : Results.NotFound();
        });
        routes.MapGet("/notas-inscripcion/{idInscripcion}", async (int idInscripcion, NotaService notaService) =>
        {
            var nota = await notaService.GetByInscripcion(idInscripcion);
            return nota is not null ? Results.Ok(nota) : Results.NotFound();
        });
        
        routes.MapGet("/notas", async (NotaService notaService) =>
        {
            var modulo = await notaService.GetAll();
            return Results.Ok(modulo);
        });

        routes.MapPut("/notas", async (NotaUpdateDto nota, NotaService notaService) =>
        {
            await notaService.Update(nota);
            return Results.NoContent();
        });

        routes.MapDelete("/notas/{id}", async (int id, NotaService notaService) =>
        {
            await notaService.Delete(id);
            return Results.NoContent();
        });
    }
}
