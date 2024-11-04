using Domain.Model;
using System.Net.Http.Headers;

namespace WindowsForms.ApiServices;

public class ModuloUsuarioApiClient
{
    private static HttpClient client = new HttpClient();
    static ModuloUsuarioApiClient()
    {
        client.BaseAddress = new Uri(ApiConfigService.GetApiUrl());
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public static async Task<ModuloUsuario> GetAsync(int id)
    {
        ModuloUsuario moduloUsuario = null;
        HttpResponseMessage response = await client.GetAsync("modulo-usuarios/" + id);
        if (response.IsSuccessStatusCode)
        {
            moduloUsuario = await response.Content.ReadAsAsync<ModuloUsuario>();
        }
        return moduloUsuario;
    }

    public static async Task<IEnumerable<ModuloUsuario>> GetAllAsync()
    {
        IEnumerable<ModuloUsuario> modulos = null;
        HttpResponseMessage response = await client.GetAsync("modulo-usuarios");
        if (response.IsSuccessStatusCode)
        {
            modulos = await response.Content.ReadAsAsync<IEnumerable<ModuloUsuario>>();
        }
        return modulos;
    }

    public async static Task AddAsync(ModuloUsuario moduloUsuario)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("modulo-usuarios", moduloUsuario);
        response.EnsureSuccessStatusCode();
    }

    public static async Task DeleteAsync(int id)
    {
        HttpResponseMessage response = await client.DeleteAsync("modulo-usuarios/" + id);
        response.EnsureSuccessStatusCode();
    }

    public static async Task UpdateAsync(ModuloUsuario moduloUsuario)
    {
        HttpResponseMessage response = await client.PutAsJsonAsync("modulo-usuarios", moduloUsuario);
        response.EnsureSuccessStatusCode();
    }
}
