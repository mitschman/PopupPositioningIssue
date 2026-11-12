using CommunityToolkit.Maui.Extensions;

namespace PopupPositioningIssue
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void OnClicked(object? sender, EventArgs e)
		{
			await this.ShowPopupAsync(new Label { Text = "Popup Positioning Issue With Usage Of 'options.SetShouldUseStatusBarBehaviorOnAndroidModalPage(true);'!" });
		}
	}
}
