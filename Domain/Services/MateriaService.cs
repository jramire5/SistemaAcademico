using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services;

public class MateriaService
{
    public async Task Add(Materia materia)
    {
        using var context = new AcademiaContext();

        context.Materia.Add(materia);
        context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        using var context = new AcademiaContext();

        Materia? materiaToDelete = await context.Materia.FindAsync(id);

        if (materiaToDelete != null)
        {
            context.Materia.Remove(materiaToDelete);
            await context.SaveChangesAsync();
        }
    }

    public async Task<Materia?> Get(int id)
    {
        using var context = new AcademiaContext();

        return await context.Materia.FindAsync(id);
    }

    public async Task<IEnumerable<Materia>> GetAll()
    {
        using var context = new AcademiaContext();

        return await context.Materia.ToListAsync();
    }

    public async Task Update(Materia materia)
    {
        using var context = new AcademiaContext();

        Materia? materiaToUpdate = await context.Materia.FindAsync(materia.id_materia);

        if (materiaToUpdate != null)
        {
            materiaToUpdate.id_materia = materia.id_materia;
            materiaToUpdate.desc_materia = materia.desc_materia;
            materiaToUpdate.hs_semanales = materia.hs_semanales;
            materiaToUpdate.hs_totales = materia.hs_totales;
            materiaToUpdate.id_plan = materia.id_plan;
            await context.SaveChangesAsync();
        }
    }
}
