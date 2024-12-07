using Domain.Model;
using Domain.Model.Dtos;
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

        context.cursos.Add(curso);
        await context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        using var context = new AcademiaContext();

        Curso? cursoToDelete = await context.cursos.FindAsync(id);

        if (cursoToDelete != null)
        {
            context.cursos.Remove(cursoToDelete);
            await context.SaveChangesAsync();
        }
    }

    public async Task<Curso?> Get(int id)
    {
        using var context = new AcademiaContext();

        return await context.cursos.FindAsync(id);
    }
    public async Task<IEnumerable<CursoDto>> GetAllPorPersona(int id_persona)
    {
        using var context = new AcademiaContext();


        PersonaService personaService = new PersonaService();
        var persona=await personaService.Get(id_persona);

        List<Curso> cursos = await context.cursos.Include(c => c.Materia).Include(c => c.Comision).Where(c=>c.Materia.id_plan== persona.id_plan && c.anio_calendario==System.DateTime.Now.Year).ToListAsync();

        List<CursoDto> listadto = new List<CursoDto>();
        foreach (var item in cursos)
        {
            listadto.Add(new CursoDto()
            {
                id_curso = item.id_curso,
                anio_calendario = item.anio_calendario,
                cupo = item.cupo,
                materia_desc = item.Materia.desc_materia,
                comision_desc = item.Comision.desc_comision
            });
        }
        return listadto;

    }
    public async  Task<IEnumerable<CursoDto>> GetAll()
    {
        using var context = new AcademiaContext();

        List<Curso> cursos = await context.cursos.Include(c=>c.Materia).Include(c=>c.Comision).ToListAsync();

        List<CursoDto> listadto = new List<CursoDto>();
        foreach (var item in cursos)
        {
            listadto.Add(new CursoDto()
            {
                id_curso = item.id_curso,
                anio_calendario = item.anio_calendario,
                cupo = item.cupo,
                materia_desc = item.Materia.desc_materia,
                comision_desc = item.Comision.desc_comision
            });
        }
        return listadto;

    }

    public async Task Update(Curso curso)
    {
        using var context = new AcademiaContext();

        Curso? cursoToUpdate = await context.cursos.FindAsync(curso.id_curso);

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
