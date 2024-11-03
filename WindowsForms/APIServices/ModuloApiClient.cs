using Domain.Model;
using System.Net.Http.Headers;

namespace WindowsForms.ApiServices;

public class ModuloApiClient
{
    private static HttpClient client = new HttpClient();
    static ModuloApiClient()
    {
        client.BaseAddress = new Uri("http://localhost:5183/");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public static async Task<Modulo> GetAsync(int id)
    {
        Modulo modulo = null;
        HttpResponseMessage response = await client.GetAsync("modulos/" + id);
        if (response.IsSuccessStatusCode)
        {
            modulo = await response.Content.ReadAsAsync<Modulo>();
        }
        return modulo;
    }

    public static async Task<IEnumerable<Modulo>> GetAllAsync()
    {
        IEnumerable<Modulo> modulos = null;
        HttpResponseMessage response = await client.GetAsync("modulos");
        if (response.IsSuccessStatusCode)
        {
            modulos = await response.Content.ReadAsAsync<IEnumerable<Modulo>>();
        }
        return modulos;
    }

    public async static Task AddAsync(Modulo modulo)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("modulos", modulo);
        response.EnsureSuccessStatusCode();
    }

    public static async Task DeleteAsync(int id)
    {
        HttpResponseMessage response = await client.DeleteAsync("modulos/" + id);
        response.EnsureSuccessStatusCode();
    }

    public static async Task UpdateAsync(Modulo modulo)
    {
        HttpResponseMessage response = await client.PutAsJsonAsync("modulos", modulo);
        response.EnsureSuccessStatusCode();
    }
}
