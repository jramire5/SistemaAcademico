using Domain.Model;
using Domain.Services;

namespace WebAPI.EndPoints;

public static class CargoEndpoints
{
    public static void MapCargoEndpoints(this IEndpointRouteBuilder routes)
    {
      

        routes.MapGet("/cargo/{id}", async (int id, CargoService cargoService) =>
        {
            var cargo = await cargoService.Get(id);
            return cargo is not null ? Results.Ok(cargo) : Results.NotFound();
        });

        routes.MapGet("/cargo", async (CargoService cargoService) =>
        {
            var cargo = await cargoService.GetAll();
            return Results.Ok(cargo);
        });

      
    }
}
