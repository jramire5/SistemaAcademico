using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services;

using Domain.Model;
using Domain.Model.Dtos;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto;
using System.Collections.Generic;
using System.Linq;

public class ComisionService
{
    public async Task Add(Comision comision)
    {
        using var context = new AcademiaContext();

        context.comisiones.Add(comision);
        await context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        using var context = new AcademiaContext();

        Comision? comisionToDelete = await context.comisiones.FindAsync(id);

        if (comisionToDelete != null)
        {
            context.comisiones.Remove(comisionToDelete);
            await context.SaveChangesAsync();
        }
    }

    public async Task<Comision?> Get(int id)
    {
        using var context = new AcademiaContext();

        return await context.comisiones.FindAsync(id);
    }

    public async Task<IEnumerable<ComisionDto>> GetAll()
    {
        using var context = new AcademiaContext();

        List<Comision> lista = await context.comisiones.Include(c=>c.Plan).ThenInclude(p=>p.Especialidad).ToListAsync();

        List<ComisionDto> listadto = new List<ComisionDto>();
        foreach (var item in lista)
        {
            listadto.Add(new ComisionDto()
            {
                id_comision = item.id_comision,
                desc_comision = item.desc_comision,
                anio_especialidad = item.anio_especialidad,
                desc_plan = $"{item.Plan.desc_plan}-{item.Plan.Especialidad.desc_especialidad}"
            });
        }
        return listadto;

        
    }

    public async Task Update(Comision comision)
    {
        using var context = new AcademiaContext();

        Comision? comisionToUpdate = await context.comisiones.FindAsync(comision.id_comision);

        if (comisionToUpdate != null)
        {
            comisionToUpdate.desc_comision = comision.desc_comision;
            comisionToUpdate.anio_especialidad = comision.anio_especialidad;
            comisionToUpdate.id_plan = comision.id_plan;
            await context.SaveChangesAsync();
        }
    }
}

