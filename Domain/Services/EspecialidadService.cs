using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services;

public class EspecialidadService
{
    public async Task Add(Especialidad especialidad)
    {
        using var context = new AcademiaContext();

        context.especialidades.Add(especialidad);
        await context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        using var context = new AcademiaContext();

        Especialidad? especialidadToDelete = await context.especialidades.FindAsync(id);

        if (especialidadToDelete != null)
        {
            context.especialidades.Remove(especialidadToDelete);
            await context.SaveChangesAsync();
        }
    }

    public async Task<Especialidad?> Get(int id)
    {
        using var context = new AcademiaContext();

        return await context.especialidades.FindAsync(id);
    }

    public async Task<IEnumerable<Especialidad>> GetAll()
    {
        using var context = new AcademiaContext();

        return await context.especialidades.ToListAsync();
    }

    public async Task Update(Especialidad especialidad)
    {
        using var context = new AcademiaContext();

        Especialidad? especialidadToUpdate = await context.especialidades.FindAsync(especialidad.id_especialidad);

        if (especialidadToUpdate != null)
        {
            especialidadToUpdate.desc_especialidad = especialidad.desc_especialidad;
            await context.SaveChangesAsync();
        }
    }
}
