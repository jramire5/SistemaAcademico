using Domain.Model;
using System.Net.Http.Headers;
using System.Net.Http.Json;
namespace WindowsForms.ApiServices;

public class MateriaApiClient
{
    private static HttpClient client = new HttpClient();
    static MateriaApiClient()
    {
        client.BaseAddress = new Uri(ApiConfigService.GetApiUrl());
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }


    public static async Task<Materia> GetAsync(int id)
    {
        Materia materia = null;
        HttpResponseMessage response = await client.GetAsync("materias/" + id);
        if (response.IsSuccessStatusCode)
        {
            materia = await response.Content.ReadAsAsync<Materia>();
        }
        return materia;
    }

    public static async Task<IEnumerable<MateriaDto>> GetAllAsync()
    {
        IEnumerable<MateriaDto> materias = null;
        HttpResponseMessage response = await client.GetAsync("materias");
        if (response.IsSuccessStatusCode)
        {
            materias = await response.Content.ReadAsAsync<IEnumerable<MateriaDto>>();
        }
        return materias;
    }

    public async static Task AddAsync(Materia materia)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("materias", materia);
        response.EnsureSuccessStatusCode();
    }

    public static async Task DeleteAsync(int id)
    {
        HttpResponseMessage response = await client.DeleteAsync("materias/" + id);
        response.EnsureSuccessStatusCode();
    }

    public static async Task UpdateAsync(Materia persona)
    {
        HttpResponseMessage response = await client.PutAsJsonAsync("materias", persona);
        response.EnsureSuccessStatusCode();
    }
}