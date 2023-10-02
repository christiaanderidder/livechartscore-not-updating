using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using MyMauiApp.ViewModels;
using MyMauiApp.Views;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace MyMauiApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseSkiaSharp(true)
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		
		builder.Services.AddTransient<OtherPage>();
		builder.Services.AddTransient<OtherPageViewModel>();

		builder.Services.AddTransient<ChartPage>();
		builder.Services.AddTransient<ChartPageViewModel>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
