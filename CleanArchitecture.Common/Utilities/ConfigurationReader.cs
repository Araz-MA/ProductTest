using Microsoft.Extensions.Configuration;

namespace CleanArchitecture.Common.Utilities
{
    
    public class ConfigurationReader
    {
        private static IConfigurationRoot ConfigurationBuilder()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");
            IConfigurationRoot configuration = builder.Build();
            return configuration;
        }               
        public static string GetSqlConnectionString()
        {
            return ConfigurationBuilder().GetConnectionString("SqlConnection");
        }
        public static string GetRedisConnectionString()
        {
            return ConfigurationBuilder().GetConnectionString("RedisConnection");
        }
        public static string GetSqliteConnectionString()
        {
            return ConfigurationBuilder().GetConnectionString("SqliteConnection");
        }
        public static string GetPostgreSQLConnectionString()
        {
            return ConfigurationBuilder().GetConnectionString("PostgreSQLConnection");
        }
        public static string GetMySqlConnectionString()
        {
            return ConfigurationBuilder().GetConnectionString("MySqlConnection");
        }
    }
}
