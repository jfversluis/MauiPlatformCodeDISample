namespace MauiPlatformCodeDISample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(IDeviceOrientationService service)
	{
		InitializeComponent();

		orientationLabel.Text = service.GetOrientation().ToString();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		CounterLabel.Text = $"Current count: {count}";

		SemanticScreenReader.Announce(CounterLabel.Text);
	}
}

