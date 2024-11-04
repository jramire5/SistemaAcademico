using Domain.Model;
using Domain.Services;

namespace WebAPI.EndPoints;

public static class PersonaEndpoints
{
    public static void MapPersonaEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/personas", async (Persona persona, PersonaService personaService) =>
        {
            await personaService.Add(persona);
            return Results.Created($"/personas/{persona.id_persona}", persona);
        });

        routes.MapGet("/personas/{id}", async (int id, PersonaService personaService) =>
        {
            var persona = await personaService.Get(id);
            return persona is not null ? Results.Ok(persona) : Results.NotFound();
        });

        routes.MapGet("/personas", async (PersonaService personaService) =>
        {
            var persona = await personaService.GetAll();
            return Results.Ok(persona);
        });
        routes.MapGet("/docentes", async (PersonaService personaService) =>
        {
            var persona = await personaService.GetAll(1);
            return Results.Ok(persona);
        });
        routes.MapGet("/alumnos", async (PersonaService personaService) =>
        {
            var persona = await personaService.GetAll(2);
            return Results.Ok(persona);
        });

        routes.MapPut("/personas", async (Persona persona, PersonaService personaService) =>
        {
            await personaService.Update(persona);
            return Results.NoContent();
        });

        routes.MapDelete("/personas/{id}", async (int id, PersonaService personaService) =>
        {
            await personaService.Delete(id);
            return Results.NoContent();
        });
    }
}
