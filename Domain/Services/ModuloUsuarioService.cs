using Domain.Model;
using Domain.Model.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services;

public class ModuloUsuarioService
{
    public async Task<IEnumerable<MenuItemDto>> GetMenuItems(int idUsuario)
    {
        using var _context = new AcademiaContext();

        List<ModuloUsuario> lista = await _context.modulousuarios
            .Include(mu => mu.Modulo) // Incluir la relación con Modulo
            .Include(mu => mu.Usuario) // Incluir la relación con Usuario
            .Where(m => m.Modulo.ejecuta != "" && m.Usuario.id_usuario== idUsuario && m.Consulta)
            .ToListAsync();

        List<MenuItemDto> listadto = new List<MenuItemDto>();
        foreach (var item in lista)
        {
            listadto.Add(new MenuItemDto()
            {
                label = item.Modulo.descripcion_modulo,
                ejecuta = item.Modulo.ejecuta,
                secuencia= 0         
           
              /*  IdModuloUsuario = item.IdModuloUsuario,
                nombre_usuario = item.Usuario.nombre_usuario,
                nombre_modulo = item.Modulo.descripcion_modulo,
                Alta = item.Alta,
                Baja = item.Baja,
                Modificacion = item.Modificacion,
                Consulta = item.Consulta*/
            });
        }
        return listadto;

    }
    public async Task<List<ModuloUsuarioAutenticadoDto>> GetSeguridadDeModulos(int idUsuario)
    {
        using var _context = new AcademiaContext();

        List<ModuloUsuario> lista = await _context.modulousuarios
            .Include(mu => mu.Modulo) // Incluir la relación con Modulo
            .Include(mu => mu.Usuario) // Incluir la relación con Usuario
            .Where(m => m.Modulo.ejecuta != "" && m.Usuario.id_usuario == idUsuario)
            .ToListAsync();

        List<ModuloUsuarioAutenticadoDto> listadto = new List<ModuloUsuarioAutenticadoDto>();
        foreach (var item in lista)
        {
            listadto.Add(new ModuloUsuarioAutenticadoDto()
            {
                nombre_modulo_ejecuta= item.Modulo.ejecuta,
                Alta=item.Alta,
                Baja=item.Baja,
                Modificacion=item.Modificacion,
                Consulta=item.Consulta

                /*  IdModuloUsuario = item.IdModuloUsuario,
                  nombre_usuario = item.Usuario.nombre_usuario,
                  nombre_modulo = item.Modulo.descripcion_modulo,
                  Alta = item.Alta,
                  Baja = item.Baja,
                  Modificacion = item.Modificacion,
                  Consulta = item.Consulta*/
            });
        }
        return listadto;

    }
    // Obtener todos los registros de ModuloUsuario 
    public async Task<IEnumerable<ModuloUsuarioDto>> GetAll()
    {
        using var _context = new AcademiaContext();

        List<ModuloUsuario> lista = await _context.Set<ModuloUsuario>()
            .Include(mu => mu.Modulo)  // Incluir la relación con Modulo
            .Include(mu => mu.Usuario) // Incluir la relación con Usuario
            .ToListAsync();

        List<ModuloUsuarioDto> listadto = new List<ModuloUsuarioDto>();
        foreach (var item in lista)
        {
            listadto.Add(new ModuloUsuarioDto()
            {
                IdModuloUsuario=item.IdModuloUsuario,
                nombre_usuario = item.Usuario.nombre_usuario,
                nombre_modulo = item.Modulo.descripcion_modulo,
                Alta =item.Alta,
                Baja = item.Baja,
                Modificacion=item.Modificacion,
                Consulta=item.Consulta
            });
        }
        return listadto;

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
