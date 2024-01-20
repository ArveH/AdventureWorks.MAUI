using Microsoft.Extensions.Logging;

#if WINDOWS
using Microsoft.Maui.LifecycleEvents;
#endif

namespace AdventureWorks.MAUI
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

#if WINDOWS
      //SetWindowOptions(builder);
      SetWindowHandlers();
#endif

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

#if WINDOWS
        public static void SetWindowOptions(MauiAppBuilder builder)
        {
          builder.ConfigureLifecycleEvents(events =>
          {
            events.AddWindows(wndLifeCycleBuilder =>
            {
              wndLifeCycleBuilder.OnWindowCreated(window =>
              {
                IntPtr nativeWindowHandle = WinRT.Interop.WindowNative.GetWindowHandle(window);
                Microsoft.UI.WindowId win32WindowsId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(nativeWindowHandle);
                Microsoft.UI.Windowing.AppWindow winuiAppWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(win32WindowsId);
                if (winuiAppWindow.Presenter is Microsoft.UI.Windowing.OverlappedPresenter p) {
                  p.Maximize();
                  //p.IsResizable = false;
                  //p.IsMaximizable = false;
                  //p.IsMinimizable = false;
                }
              });
            });
          });
        }
#endif

#if WINDOWS
        public static void SetWindowHandlers()
        {
          Microsoft.Maui.Handlers.SwitchHandler.Mapper
            .AppendToMapping("Custom", (h, v) =>
          {
            // Get rid of On/Off label beside switch, to match other platforms
            h.PlatformView.OffContent = "No";
            h.PlatformView.OnContent = "Yes";

            h.PlatformView.MinWidth = 0;
          });
        }
#endif

    }
}
