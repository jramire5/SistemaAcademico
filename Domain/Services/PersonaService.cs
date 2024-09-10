using Domain.Model;

namespace Domain.Services;

public class PersonaService 
{
    public void Add(Persona persona)
    {
        using var context = new AcademiaContext();

        context.Personas.Add(persona);
        context.SaveChanges();
    }

    public void Delete(int id)
    {
        using var context = new AcademiaContext();

        Persona? personaToDelete = context.Personas.Find(id);

        if (personaToDelete != null)
        {
            context.Personas.Remove(personaToDelete);
            context.SaveChanges();
        }
    }

    public Persona? Get(int id)
    {
        using var context = new AcademiaContext();

        return context.Personas.Find(id);
    }

    public IEnumerable<Persona> GetAll()
    {
        using var context = new AcademiaContext();

        return context.Personas.ToList();
    }

    public void Update(Persona persona)
    {
        using var context = new AcademiaContext();

        Persona? personaToUpdate = context.Personas.Find(persona.id_persona);

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
            context.SaveChanges();
        }
    }
}
