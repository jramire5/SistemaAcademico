using Domain.Model;
using Domain.Services;

namespace WebAPI.EndPoints;

public static class TipoPersonaEndpoints
{
    public static void MapTipoPersonaEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/tipo-personas", async (TipoPersona tipo_persona, TipoPersonaService tipoPersonaService) =>
        {
            await tipoPersonaService.Add(tipo_persona);
            return Results.Created($"/tipo-personas/{tipo_persona.id_tipo}", tipo_persona);
        });

        routes.MapGet("/tipo-personas/{id}", async (int id, TipoPersonaService tipoPersonaService) =>
        {
            var tipo_persona = await tipoPersonaService.Get(id);
            return tipo_persona is not null ? Results.Ok(tipo_persona) : Results.NotFound();
        });

        routes.MapGet("/tipo-personas", async (TipoPersonaService tipoPersonaService) =>
        {
            var tipo_persona = await tipoPersonaService.GetAll();
            return Results.Ok(tipo_persona);
        });

        routes.MapPut("/tipo-personas", async (TipoPersona tipo_persona, TipoPersonaService tipoPersonaService) =>
        {
            await tipoPersonaService.Update(tipo_persona);
            return Results.NoContent();
        });

        routes.MapDelete("/tipo-personas/{id}", async (int id, TipoPersonaService tipoPersonaService) =>
        {
            await tipoPersonaService.Delete(id);
            return Results.NoContent();
        });
    }
}
