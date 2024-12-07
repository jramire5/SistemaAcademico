using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services;

public class TipoPersonaService
{
    public async Task Add(TipoPersona usuario)
    {
        using var context = new AcademiaContext();

        context.Add(usuario);
        await context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        using var context = new AcademiaContext();

        TipoPersona? tipoToDelete = await context.tipopersona.FindAsync(id);

        if (tipoToDelete != null)
        {
            context.tipopersona.Remove(tipoToDelete);
            await context.SaveChangesAsync();
        }
    }

    public async Task<TipoPersona?> Get(int id)
    {
        using var context = new AcademiaContext();

        return await context.tipopersona.FindAsync(id);
    }

    public async Task<IEnumerable<TipoPersona>> GetAll()
    {
        using var context = new AcademiaContext();

        List<TipoPersona> lista = await context.tipopersona.ToListAsync();

        return lista;

    }

    public async Task Update(TipoPersona tipo)
    {
        using var context = new AcademiaContext();

        TipoPersona? tipoToUpdate = await context.tipopersona.FindAsync(tipo.id_tipo);

        if (tipoToUpdate != null)
        {
            tipoToUpdate.descripcion = tipo.descripcion;
            await context.SaveChangesAsync();
        }
    }
}
