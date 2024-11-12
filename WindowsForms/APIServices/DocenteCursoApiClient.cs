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
        client.BaseAddress = new Uri(ApiConfigService.GetApiUrl());
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }


    public static async Task<DocenteCurso> GetAsync(int id)
    {
        DocenteCurso docenteCurso = null;
        HttpResponseMessage response = await client.GetAsync("docente-curso/" + id);
        if (response.IsSuccessStatusCode)
        {
            docenteCurso = await response.Content.ReadAsAsync<DocenteCurso>();
        }
        return docenteCurso;
    }
    public static async Task<IEnumerable<DocenteCursoDropdownDto>> GetDropDownValuesAsync(int byDocente)
    {
        List<DocenteCursoDropdownDto> docenteCursoDropDown = null;
        HttpResponseMessage response = await client.GetAsync("cursos-pordocente/"+ byDocente);
        if (response.IsSuccessStatusCode)
        {
            docenteCursoDropDown = new List<DocenteCursoDropdownDto>();
            IEnumerable<DocenteCursoDto> cursosDocente = await response.Content.ReadAsAsync<IEnumerable<DocenteCursoDto>>();
            foreach (var item in cursosDocente)
            {
                docenteCursoDropDown.Add(new DocenteCursoDropdownDto() { id_dictado = item.id_dictado,id_curso=item.id_curso, desc_docenteCurso = $"{item.anio_calendario}-{item.desc_materia}-{item.desc_comision}" });
            }
        }
        return docenteCursoDropDown;
    }
    public static async Task<IEnumerable<DocenteDictadoDto>> GetAllAsync(int idDocente)
    {
        IEnumerable<DocenteDictadoDto> docenteCursoDto = null;
        HttpResponseMessage response = await client.GetAsync("docente-cursos/"+ idDocente);
        if (response.IsSuccessStatusCode)
        {
            docenteCursoDto = await response.Content.ReadAsAsync<IEnumerable<DocenteDictadoDto>>();
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