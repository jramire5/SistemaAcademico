using Domain.Model;
using Domain.Model.Dtos;
using System.Net.Http.Headers;
using System.Net.Http.Json;
namespace WindowsForms.ApiServices;
public class ComisionApiClient
{
    private static HttpClient client = new HttpClient();
    static ComisionApiClient()
    {
        client.BaseAddress = new Uri(ApiConfigService.GetApiUrl());
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }


    public static async Task<Comision> GetAsync(int id)
    {
        Comision comision = null;
        HttpResponseMessage response = await client.GetAsync("comisiones/" + id);
        if (response.IsSuccessStatusCode)
        {
            comision = await response.Content.ReadAsAsync<Comision>();
        }
        return comision;
    }

    public static async Task<IEnumerable<ComisionDto>> GetAllAsync()
    {
        IEnumerable<ComisionDto> comisiones = null;
        HttpResponseMessage response = await client.GetAsync("comisiones");
        if (response.IsSuccessStatusCode)
        {
            comisiones = await response.Content.ReadAsAsync<IEnumerable<ComisionDto>>();
        }
        return comisiones;
    }

    public async static Task AddAsync(Comision comision)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("comisiones", comision);
        response.EnsureSuccessStatusCode();
    }

    public static async Task DeleteAsync(int id)
    {
        HttpResponseMessage response = await client.DeleteAsync("comisiones/" + id);
        response.EnsureSuccessStatusCode();
    }

    public static async Task UpdateAsync(Comision comision)
    {
        HttpResponseMessage response = await client.PutAsJsonAsync("comisiones", comision);
        response.EnsureSuccessStatusCode();
    }
}