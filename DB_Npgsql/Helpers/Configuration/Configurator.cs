using System.Reflection;
using DB_Npgsql.Models;
using DB_Npgsql.Models.Enums;
using Microsoft.Extensions.Configuration;

namespace DB_Npgsql.Helpers.Configuration
{
    public static class Configurator
    {
        private static readonly Lazy<IConfiguration> s_configuration;
        public static IConfiguration Configuration => s_configuration.Value;

        static Configurator()
        {
            s_configuration = new Lazy<IConfiguration>(BuildConfiguration);
        }

        private static IConfiguration BuildConfiguration()
        {
            var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var builder = new ConfigurationBuilder()
                .SetBasePath(basePath ?? throw new InvalidOperationException())
                .AddJsonFile("appsettings.json");

            var appSettingFiles = Directory.EnumerateFiles(basePath ?? string.Empty, "appsettings.*.json");

            foreach (var appSettingFile in appSettingFiles)
            {
                builder.AddJsonFile(appSettingFile);
            }

            return builder.Build();
        }

        public static AppSettings AppSettings
        {
            get
            {
                var appSettings = new AppSettings();
                var child = Configuration.GetSection("AppSettings");

                appSettings.URL = child["URL"];
                appSettings.URI = child["URI"];

                return appSettings;
            }
        }
        
        public static DbSettings DbSettings
        {
            get
            {
                var dbSettings = new DbSettings();
                var child = Configuration.GetSection("DbSettings");

                dbSettings.Driver = child["DB_Driver"];
                dbSettings.Server = child["DB_Server"];
                dbSettings.Port = child["DB_Port"];
                dbSettings.Name = child["DB_Name"];
                dbSettings.Username = child["DB_Username"];
                dbSettings.Password = child["DB_Password"];

                return dbSettings;
            }
        }

        public static List<User?> Users
        {
            get
            {
                List<User?> users = new List<User?>();
                var child = Configuration.GetSection("Users");
                foreach (var section in child.GetChildren())
                {
                    var user = new User()
                    {
                        Username = section["Username"],
                        Password = section["Password"]
                    };

                    user.UserType = section["UserType"].ToLower() switch
                    {
                        "admin" => UserType.Admin,
                        "standart" => UserType.Standard,
                        _ => user.UserType
                    };

                    users.Add(user);
                }

                return users;
            }
        }

        public static User? Admin => Users.Find(x => x?.UserType == UserType.Admin);
        public static string? BrowserType => Configuration[nameof(BrowserType)];
        public static double WaitsTimeout => Double.Parse(Configuration[nameof(WaitsTimeout)]);
        public static string? Language => Configuration[nameof(Language)];
    }
}