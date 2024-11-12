using Domain.Model;
using Domain.Model.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services;

public class AlumnoInscripcionService
{
    public async Task Add(AlumnoInscripcion alumnoInscripcion)
    {
        using var context = new AcademiaContext();

        context.AlumnosInscripciones.Add(alumnoInscripcion);
        await context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        using var context = new AcademiaContext();

        AlumnoInscripcion? inscripcionToDelete = await context.AlumnosInscripciones.FindAsync(id);

        if (inscripcionToDelete != null)
        {
            context.AlumnosInscripciones.Remove(inscripcionToDelete);
            await context.SaveChangesAsync();
        }
    }

    public async Task<AlumnoInscripcion?> Get(int id)
    {
        using var context = new AcademiaContext();

        return await context.AlumnosInscripciones.FindAsync(id);
    }
    public async Task<IEnumerable<AlumnoDropDownDto>> GetAlumnosPorCurso(int idCurso)
    {
        using var context = new AcademiaContext();

        List<AlumnoInscripcion> lista = await context.AlumnosInscripciones
            .Include(d => d.Persona).Where(i=>i.id_curso== idCurso).ToListAsync();

        List<AlumnoDropDownDto> listadto = new List<AlumnoDropDownDto>();
        foreach (var item in lista)
        {
            listadto.Add(new AlumnoDropDownDto()
            {
                id_persona = item.id_alumno,
                nombre = $"{item.Persona.nombre} {item.Persona.apellido}"            
            });
        }
        return listadto;
    }

    public async Task<IEnumerable<AlumnoInscripcionDto>> GetAll(int? idAlumno)
    {
        using var context = new AcademiaContext();

        List<AlumnoInscripcion> lista = await context.AlumnosInscripciones.Include(d => d.Curso).ThenInclude(d => d.Comision).Include(d => d.Curso).ThenInclude(d => d.Materia).Include(d => d.Persona).Where(i=> idAlumno==null || idAlumno==0 || i.id_alumno== idAlumno).ToListAsync();

        List<AlumnoInscripcionDto> listadto = new List<AlumnoInscripcionDto>();
        foreach (var item in lista)
        {
            listadto.Add(new AlumnoInscripcionDto()
            {
                id_inscripcion = item.id_inscripcion,
                desc_materia = item.Curso.Materia.desc_materia,
                desc_comision = item.Curso.Comision.desc_comision,
                anio_calendario = item.Curso.anio_calendario,
                alumno = $"{item.Persona.nombre} {item.Persona.apellido}"
            });
        }
        return listadto;
    }

    public async Task Update(AlumnoInscripcion alumnoInscripcion)
    {
        using var context = new AcademiaContext();

        AlumnoInscripcion? inscripcionToUpdate = await context.AlumnosInscripciones.FindAsync(alumnoInscripcion.id_inscripcion);

        if (inscripcionToUpdate != null)
        {
            inscripcionToUpdate.id_alumno = alumnoInscripcion.id_alumno;
            inscripcionToUpdate.id_curso = alumnoInscripcion.id_curso;
            inscripcionToUpdate.id_condicion = alumnoInscripcion.id_condicion;
            inscripcionToUpdate.nota = alumnoInscripcion.nota;
            await context.SaveChangesAsync();
        }
    }
}
