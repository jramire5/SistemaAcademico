using Domain.Model;
using Domain.Services;

namespace WebAPI.EndPoints;

public static class CondicionEndpoints
{
    public static void MapCondicionEndpoints(this IEndpointRouteBuilder routes)
    {
      

        routes.MapGet("/condicion/{id}", async (int id, CondicionService condicionService) =>
        {
            var condcion = await condicionService.Get(id);
            return condcion is not null ? Results.Ok(condcion) : Results.NotFound();
        });

        routes.MapGet("/condicion", async (CondicionService condicionService) =>
        {
            var condciones = await condicionService.GetAll();
            return Results.Ok(condciones);
        });

      
    }
}
