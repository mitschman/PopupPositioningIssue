using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using Microsoft.Extensions.Logging;

namespace PopupPositioningIssue
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.UseMauiCommunityToolkitCore()
				.UseMauiCommunityToolkit(static options =>
				{
					options.SetPopupDefaults(new DefaultPopupSettings()
					{
						Margin = 0,
						Padding = 0,
					});
					options.SetPopupOptionsDefaults(new DefaultPopupOptionsSettings()
					{
						Shape = null,
					});
					options.SetShouldUseStatusBarBehaviorOnAndroidModalPage(true);
				})
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				});

#if DEBUG
			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}
