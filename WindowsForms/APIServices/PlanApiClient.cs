using Domain.Model;
using Domain.Model.Dtos;
using System.Net.Http.Headers;
using System.Net.Http.Json;
namespace WindowsForms.ApiServices;
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
    public static async Task<IEnumerable<PlanDropdownDto>> GetDropDownValuesAsync()
    {
        List<PlanDropdownDto> planesDropDown = null;
        HttpResponseMessage response = await client.GetAsync("planes");
        if (response.IsSuccessStatusCode)
        {
            planesDropDown=new List<PlanDropdownDto>();
            IEnumerable<PlanDto> planes = await response.Content.ReadAsAsync<IEnumerable<PlanDto>>();
            foreach (var item in planes)
            {
                planesDropDown.Add(new PlanDropdownDto() { id_plan = item.id_plan, desc_plan_especialidad = $"{item.desc_plan}-{item.desc_especialidad}" });
            }
        }
        return planesDropDown;
    }

    public static async Task<IEnumerable<PlanDto>> GetAllAsync()
    {
        IEnumerable<PlanDto> planes = null;
        HttpResponseMessage response = await client.GetAsync("planes");
        if (response.IsSuccessStatusCode)
        {
            planes = await response.Content.ReadAsAsync<IEnumerable<PlanDto>>();
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