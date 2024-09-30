using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services;

using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto;
using System.Collections.Generic;
using System.Linq;

public class ComisionService
{
    public async Task Add(Comision comision)
    {
        using var context = new AcademiaContext();

        context.Comisiones.Add(comision);
        await context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        using var context = new AcademiaContext();

        Comision? comisionToDelete = await context.Comisiones.FindAsync(id);

        if (comisionToDelete != null)
        {
            context.Comisiones.Remove(comisionToDelete);
            await context.SaveChangesAsync();
        }
    }

    public async Task<Comision?> Get(int id)
    {
        using var context = new AcademiaContext();

        return await context.Comisiones.FindAsync(id);
    }

    public async Task<IEnumerable<Comision>> GetAll()
    {
        using var context = new AcademiaContext();

        return await context.Comisiones.ToListAsync();
    }

    public async Task Update(Comision comision)
    {
        using var context = new AcademiaContext();

        Comision? comisionToUpdate = await context.Comisiones.FindAsync(comision.id_comision);

        if (comisionToUpdate != null)
        {
            comisionToUpdate.desc_comision = comision.desc_comision;
            comisionToUpdate.anio_especialidad = comision.anio_especialidad;
            comisionToUpdate.id_plan = comision.id_plan;
            await context.SaveChangesAsync();
        }
    }
}

