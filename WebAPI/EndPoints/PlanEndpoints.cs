using Domain.Model;
using Domain.Services;

namespace WebAPI.EndPoints;

public static class PlanEndpoints
{
    public static void MapPlanEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/planes", async (Plan plan, PlanService planService) =>
        {
            await planService.Add(plan);
            return Results.Created($"/planes/{plan.id_plan}", plan);
        });

        routes.MapGet("/planes/{id}", async (int id, PlanService planService) =>
        {
            var plan = await planService.Get(id);
            return plan is not null ? Results.Ok(plan) : Results.NotFound();
        });

        routes.MapGet("/planes", async (PlanService planService) =>
        {
            var planes = await planService.GetAll();
            return Results.Ok(planes);
        });

        routes.MapPut("/planes", async (Plan plan, PlanService planService) =>
        {
            await planService.Update(plan);
            return Results.NoContent();
        });

        routes.MapDelete("/planes/{id}", async (int id, PlanService planService) =>
        {
            await planService.Delete(id);
            return Results.NoContent();
        });
    }
}
