using Domain.Model;

namespace Domain.Services;

public class UsuarioService 
{
    public void Add(Usuario usuario)
    {
        using var context = new AcademiaContext();

        context.Add(usuario);
        context.SaveChanges();
    }

    public void Delete(int id)
    {
        using var context = new AcademiaContext();

        Usuario? usuarioToDelete = context.Usuarios.Find(id);

        if (usuarioToDelete != null)
        {
            context.Usuarios.Remove(usuarioToDelete);
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
