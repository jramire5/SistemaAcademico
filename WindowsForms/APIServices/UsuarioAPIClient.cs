using Domain.Model;
using Domain.Model.Dtos;
using System.Net.Http.Headers;
using System.Net.Http.Json;


namespace WindowsForms.APIServices;

//Revisar si no seria mejor usar metodos estaticos        

public class UsuarioAPIClient
{
    private static HttpClient client = new HttpClient();
    static UsuarioAPIClient()
    {
        client.BaseAddress = new Uri("http://localhost:5183/");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }


    public static async Task<Usuario> GetAsync(int id)
    {
        Usuario usuario = null;
        HttpResponseMessage response = await client.GetAsync("usuarios/" + id);
        if (response.IsSuccessStatusCode)
        {
            usuario = await response.Content.ReadAsAsync<Usuario>();
        }
        return usuario;
    }

    public static async Task<IEnumerable<UsuarioDto>> GetAllAsync()
    {
        IEnumerable<UsuarioDto> usuarios = null;
        HttpResponseMessage response = await client.GetAsync("usuarios");
        if (response.IsSuccessStatusCode)
        {
            usuarios = await response.Content.ReadAsAsync<IEnumerable<UsuarioDto>>();
        }
        return usuarios;
    }

    public async static Task AddAsync(Usuario usuario)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("usuarios", usuario);
        response.EnsureSuccessStatusCode();
    }

    public static async Task DeleteAsync(int id)
    {
        HttpResponseMessage response = await client.DeleteAsync("usuarios/" + id);
        response.EnsureSuccessStatusCode();
    }

    public static async Task UpdateAsync(Usuario usuario)
    {
        HttpResponseMessage response = await client.PutAsJsonAsync("usuarios", usuario);
        response.EnsureSuccessStatusCode();
    }
}
