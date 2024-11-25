using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using MauiShop.Data;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using MauiShop.Servuces;
namespace MauiShop
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            string dbPath;

#if ANDROID
dbPath = Path.Combine(FileSystem.AppDataDirectory, "mydata.db");
#elif WINDOWS
            dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "myshopdata.db");
#elif IOS || MACCATALYST
dbPath = Path.Combine(FileSystem.AppDataDirectory, "mydata.db");
#else
throw new PlatformNotSupportedException("Unsupported platform");
#endif

           

            builder.Services.AddDbContext<ShopingContext>(options =>
                options.UseSqlite($"Data Source={dbPath}"));

            builder.Services.AddSingleton<ShopingServicesDB>();

                    using var dbContext = new ShopingContext(
            new DbContextOptionsBuilder<ShopingContext>()
                .UseSqlite($"Data Source={dbPath}")
                .Options);
            dbContext.Database.EnsureCreated();

            //var dbPath1 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "mydata.db");
            //Debug.WriteLine($"Database path: {dbPath}");

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
       
    }
}
