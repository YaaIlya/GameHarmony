using System.Text.Json.Serialization;
using api_server.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Replace with your connection string.
        var connectionString = "Server=127.0.0.1;Database=games-match;Uid=root;Pwd=TesterPj58#;";

        // Replace with your server version and type.
        // Use 'MariaDbServerVersion' for MariaDB.
        // Alternatively, use 'ServerVersion.AutoDetect(connectionString)'.
        // For common usages, see pull request #1233.
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));

        // services.AddControllers().AddNewtonsoftJson(options =>
        // {
        //     options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        // });

        // services.AddControllers().AddJsonOptions(options =>
        //     options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve
        // );

        // Replace 'YourDbContext' with the name of your own DbContext derived class.
        services.AddDbContext<GamesMatchContext>(
            dbContextOptions => dbContextOptions
                .UseMySql(connectionString, serverVersion)
                // The following three options help with debugging, but should
                // be changed or removed for production.
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors()
        );

        
    }
}