using dymaptic.GeoBlazor.Pro;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace WCSO.GeoBlazor.Test
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
                });

            // Load appsettings.json
            var a = Assembly.GetExecutingAssembly();
            using var stream = a.GetManifestResourceStream("WCSO.GeoBlazor.Test.appsettings.json");

            var config = new ConfigurationBuilder()
                    .AddJsonStream(stream)
                    .Build();

            builder.Configuration.AddConfiguration(config);
            builder.Services.AddGeoBlazorPro(builder.Configuration);
            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
