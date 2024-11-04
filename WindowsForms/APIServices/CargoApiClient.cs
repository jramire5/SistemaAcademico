using Domain.Model;
using System.Net.Http.Headers;
namespace WindowsForms.ApiServices;

//Revisar si no seria mejor usar metodos estaticos        

public class CargoApiClient
{
    private static HttpClient client = new HttpClient();
    static CargoApiClient()
    {
        client.BaseAddress = new Uri(ApiConfigService.GetApiUrl());
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }


    public static async Task<Cargo> GetAsync(int id)
    {
        Cargo cargo = null;
        HttpResponseMessage response = await client.GetAsync("cargo/" + id);
        if (response.IsSuccessStatusCode)
            cargo = await response.Content.ReadAsAsync<Cargo>();
        
        return cargo;
    }

    public static async Task<IEnumerable<Cargo>> GetAllAsync()
    {
        IEnumerable<Cargo> cargo = null;
        HttpResponseMessage response = await client.GetAsync("cargo");
        if (response.IsSuccessStatusCode)
            cargo = await response.Content.ReadAsAsync<IEnumerable<Cargo>>();
        
        return cargo;
    }
   
}
