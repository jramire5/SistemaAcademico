using Domain.Model;
using Domain.Services;

namespace WebAPI.EndPoints;

public static class EspecialidadEndpoints
{
    public static void MapEspecialidadEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/especialidades", async (Especialidad especialidad, EspecialidadService especialidadService) =>
        {
            await especialidadService.Add(especialidad);
            return Results.Created($"/especialidades/{especialidad.id_especialidad}", especialidad);
        });

        routes.MapGet("/especialidades/{id}", async (int id, EspecialidadService especialidadService) =>
        {
            var especialidad = await especialidadService.Get(id);
            return especialidad is not null ? Results.Ok(especialidad) : Results.NotFound();
        });

        routes.MapGet("/especialidades", async (EspecialidadService especialidadService) =>
        {
            var especialidades = await especialidadService.GetAll();
            return Results.Ok(especialidades);
        });

        routes.MapPut("/especialidades", async (Especialidad especialidad, EspecialidadService especialidadService) =>
        {
            await especialidadService.Update(especialidad);
            return Results.NoContent();
        });

        routes.MapDelete("/especialidades/{id}", async (int id, EspecialidadService especialidadService) =>
        {
            await especialidadService.Delete(id);
            return Results.NoContent();
        });
    }
}