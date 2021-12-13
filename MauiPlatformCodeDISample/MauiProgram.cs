using MauiPlatformCodeDISample.Platforms;

namespace MauiPlatformCodeDISample;

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

		builder.Services.AddTransient<IDeviceOrientationService, DeviceOrientationService>();
		builder.Services.AddTransient<MainPage>();

		return builder.Build();
	}
}
