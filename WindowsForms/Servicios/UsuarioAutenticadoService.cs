
using Domain.Model.Dtos;

namespace WindowsForms.Servicios;

public static class UsuarioAutenticadoService
{
    public static UsuarioAutenticadoDto usuarioAutenticado;

    /// <summary>
    /// Acceso a Crear.
    /// </summary>
    /// <param name="modulo"></param>
    /// <returns></returns>
    public static bool AccedeAAlta(string modulo) => usuarioAutenticado is not null && usuarioAutenticado.modulos is not null &&
        usuarioAutenticado.modulos.Where(m => m.nombre_modulo_ejecuta == modulo && m.Alta).Any();

    /// <summary>
    /// Acceso a modificar.
    /// </summary>
    /// <param name="modulo"></param>
    /// <returns></returns>
    public static bool AccedeAModificar(string modulo)=> usuarioAutenticado is not null && usuarioAutenticado.modulos is not null&& 
        usuarioAutenticado.modulos.Where(m=> m.nombre_modulo_ejecuta==modulo && m.Modificacion).Any();

    /// <summary>
    /// Acceso a eliminar.
    /// </summary>
    /// <param name="modulo"></param>
    /// <returns></returns>
    public static bool AccedeABaja(string modulo) => usuarioAutenticado is not null && usuarioAutenticado.modulos is not null &&
        usuarioAutenticado.modulos.Where(m => m.nombre_modulo_ejecuta == modulo && m.Baja).Any();

    /// <summary>
    /// Metodo para ver si el usuario es un alumno
    /// </summary>
    /// <returns></returns>
    public static bool isAlumno() => usuarioAutenticado is not null && usuarioAutenticado.tipo_persona ==2;

    public static bool isDocente() => usuarioAutenticado is not null && usuarioAutenticado.tipo_persona == 1;
}
