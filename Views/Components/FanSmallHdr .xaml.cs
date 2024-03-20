namespace DayOnes.Views.Components;

public partial class FanSmallHdr : ContentView
{
	public FanSmallHdr()
	{
		InitializeComponent();
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(FProfilePage));
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(FSettingsPage));
    }
}