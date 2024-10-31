using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services;

public class PersonaService 
{
    public async Task Add(Persona persona)
    {
        using var context = new AcademiaContext();

        context.Personas.Add(persona);
        await context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        using var context = new AcademiaContext();

        Persona? personaToDelete = await context.Personas.FindAsync(id);

        if (personaToDelete != null)
        {
            context.Personas.Remove(personaToDelete);
            await context.SaveChangesAsync();
        }
    }

    public async Task<Persona?> Get(int id)
    {
        using var context = new AcademiaContext();

        return await context.Personas.FindAsync(id);
    }

    public async Task<IEnumerable<Persona>> GetAll()
    {
        using var context = new AcademiaContext();

        return await context.Personas.ToListAsync();
    }

    public async Task Update(Persona persona)
    {
        using var context = new AcademiaContext();

        Persona? personaToUpdate =await context.Personas.FindAsync(persona.id_persona);

        if (personaToUpdate != null)
        {
            personaToUpdate.nombre = persona.nombre;
            personaToUpdate.apellido = persona.apellido;
            personaToUpdate.direccion = persona.direccion;
            personaToUpdate.legajo = persona.legajo;
            personaToUpdate.tipo_persona = persona.tipo_persona;
            personaToUpdate.email = persona.email;
            personaToUpdate.id_plan = persona.id_plan;
            personaToUpdate.fecha_nacimiento = persona.fecha_nacimiento;
            await context.SaveChangesAsync();
        }
    }
}
