using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;
using Microsoft.Maui.Platform;

namespace Garage1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .ConfigureSyncfusionCore()
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });


#if ANDROID
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
            {
                // Чтобы убрать нижнее подчеркивание в поиске
                handler.PlatformView.BackgroundTintList =
                    Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
            });
#endif

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();




        }
    }
}
