using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services;

public class CondicionService
{   
    public async Task<Condicion?> Get(int id)
    {
        using var context = new AcademiaContext();

        return await context.condicion.FindAsync(id);
    }

    public async Task<IEnumerable<Condicion>> GetAll()
    {
        using var context = new AcademiaContext();

        List<Condicion> lista = await context.condicion.ToListAsync();

        return lista;

    }  
}
