using Domain.Model;
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

    public async Task<IEnumerable<AlumnoInscripcion>> GetAll()
    {
        using var context = new AcademiaContext();

        return await context.AlumnosInscripciones.ToListAsync();
    }

    public async Task Update(AlumnoInscripcion alumnoInscripcion)
    {
        using var context = new AcademiaContext();

        AlumnoInscripcion? inscripcionToUpdate = await context.AlumnosInscripciones.FindAsync(alumnoInscripcion.id_inscripcion);

        if (inscripcionToUpdate != null)
        {
            inscripcionToUpdate.id_alumno = alumnoInscripcion.id_alumno;
            inscripcionToUpdate.id_curso = alumnoInscripcion.id_curso;
            inscripcionToUpdate.condicion = alumnoInscripcion.condicion;
            inscripcionToUpdate.nota = alumnoInscripcion.nota;
            await context.SaveChangesAsync();
        }
    }
}
