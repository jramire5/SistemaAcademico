using Domain.Model;
using Domain.Model.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace Domain.Services;

public class PlanService
{
    public async Task Add(Plan plan)
    {
        using var context = new AcademiaContext();

        context.Planes.Add(plan);
        await context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        using var context = new AcademiaContext();

        Plan? planToDelete = await context.Planes.FindAsync(id);

        if (planToDelete != null)
        {
            context.Planes.Remove(planToDelete);
            await context.SaveChangesAsync();
        }
    }

    public async Task<Plan?> Get(int id)
    {
        using var context = new AcademiaContext();

        return await context.Planes.FindAsync(id);
    }

    public async  Task<IEnumerable<PlanDto>> GetAll()
    {
        using var context = new AcademiaContext();

        List<Plan> lista = await context.Planes.Include(p=>p.Especialidad).ToListAsync();

        List<PlanDto> listadto = new List<PlanDto>();
        foreach (var item in lista)
        {
            listadto.Add(new PlanDto()
            {
                id_plan = item.id_plan,
                desc_plan = item.desc_plan,
                desc_especialidad = item.Especialidad.desc_especialidad               
            });
        }
        return listadto;
    }

    public async Task Update(Plan plan)
    {
        using var context = new AcademiaContext();

        Plan? planToUpdate = await context.Planes.FindAsync(plan.id_plan);

        if (planToUpdate != null)
        {
            planToUpdate.id_plan = plan.id_plan;
            planToUpdate.desc_plan = plan.desc_plan;
            planToUpdate.id_especialidad = plan.id_especialidad;
            await context.SaveChangesAsync();
        }
    }
}
