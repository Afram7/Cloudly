using Microsoft.Extensions.Logging;

namespace Cloudly;

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

				// Roboto font
				fonts.AddFont("Roboto-Black.ttf", "RobotoBlack");
				fonts.AddFont("Roboto-BlackItalic.ttf", "RobotoBlackItalic");
				fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
				fonts.AddFont("Roboto-BoldItalic.ttf", "RobotoBoldItalic");
				fonts.AddFont("Roboto-Italic.ttf", "RobotoItalic");
				fonts.AddFont("Roboto-Light.ttf", "RobotoLight");
				fonts.AddFont("Roboto-LightItalic.ttf", "RobotoLightItalic");
				fonts.AddFont("Roboto-Medium.ttf", "RobotoMedium");
				fonts.AddFont("Roboto-MediumItalic.ttf", "RobotoMediumItalic");
				fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
				fonts.AddFont("Roboto-Thin.ttf", "RobotoThin");
				fonts.AddFont("Roboto-ThinItalic.ttf", "RobotoThinItalic");
				fonts.AddFont("RobotoCondensed-Bold.ttf", "RobotoCondensedBold");
				fonts.AddFont("RobotoCondensed-BoldItalic.ttf", "RobotoCondensedBoldItalic");
				fonts.AddFont("RobotoCondensed-Italic.ttf", "RobotoCondensedItalic");
				fonts.AddFont("RobotoCondensed-Light.ttf", "RobotoCondensedLight");
				fonts.AddFont("RobotoCondensedLightItalic.ttf", "RobotoCondensedLightItalic");
				fonts.AddFont("RobotoCondensed-Regular.ttf", "RobotoCondensedRegular");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
