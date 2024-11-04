using Domain.Model;
using Domain.Model.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services;

public class DocenteCursoService 
{
    public async Task Add(DocenteCurso docenteCurso)
    {
        using var context = new AcademiaContext();

        context.Add(docenteCurso);
        await context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        using var context = new AcademiaContext();

        DocenteCurso? docenteCursoToDelete = await context.DocenteCurso.FindAsync(id);

        if (docenteCursoToDelete != null)
        {
            context.DocenteCurso.Remove(docenteCursoToDelete);
            await context.SaveChangesAsync();
        }
    }

    public async Task<DocenteCurso?> Get(int id)
    {
        using var context = new AcademiaContext();

        return await context.DocenteCurso.FindAsync(id);
    }

    public async Task<IEnumerable<DocenteCursoDto>> GetAll()
    {
        using var context = new AcademiaContext();

        List<DocenteCurso> lista = await context.DocenteCurso.Include(d=>d.Curso).ThenInclude(d => d.Comision).Include(d => d.Curso).ThenInclude(d=>d.Materia).Include(d=>d.Persona).Include(d=>d.Cargo).ToListAsync();

        List<DocenteCursoDto> listadto = new List<DocenteCursoDto>();
        foreach (var item in lista)
        {
            listadto.Add(new DocenteCursoDto()
            {
                id_dictado = item.id_dictado,
                desc_materia = item.Curso.Materia.desc_materia,
                desc_comision = item.Curso.Comision.desc_comision,
                anio_calendario = item.Curso.anio_calendario,
                docente = $"{item.Persona.nombre} {item.Persona.apellido}",
                desc_cargo = item.Cargo?.Descripcion ?? string.Empty
            });
        }
        return listadto;

    }

    public async Task Update(DocenteCurso docenteCurso)
    {
        using var context = new AcademiaContext();
        DocenteCurso? docenteCursoToUpdate = await context.DocenteCurso.FindAsync(docenteCurso.id_dictado);

        if (docenteCursoToUpdate != null)
        {
            docenteCursoToUpdate.id_dictado = docenteCurso.id_dictado;
            docenteCursoToUpdate.id_curso = docenteCurso.id_curso;
            docenteCursoToUpdate.id_docente = docenteCurso.id_docente;
            docenteCursoToUpdate.id_cargo = docenteCurso.id_cargo;
        
            await context.SaveChangesAsync();
        }
    }
}
