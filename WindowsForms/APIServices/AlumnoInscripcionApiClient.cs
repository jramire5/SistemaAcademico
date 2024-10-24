﻿using Domain.Model;
using System.Net.Http.Headers;
using System.Net.Http.Json;
namespace WindowsForms.APIServices;

public class AlumnoInscripcionApiClient
{
    private static HttpClient client = new HttpClient();
    static AlumnoInscripcionApiClient()
    {
        client.BaseAddress = new Uri("http://localhost:5183/");
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

    public static async Task<IEnumerable<AlumnoInscripcion>> GetAllAsync()
    {
        IEnumerable<AlumnoInscripcion> alumnoInscripciones = null;
        HttpResponseMessage response = await client.GetAsync("alumnos-inscripciones");
        if (response.IsSuccessStatusCode)
        {
            alumnoInscripciones = await response.Content.ReadAsAsync<IEnumerable<AlumnoInscripcion>>();
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