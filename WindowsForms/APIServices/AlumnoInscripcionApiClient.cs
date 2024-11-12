using Domain.Model;
using Domain.Model.Dtos;
using System.Net.Http.Headers;
using System.Net.Http.Json;
namespace WindowsForms.ApiServices;

public class AlumnoInscripcionApiClient
{
    private static HttpClient client = new HttpClient();

    static AlumnoInscripcionApiClient()
    {      
        client.BaseAddress = new Uri(ApiConfigService.GetApiUrl());
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }


    public static async Task<AlumnoInscripcion> GetAsync(int id)
    {
        AlumnoInscripcion alumnoInscripcion = null;
        HttpResponseMessage response = await client.GetAsync("alumnos-inscripciones/" + id);
        if (response.IsSuccessStatusCode)
        {
            alumnoInscripcion = await response.Content.ReadAsAsync<AlumnoInscripcion>();
        }
        return alumnoInscripcion;
    }
    public static async Task<IEnumerable<AlumnoDropDownDto>> GetAlumnosEnCursoAsync(int idCurso)
    {
        IEnumerable<AlumnoDropDownDto> alumnosEnCurso = null;
        HttpResponseMessage response = await client.GetAsync("alumnos-inscripciones-curso/" + idCurso);
        if (response.IsSuccessStatusCode)
        {
            alumnosEnCurso = await response.Content.ReadAsAsync<IEnumerable<AlumnoDropDownDto>>();
        }
        return alumnosEnCurso;
    }

    

    public static async Task<IEnumerable<AlumnoInscripcionDto>> GetAllAsync(int? idAlumno)
    {
        IEnumerable<AlumnoInscripcionDto> alumnoInscripciones = null;
        HttpResponseMessage response = await client.GetAsync("alumnos-inscripciones/" + idAlumno);
        if (response.IsSuccessStatusCode)
        {
            alumnoInscripciones = await response.Content.ReadAsAsync<IEnumerable<AlumnoInscripcionDto>>();
        }
        return alumnoInscripciones;
    }

    public async static Task AddAsync(AlumnoInscripcion alumnoInscripcion)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("alumnos-inscripciones", alumnoInscripcion);
        response.EnsureSuccessStatusCode();
    }

    public static async Task DeleteAsync(int id)
    {
        HttpResponseMessage response = await client.DeleteAsync("alumnos-inscripciones/" + id);
        response.EnsureSuccessStatusCode();
    }

    public static async Task UpdateAsync(AlumnoInscripcion alumnoInscripcion)
    {
        HttpResponseMessage response = await client.PutAsJsonAsync("alumnos-inscripciones", alumnoInscripcion);
        response.EnsureSuccessStatusCode();
    }
}