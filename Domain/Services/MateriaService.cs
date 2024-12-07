using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services;

public class MateriaService
{
    public async Task Add(Materia materia)
    {
        using var context = new AcademiaContext();

        context.materia.Add(materia);
        await context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        using var context = new AcademiaContext();

        Materia? materiaToDelete = await context.materia.FindAsync(id);

        if (materiaToDelete != null)
        {
            context.materia.Remove(materiaToDelete);
            await context.SaveChangesAsync();
        }
    }

    public async Task<Materia?> Get(int id)
    {
        using var context = new AcademiaContext();

        return await context.materia.FindAsync(id);
    }

    public async Task<IEnumerable<MateriaDto>> GetAll()
    {
        using var context = new AcademiaContext();

        List<Materia> materias= await context.materia.Include(m=>m.Plan).ToListAsync();

        List<MateriaDto> listadto = new List<MateriaDto>();
        foreach (var item in materias)
        {
            listadto.Add(new MateriaDto()
            {
                id_materia=item.id_materia,
                desc_materia=item.desc_materia,
                hs_semanales=item.hs_semanales,
                hs_totales = item.hs_totales,
                plan=item.Plan.desc_plan
            });
        }
        return listadto;
    }

    public async Task Update(Materia materia)
    {
        using var context = new AcademiaContext();

        Materia? materiaToUpdate = await context.materia.FindAsync(materia.id_materia);

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
