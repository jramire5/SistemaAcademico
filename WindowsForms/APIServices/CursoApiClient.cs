using Domain.Model;
using Domain.Model.Dtos;
using System.Net.Http.Headers;
using System.Net.Http.Json;
namespace WindowsForms.APIServices;

public class CursoApiClient
{
    private static HttpClient client = new HttpClient();
    static CursoApiClient()
    {
        client.BaseAddress = new Uri("http://localhost:5183/");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }


    public static async Task<Curso> GetAsync(int id)
    {
        Curso curso = null;
        HttpResponseMessage response = await client.GetAsync("cursos/" + id);
        if (response.IsSuccessStatusCode)
        {
            curso = await response.Content.ReadAsAsync<Curso>();
        }
        return curso;
    }

    public static async Task<IEnumerable<CursoDto>> GetAllAsync()
    {
        IEnumerable<CursoDto> cursos = null;
        HttpResponseMessage response = await client.GetAsync("cursos");
        if (response.IsSuccessStatusCode)
        {
            cursos = await response.Content.ReadAsAsync<IEnumerable<CursoDto>>();
        }
        return cursos;
    }
     public static async Task<IEnumerable<CursoDropdownDto>> GetDropDownValuesAsync()
     {
      List<CursoDropdownDto> cursosDropDown = null;
      HttpResponseMessage response = await client.GetAsync("cursos");
      if (response.IsSuccessStatusCode)
      {
            cursosDropDown = new List<CursoDropdownDto>();
          IEnumerable<CursoDto> cursos = await response.Content.ReadAsAsync<IEnumerable<CursoDto>>();
          foreach (var item in cursos)
          {
                cursosDropDown.Add(new CursoDropdownDto() { id_curso = item.id_curso, desc_materia_comi_anio = $"{item.materia_desc}-{item.comision_desc}-{item.anio_calendario}" });
          }
      }
      return cursosDropDown;
     }
    public async static Task AddAsync(Curso curso)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("cursos", curso);
        response.EnsureSuccessStatusCode();
    }

    public static async Task DeleteAsync(int id)
    {
        HttpResponseMessage response = await client.DeleteAsync("cursos/" + id);
        response.EnsureSuccessStatusCode();
    }

    public static async Task UpdateAsync(Curso curso)
    {
        HttpResponseMessage response = await client.PutAsJsonAsync("cursos", curso);
        response.EnsureSuccessStatusCode();
    }
}