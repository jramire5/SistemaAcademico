using Domain.Model;
using Domain.Model.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services;

public class UsuarioService 
{
    public async Task Add(Usuario usuario)
    {
        using var context = new AcademiaContext();

        context.Add(usuario);
        await context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        using var context = new AcademiaContext();

        Usuario? usuarioToDelete = await context.Usuarios.FindAsync(id);

        if (usuarioToDelete != null)
        {
            context.Usuarios.Remove(usuarioToDelete);
            await context.SaveChangesAsync();
        }
    }
    public async Task<Usuario?> GetByName(string userName)
    {
        using var context = new AcademiaContext();
        return await context.Usuarios.Where(u => u.nombre_usuario == userName).Include(u=>u.Persona).ThenInclude(p=>p.TipoPersona).FirstOrDefaultAsync();
    }
    public async Task<Usuario?> Get(int id)
    {
        using var context = new AcademiaContext();

        return await context.Usuarios.FindAsync(id);
    }

    public async Task<IEnumerable<UsuarioDto>> GetAll()
    {
        using var context = new AcademiaContext();

        List<Usuario> lista = await context.Usuarios.Include(u=>u.Persona).ThenInclude(p=>p.TipoPersona).ToListAsync();

        List<UsuarioDto> listadto = new List<UsuarioDto>();
        foreach (var item in lista)
        {
            listadto.Add(new UsuarioDto()
            {
                id_usuario = item.id_usuario,
                nombre_usuario = item.nombre_usuario,
                nombre = !string.IsNullOrEmpty(item.nombre) ? item.nombre : item.Persona.nombre,
                apellido = !string.IsNullOrEmpty(item.apellido) ? item.apellido : item.Persona.apellido,
                email = !string.IsNullOrEmpty(item.email) ? item.email : item.Persona.email,
                tipo_persona_descr = (item.id_persona is null || item.id_persona == 0) ? string.Empty : item.Persona.TipoPersona.descripcion
            });
        }
        return listadto;

    }

    public async Task Update(Usuario usuario)
    {
        using var context = new AcademiaContext();

        Usuario? usuarioToUpdate = await context.Usuarios.FindAsync(usuario.id_usuario);

        if (usuarioToUpdate != null)
        {
            usuarioToUpdate.nombre_usuario = usuario.nombre_usuario;            
            usuarioToUpdate.clave = usuario.clave;
            usuarioToUpdate.cambia_clave = usuario.cambia_clave;
            usuarioToUpdate.nombre = usuario.nombre;
            usuarioToUpdate.apellido = usuario.apellido;
            usuarioToUpdate.email = usuario.email;
            usuarioToUpdate.cambia_clave = usuario.cambia_clave;
            usuarioToUpdate.habilitado = usuario.habilitado;
            usuarioToUpdate.id_persona = usuario.id_persona;
            await context.SaveChangesAsync();
        }
    }
}
