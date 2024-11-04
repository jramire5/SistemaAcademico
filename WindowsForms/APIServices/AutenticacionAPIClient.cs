using Domain.Model;
using Domain.Model.Dtos;
using System.Net.Http.Headers;
using System.Net.Http.Json;


namespace WindowsForms.ApiServices;

//Revisar si no seria mejor usar metodos estaticos        

public class AutenticacionApiClient
{
    private static HttpClient client = new HttpClient();
    static AutenticacionApiClient()
    {
        client.BaseAddress = new Uri("http://localhost:5183/");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }


    public static async Task<bool> Login(UsuarioLoginDto loginDto)
    {

        HttpResponseMessage response = await client.PostAsJsonAsync("login", loginDto);
        if (response.IsSuccessStatusCode)
        {
            
        }
        return response.IsSuccessStatusCode;
    }

}
