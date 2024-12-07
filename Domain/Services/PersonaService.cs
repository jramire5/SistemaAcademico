using Domain.Model;
using Domain.Model.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services;

public class PersonaService 
{
    public async Task Add(Persona persona)
    {
        using var context = new AcademiaContext();

        context.personas.Add(persona);
        await context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        using var context = new AcademiaContext();

        Persona? personaToDelete = await context.personas.FindAsync(id);

        if (personaToDelete != null)
        {
            context.personas.Remove(personaToDelete);
            await context.SaveChangesAsync();
        }
    }

    public async Task<Persona?> Get(int id)
    {
        using var context = new AcademiaContext();

        return await context.personas.FindAsync(id);
    }

    public async Task<IEnumerable<PersonaDto>> GetAll()
    {
        using var context = new AcademiaContext();

        List<Persona> lista=await context.personas.Include(p=>p.Plan).ThenInclude(pl=>pl.Especialidad).Include(p=>p.TipoPersona).ToListAsync();

        List<PersonaDto> listadto = new List<PersonaDto>();
        foreach (var item in lista)
        {
            listadto.Add(new PersonaDto()
            {
                id_persona = item.id_persona,
                nombre=$"{item.apellido} {item.nombre}",
                desc_plan = $"{item.Plan?.desc_plan}-{item.Plan?.Especialidad?.desc_especialidad}",
                desc_tipo_persona = item.TipoPersona.descripcion
            });
        }
        return listadto;
        
    }
    public async Task<IEnumerable<PersonaDto>> GetAll(int tipoPersona)
    {
        using var context = new AcademiaContext();

        List<Persona> lista = await context.personas.Include(p => p.Plan).ThenInclude(pl => pl.Especialidad).Include(p => p.TipoPersona).Where(p=>p.tipo_persona== tipoPersona).ToListAsync();

        List<PersonaDto> listadto = new List<PersonaDto>();
        foreach (var item in lista)
        {
            listadto.Add(new PersonaDto()
            {
                id_persona = item.id_persona,
                nombre = $"{item.apellido} {item.nombre}",
                desc_plan = $"{item.Plan?.desc_plan}-{item.Plan?.Especialidad?.desc_especialidad}",
                desc_tipo_persona = item.TipoPersona.descripcion
            });
        }
        return listadto;

    }

    public async Task Update(Persona persona)
    {
        using var context = new AcademiaContext();

        Persona? personaToUpdate =await context.personas.FindAsync(persona.id_persona);

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
