using Domain.Model;
using Domain.Model.Dtos;
using Domain.Services;

namespace WebAPI.EndPoints;

public static class AutenticacionEndpoints
{
    public static void MapAutenticacionEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/login", async (UsuarioLoginDto loginModel, AutenticacionService autenticacionService, UsuarioService usuarioService, ModuloUsuarioService modulosUsuario) =>
        {
            bool success = await autenticacionService.Login(loginModel);
            if (success)
            {
                //   return Results.Ok(await usuarioService.GetByName(loginModel.nombre_usuario));//Obtine el usuario por nombre de usuario.

                UsuarioAutenticadoDto authUser=new UsuarioAutenticadoDto();
                Usuario user = await usuarioService.GetByName(loginModel.nombre_usuario);
                authUser.id_usuario = user.id_usuario;
                authUser.id_persona= user.id_persona; 
                authUser.tipo_persona=user.Persona?.tipo_persona ?? 0;
                authUser.modulos= await modulosUsuario.GetSeguridadDeModulos(user.id_usuario);
                return Results.Ok(authUser);
            }
             
            return  Results.Unauthorized();
        });    
    }
}
