using Domain.Model;
using Domain.Model.Dtos;
using System.Net.Http.Headers;
using System.Net.Http.Json;
namespace WindowsForms.ApiServices;
public class DocenteCursoApiClient
{
    private static HttpClient client = new HttpClient();
    static DocenteCursoApiClient()
    {
        client.BaseAddress = new Uri("http://localhost:5183/");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }


    public static async Task<DocenteCurso> GetAsync(int id)
    {
        DocenteCurso docenteCurso = null;
        HttpResponseMessage response = await client.GetAsync("docente-cursos/" + id);
        if (response.IsSuccessStatusCode)
        {
            docenteCurso = await response.Content.ReadAsAsync<DocenteCurso>();
        }
        return docenteCurso;
    }
   /* public static async Task<IEnumerable<PlanDropdownDto>> GetDropDownValuesAsync()
    {
        List<PlanDropdownDto> planesDropDown = null;
        HttpResponseMessage response = await client.GetAsync("docente-cursos");
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
    }*/

    public static async Task<IEnumerable<DocenteCursoDto>> GetAllAsync()
    {
        IEnumerable<DocenteCursoDto> docenteCursoDto = null;
        HttpResponseMessage response = await client.GetAsync("docente-cursos");
        if (response.IsSuccessStatusCode)
        {
            docenteCursoDto = await response.Content.ReadAsAsync<IEnumerable<DocenteCursoDto>>();
        }
        return docenteCursoDto;
    }

    public async static Task AddAsync(DocenteCurso docenteCurso)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("docente-cursos", docenteCurso);
        response.EnsureSuccessStatusCode();
    }

    public static async Task DeleteAsync(int id)
    {
        HttpResponseMessage response = await client.DeleteAsync("docente-cursos/" + id);
        response.EnsureSuccessStatusCode();
    }

    public static async Task UpdateAsync(DocenteCurso docenteCurso)
    {
        HttpResponseMessage response = await client.PutAsJsonAsync("docente-cursos", docenteCurso);
        response.EnsureSuccessStatusCode();
    }
}