using Microsoft.Extensions.Logging;
using FDMPrintCostEstimator.Data.Contexts;
using FDMPrintCostEstimator.Data.UnitOfWork;
namespace FDMPrintCostEstimator
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddDbContext<ProjectContext>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            return builder.Build();
        }
    }
}
