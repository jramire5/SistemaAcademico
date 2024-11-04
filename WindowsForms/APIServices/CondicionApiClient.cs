using Domain.Model;
using System.Net.Http.Headers;
namespace WindowsForms.ApiServices;

//Revisar si no seria mejor usar metodos estaticos        

public class CondicionApiClient
{
    private static HttpClient client = new HttpClient();
    static CondicionApiClient()
    {
        client.BaseAddress = new Uri(ApiConfigService.GetApiUrl());
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }


    public static async Task<Condicion> GetAsync(int id)
    {
        Condicion condicion = null;
        HttpResponseMessage response = await client.GetAsync("condicion/" + id);
        if (response.IsSuccessStatusCode)        
            condicion = await response.Content.ReadAsAsync<Condicion>();
        
        return condicion;
    }

    public static async Task<IEnumerable<Condicion>> GetAllAsync()
    {
        IEnumerable<Condicion> condiciones = null;
        HttpResponseMessage response = await client.GetAsync("condicion");
        if (response.IsSuccessStatusCode)        
            condiciones = await response.Content.ReadAsAsync<IEnumerable<Condicion>>();
        
        return condiciones;
    }
   
}
