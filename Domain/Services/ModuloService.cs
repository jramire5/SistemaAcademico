using Domain.Model;
using Microsoft.EntityFrameworkCore;
namespace Domain.Services;

public class ModuloService
{
    public async Task Add (Modulo modulo)
    {
        using var context = new AcademiaContext();
        context.modulos.Add(modulo);
        await context.SaveChangesAsync();
    }
    public async Task<Modulo> Get(int id)
    {
        using var context = new AcademiaContext();
        return await context.modulos.FindAsync(id);
    }

    public async Task<IEnumerable<Modulo>> GetAll()
    {
        using var context = new AcademiaContext();

        return await context.modulos.ToListAsync();
    }

    public async Task Update(Modulo modulo)
    {
        using var context = new AcademiaContext();
        context.modulos.Update(modulo);
        await context.SaveChangesAsync();
    }
    public async Task Delete(int id)
    {
        using var context = new AcademiaContext();
        Modulo moduloABorrar = await context.modulos.FindAsync(id);
        if (moduloABorrar != null)
        {
            context.modulos.Remove(moduloABorrar);
            await context.SaveChangesAsync();
        }
    }
}
