using Domain.Model;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace WindowsForms.ApiServices;

//Revisar si no seria mejor usar metodos estaticos        

public class TipoPersonaApiClient
{
    private static HttpClient client = new HttpClient();
    static TipoPersonaApiClient()
    {
        client.BaseAddress = new Uri("http://localhost:5183/");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }


    public static async Task<TipoPersona> GetAsync(int id)
    {
        TipoPersona tipo_persona = null;
        HttpResponseMessage response = await client.GetAsync("tipo-personas/" + id);
        if (response.IsSuccessStatusCode)
        {
            tipo_persona = await response.Content.ReadAsAsync<TipoPersona>();
        }
        return tipo_persona;
    }

    public static async Task<IEnumerable<TipoPersona>> GetAllAsync()
    {
        IEnumerable<TipoPersona> personas = null;
        HttpResponseMessage response = await client.GetAsync("tipo-personas");
        if (response.IsSuccessStatusCode)
        {
            personas = await response.Content.ReadAsAsync<IEnumerable<TipoPersona>>();
        }
        return personas;
    }

    public async static Task AddAsync(TipoPersona tipo_persona)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("tipo-personas", tipo_persona);
        response.EnsureSuccessStatusCode();
    }

    public static async Task DeleteAsync(int id)
    {
        HttpResponseMessage response = await client.DeleteAsync("tipo-personas/" + id);
        response.EnsureSuccessStatusCode();
    }

    public static async Task UpdateAsync(TipoPersona tipo_persona)
    {
        HttpResponseMessage response = await client.PutAsJsonAsync("tipo-personas", tipo_persona);
        response.EnsureSuccessStatusCode();
    }
}
