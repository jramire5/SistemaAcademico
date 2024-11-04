using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services;

public class ModuloUsuarioService
{

    // Obtener todos los registros de ModuloUsuario
    public async Task<IEnumerable<ModuloUsuario>> GetAll()
    {
        using var _context = new AcademiaContext();

        return await _context.Set<ModuloUsuario>()
            .Include(mu => mu.Modulo)  // Incluir la relación con Modulo
            .Include(mu => mu.Usuario) // Incluir la relación con Usuario
            .ToListAsync();
    }

    // Obtener un ModuloUsuario por ID
    public async Task<ModuloUsuario> Get(int id)
    {
        using var _context = new AcademiaContext();

        return await _context.Set<ModuloUsuario>()
            .Include(mu => mu.Modulo)
            .Include(mu => mu.Usuario)
            .FirstOrDefaultAsync(mu => mu.IdModuloUsuario == id);
    }

    // Agregar un nuevo ModuloUsuario
    public async Task Add(ModuloUsuario moduloUsuario)
    {
        using var _context = new AcademiaContext();
        _context.Set<ModuloUsuario>().Add(moduloUsuario);
        await _context.SaveChangesAsync();
    }

    // Actualizar un ModuloUsuario existente
    public async Task Update(ModuloUsuario moduloUsuario)
    {
        using var _context = new AcademiaContext();
        _context.Set<ModuloUsuario>().Update(moduloUsuario);
       await _context.SaveChangesAsync();
    }

    // Eliminar un ModuloUsuario por ID
    public async Task Delete(int id)
    {
        using var _context = new AcademiaContext();
        var moduloUsuario = await _context.Set<ModuloUsuario>().FindAsync(id);
        if (moduloUsuario != null)
        {
            _context.Set<ModuloUsuario>().Remove(moduloUsuario);
            await _context.SaveChangesAsync();
        }
    }
}
