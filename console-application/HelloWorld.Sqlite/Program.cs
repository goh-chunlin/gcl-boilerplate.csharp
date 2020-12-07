using static System.Console;
using Microsoft.EntityFrameworkCore;
using HelloWorld.Sqlite.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using HelloWorld.Sqlite.Data.Contexts;
using HelloWorld.Sqlite.Data.Repositories;

namespace HelloWorld.Sqlite
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Setup our Dependency Injection
            var services = new ServiceCollection();

            services.AddDbContext<MainDbContext>(options => options.UseSqlite("Filename=AppData/sample.db"));
            services.AddTransient<IBuildingService, BuildingService>();
            services.AddScoped(typeof(IRepository<>), typeof(MainRepository<>));

            var serviceProvider = services.BuildServiceProvider();

            var buildingService = serviceProvider.GetService<IBuildingService>();
            var buildings = await buildingService.GetBuildingsAsync();

            foreach (var building in buildings) 
            {
                WriteLine($"Building {building.Id}: {building.Name}");
                WriteLine($"Address: {building.Address}");
                WriteLine();
            }
        }


    }
}
