using Domain.Model.Settings;
using Newtonsoft.Json;
namespace WindowsForms.ApiServices;


public static class ApiConfigService
{
    private const string ConfigFilePath = "config.json";
   
    private static ApiConfig _cachedConfig;

    public static ApiConfig GetApiConfig()
    {     
        // Check if the configuration has already been loaded
        if (_cachedConfig == null)
        {
            if (File.Exists(ConfigFilePath))
            {
                string json = File.ReadAllText(ConfigFilePath);
                _cachedConfig = JsonConvert.DeserializeObject<ApiConfig>(json);
            }
            else
            {
                _cachedConfig = new ApiConfig(); // Optionally initialize to default values
            }
        }

        return _cachedConfig; // Return the cached configuration
    }

    public static string GetApiUrl(){

        if (_cachedConfig is null)
           return GetApiConfig().ApiUrl;

        return _cachedConfig.ApiUrl;
    }
}