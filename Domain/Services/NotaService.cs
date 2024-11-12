using Domain.Model;
using Domain.Model.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services;

public class NotaService
{
    public async Task Add(NotaUpdateDto nota)
    {
        using var context = new AcademiaContext();

        Nota notaNueva= new Nota();

        notaNueva.id_dictado = nota.id_dictado;
        notaNueva.id_inscripcion = nota.id_inscripcion;
        notaNueva.descripcion = nota.descripcion;            

        AlumnoInscripcion inscripcionToUpdate = await context.AlumnosInscripciones.FindAsync(nota.id_inscripcion);

        if (inscripcionToUpdate == null)        
            throw new Exception("Registro inscripción no fue encontrado");
        

        context.Nota.Add(notaNueva);

        inscripcionToUpdate.nota = nota.nota;

        
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
    public async Task<Nota?> GetByInscripcion(int idInscripcion)
    {
        using var context = new AcademiaContext();

        return await context.Nota.Where(n => n.id_inscripcion == idInscripcion).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<NotaDto>> GetAll()
    {
        using var context = new AcademiaContext();

        List<Nota> notas= 
            await context.Nota.Include(n=>n.AlumnoInscripcion).ThenInclude(i=>i.Persona)//Alumno inscripcion ->Persona (Alumno)
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
                nombre_alumno=$"{item.AlumnoInscripcion?.Persona.nombre} {item.AlumnoInscripcion?.Persona.apellido}",
                nota = item.AlumnoInscripcion?.nota ?? 0
            });
        }
        return listadto;
    }

    public async Task Update(NotaUpdateDto nota)
    {
        using var context = new AcademiaContext();

        Nota? notaToUpdate = await context.Nota.FindAsync(nota.id_nota);
        if (notaToUpdate == null)        
            throw new Exception("Registro Nota no fue encontrado");
        

        AlumnoInscripcion inscripcionToUpdate = await context.AlumnosInscripciones.FindAsync(nota.id_inscripcion);

        if (inscripcionToUpdate == null)        
            throw new Exception("Registro inscripción no fue encontrado");
        

        notaToUpdate.id_nota = nota.id_nota;
        notaToUpdate.id_dictado = nota.id_dictado;
        notaToUpdate.id_inscripcion = nota.id_inscripcion;
        notaToUpdate.descripcion = nota.descripcion;

        inscripcionToUpdate.nota= nota.nota;

        await context.SaveChangesAsync();        
    }
}
