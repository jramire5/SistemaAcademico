using Domain.Model;
using System.Net.Http.Headers;
using System.Net.Http.Json;
namespace WindowsForms.APIServices;

public class PlanApiClient
{
    private static HttpClient client = new HttpClient();
    static PlanApiClient()
    {
        client.BaseAddress = new Uri("http://localhost:5183/");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }


    public static async Task<Plan> GetAsync(int id)
    {
        Plan comision = null;
        HttpResponseMessage response = await client.GetAsync("planes/" + id);
        if (response.IsSuccessStatusCode)
        {
            comision = await response.Content.ReadAsAsync<Plan>();
        }
        return comision;
    }

    public static async Task<IEnumerable<Plan>> GetAllAsync()
    {
        IEnumerable<Plan> planes = null;
        HttpResponseMessage response = await client.GetAsync("planes");
        if (response.IsSuccessStatusCode)
        {
            planes = await response.Content.ReadAsAsync<IEnumerable<Plan>>();
        }
        return planes;
    }

    public async static Task AddAsync(Plan comision)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("planes", comision);
        response.EnsureSuccessStatusCode();
    }

    public static async Task DeleteAsync(int id)
    {
        HttpResponseMessage response = await client.DeleteAsync("planes/" + id);
        response.EnsureSuccessStatusCode();
    }

    public static async Task UpdateAsync(Plan comision)
    {
        HttpResponseMessage response = await client.PutAsJsonAsync("planes", comision);
        response.EnsureSuccessStatusCode();
    }
}