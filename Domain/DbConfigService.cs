using Domain.Model.Settings;
using Newtonsoft.Json;
namespace Domain;

public static class DbConfigService
{
    private const string ConfigFilePath = "dbconfig.json";
   
    private static DbConfig _cachedConfig;

    public static DbConfig GetDbConfig()
    {     
        // la configuración ya está levantada?
        if (_cachedConfig == null)
        {
            if (File.Exists(ConfigFilePath))
            {
                string json = File.ReadAllText(ConfigFilePath);
                _cachedConfig = JsonConvert.DeserializeObject<DbConfig>(json);
            }
            else
                _cachedConfig = new DbConfig();
        }

        return _cachedConfig; // configuracion en cache
    }

    public static string GetDbConnectionString(){

        if (_cachedConfig is null)
           return GetDbConfig().connectionString;

        return _cachedConfig.connectionString;
    }
}