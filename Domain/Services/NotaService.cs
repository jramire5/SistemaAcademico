using Domain.Model;
using Domain.Model.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services;

public class NotaService
{
    public async Task Add(Nota nota)
    {
        using var context = new AcademiaContext();

        context.Nota.Add(nota);
        await context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        using var context = new AcademiaContext();

        Nota? notaToDelete = await context.Nota.FindAsync(id);

        if (notaToDelete != null)
        {
            context.Nota.Remove(notaToDelete);
            await context.SaveChangesAsync();
        }
    }

    public async Task<Nota?> Get(int id)
    {
        using var context = new AcademiaContext();

        return await context.Nota.FindAsync(id);
    }

    public async Task<IEnumerable<NotaDto>> GetAll()
    {
        using var context = new AcademiaContext();

        List<Nota> notas= 
            await context.Nota.Include(n=>n.Persona)//Alumno
            .Include(n=>n.DocenteCurso).ThenInclude(d=>d.Persona)//Docente
            .Include(n => n.DocenteCurso).ThenInclude(d => d.Curso).ThenInclude(c => c.Materia)//Docente->Curso->Materia
            .Include(n => n.DocenteCurso).ThenInclude(d => d.Curso).ThenInclude(c => c.Comision)//Docente->Curso->Comision
            .ToListAsync();

        List<NotaDto> listadto = new List<NotaDto>();
        foreach (var item in notas)
        {
            listadto.Add(new NotaDto()
            {
                id_nota =item.id_nota,
                nombre_docente=$"{item.DocenteCurso.Persona.nombre} {item.DocenteCurso.Persona.apellido}",
                materia= $"{item.DocenteCurso.Curso.Materia.desc_materia}",
                comision = $"{item.DocenteCurso.Curso.Comision.desc_comision}",
                anio_calendario = item.DocenteCurso.Curso.anio_calendario,
                nota_descr = item.descripcion,
                nombre_alumno=$"{item.Persona.nombre} {item.Persona.apellido}",
                nota = item.nota
            });
        }
        return listadto;
    }

    public async Task Update(Nota nota)
    {
        using var context = new AcademiaContext();

        Nota? notaToUpdate = await context.Nota.FindAsync(nota.id_nota);

        if (notaToUpdate != null)
        {
            notaToUpdate.id_nota = nota.id_nota;
            notaToUpdate.id_dictado = nota.id_dictado;
            notaToUpdate.id_alumno = nota.id_alumno;
            notaToUpdate.descripcion = nota.descripcion;
            notaToUpdate.nota = nota.nota;
            await context.SaveChangesAsync();
        }
    }
}
