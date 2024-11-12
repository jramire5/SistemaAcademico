using Domain.Model;
using Domain.Model.Dtos;
using System.Net.Http.Headers;
using System.Net.Http.Json;
namespace WindowsForms.ApiServices;

public class NotaApiClient
{
    private static HttpClient client = new HttpClient();
    static NotaApiClient()
    {
        client.BaseAddress = new Uri(ApiConfigService.GetApiUrl());
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }


    public static async Task<Nota> GetAsync(int id)
    {
        Nota nota = null;
        HttpResponseMessage response = await client.GetAsync("notas/" + id);
        if (response.IsSuccessStatusCode)
        {
            nota = await response.Content.ReadAsAsync<Nota>();
        }
        return nota;
    }

    public static async Task<IEnumerable<NotaDto>> GetAllAsync()
    {
        IEnumerable<NotaDto> notas = null;
        HttpResponseMessage response = await client.GetAsync("notas");
        if (response.IsSuccessStatusCode)
        {
            notas = await response.Content.ReadAsAsync<IEnumerable<NotaDto>>();
        }
        return notas;
    }

    public async static Task AddAsync(Nota nota)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("notas", nota);
        response.EnsureSuccessStatusCode();
    }

    public static async Task DeleteAsync(int id)
    {
        HttpResponseMessage response = await client.DeleteAsync("notas/" + id);
        response.EnsureSuccessStatusCode();
    }

    public static async Task UpdateAsync(Nota nota)
    {
        HttpResponseMessage response = await client.PutAsJsonAsync("notas", nota);
        response.EnsureSuccessStatusCode();
    }
}