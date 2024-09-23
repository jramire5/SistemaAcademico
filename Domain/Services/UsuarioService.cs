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

    public Usuario? Get(int id)
    {
        using var context = new AcademiaContext();

        return context.Usuarios.Find(id);
    }

    public IEnumerable<Usuario> GetAll()
    {
        using var context = new AcademiaContext();

        return context.Usuarios.ToList();
    }

    public void Update(Usuario usuario)
    {
        using var context = new AcademiaContext();

        Usuario? usuarioToUpdate = context.Usuarios.Find(usuario.id_usuario);

        if (usuarioToUpdate != null)
        {
            usuarioToUpdate.nombre_usuario = usuario.nombre_usuario;
            usuarioToUpdate.id_persona = usuario.id_persona;
            usuarioToUpdate.clave = usuario.clave;
            usuarioToUpdate.cambia_clave = usuario.cambia_clave;
            context.SaveChanges();
        }
    }
}
