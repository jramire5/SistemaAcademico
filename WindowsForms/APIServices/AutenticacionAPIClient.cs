using Domain.Model.Dtos;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using WindowsForms.Servicios;


namespace WindowsForms.ApiServices;

//Revisar si no seria mejor usar metodos estaticos        

public class AutenticacionApiClient
{
    private static HttpClient client = new HttpClient();
    static AutenticacionApiClient()
    {
        client.BaseAddress = new Uri(ApiConfigService.GetApiUrl());
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }


    public static async Task<bool> Login(UsuarioLoginDto loginDto)
    {
        UsuarioAutenticadoDto usuarioAutenticado;
        HttpResponseMessage response = await client.PostAsJsonAsync("login", loginDto);
        if (response.IsSuccessStatusCode)
        {
            usuarioAutenticado = await response.Content.ReadAsAsync<UsuarioAutenticadoDto>();

            UsuarioAutenticadoService.usuarioAutenticado = usuarioAutenticado;//Setea el usuario autenticado.
        }
        return response.IsSuccessStatusCode;
    }

}
