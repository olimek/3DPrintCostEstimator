using Microsoft.Extensions.Logging;
using _3DPrintCostEstimator.Data.Contexts;
using _3DPrintCostEstimator.Data.UnitOfWork;
namespace _3DPrintCostEstimator
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
