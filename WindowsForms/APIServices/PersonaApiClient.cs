﻿using Domain.Model;
using Domain.Model.Dtos;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace WindowsForms.ApiServices;

//Revisar si no seria mejor usar metodos estaticos        

public class PersonaApiClient
{
    private static HttpClient client = new HttpClient();
    static PersonaApiClient()
    {
        client.BaseAddress = new Uri(ApiConfigService.GetApiUrl());
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }


    public static async Task<Persona> GetAsync(int id)
    {
        Persona persona = null;
        HttpResponseMessage response = await client.GetAsync("personas/" + id);
        if (response.IsSuccessStatusCode)
        {
            persona = await response.Content.ReadAsAsync<Persona>();
        }
        return persona;
    }
    public static async Task<IEnumerable<PersonaDto>> GetDropDownValuesAsync()
    {
        List<PersonaDto>? personas = (await GetAllAsync())?.ToList();  
        
        if(personas is null)
            personas=new List<PersonaDto>(); 

        personas.Insert(0,new PersonaDto() { id_persona = 0, nombre = "Sin Selección" });//Agrega valor sin selección 
        return personas;
    }
    public static async Task<IEnumerable<PersonaDto>> GetAllAsync()
    {
        IEnumerable<PersonaDto> personas = null;
        HttpResponseMessage response = await client.GetAsync("personas");
        if (response.IsSuccessStatusCode)
        {
            personas = await response.Content.ReadAsAsync<IEnumerable<PersonaDto>>();
        }
        return personas;
    }
    public static async Task<IEnumerable<PersonaDto>> GetDocentesAsync()
    {
        IEnumerable<PersonaDto> personas = null;
        HttpResponseMessage response = await client.GetAsync("docentes");
        if (response.IsSuccessStatusCode)
        {
            personas = await response.Content.ReadAsAsync<IEnumerable<PersonaDto>>();
        }
        return personas;
    }
    public static async Task<IEnumerable<PersonaDto>> GetAlumnosAsync()
    {
        IEnumerable<PersonaDto> personas = null;
        HttpResponseMessage response = await client.GetAsync("alumnos");
        if (response.IsSuccessStatusCode)
        {
            personas = await response.Content.ReadAsAsync<IEnumerable<PersonaDto>>();
        }
        return personas;
    }

    public async static Task AddAsync(Persona persona)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("personas", persona);
        response.EnsureSuccessStatusCode();
    }

    public static async Task DeleteAsync(int id)
    {
        HttpResponseMessage response = await client.DeleteAsync("personas/" + id);
        response.EnsureSuccessStatusCode();
    }

    public static async Task UpdateAsync(Persona persona)
    {
        HttpResponseMessage response = await client.PutAsJsonAsync("personas", persona);
        response.EnsureSuccessStatusCode();
    }
}
