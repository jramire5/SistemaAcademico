using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services;

public class CursoService
{
    public async Task Add(Curso curso)
    {
        using var context = new AcademiaContext();

        context.Cursos.Add(curso);
        await context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        using var context = new AcademiaContext();

        Curso? cursoToDelete = await context.Cursos.FindAsync(id);

        if (cursoToDelete != null)
        {
            context.Cursos.Remove(cursoToDelete);
            await context.SaveChangesAsync();
        }
    }

    public async Task<Curso?> Get(int id)
    {
        using var context = new AcademiaContext();

        return await context.Cursos.FindAsync(id);
    }

    public async  Task<IEnumerable<Curso>> GetAll()
    {
        using var context = new AcademiaContext();

        return await context.Cursos.ToListAsync();
    }

    public async Task Update(Curso curso)
    {
        using var context = new AcademiaContext();

        Curso? cursoToUpdate = await context.Cursos.FindAsync(curso.id_curso);

        if (cursoToUpdate != null)
        {
            cursoToUpdate.id_materia = curso.id_materia;
            cursoToUpdate.id_comision = curso.id_comision;
            cursoToUpdate.anio_calendario = curso.anio_calendario;
            cursoToUpdate.cupo = curso.cupo;
            await context.SaveChangesAsync();
        }
    }
}
