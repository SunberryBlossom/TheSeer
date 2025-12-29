using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TheSeer.Business.Interfaces;
using TheSeer.Business.Services;
using TheSeer.Data;
using TheSeer.Data.Interfaces;
using TheSeer.Data.Repositories;
using TheSeer.Presentation.Menus;

namespace TheSeer.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var app = services.GetRequiredService<App>();

                app.Run();
            }
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureLogging((hostingContext, logging) =>
                {
                    logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                })
                .ConfigureServices((hostContext, services) =>
                {
                    var connectionString = "Data Source=ELVIRAS_LAPTOP;Database=TheSeerDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

                    services.AddDbContext<TheSeerDbContext>(options =>
                        options.UseSqlServer(connectionString));

                    services.AddScoped<IUnitOfWork, UnitOfWork>();
                    services.AddScoped<IEncryptionService, EncryptionService>();
                    services.AddScoped<IUserService, UserService>();
                    services.AddScoped<ICatalogService, CatalogService>();
                    services.AddScoped<ISpreadService, SpreadService>();
                    services.AddScoped<IReadingService, ReadingService>();
                    services.AddScoped<IJournalService, JournalService>();
                    services.AddScoped<IFavoriteDeckService, FavoriteDeckService>();

                    services.AddScoped<UserMenu>();
                    services.AddScoped<MainMenu>();
                    services.AddScoped<CatalogMenu>();
                    services.AddScoped<ReadingMenu>();
                    services.AddScoped<JournalMenu>();

                    services.AddTransient<App>();
                });
    }
}