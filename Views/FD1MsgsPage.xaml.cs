namespace DayOnes.Views;

public partial class FD1MsgsPage : ContentPage
{
	public FD1MsgsPage()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(FD1MsgsBubblesPage));
    }
}