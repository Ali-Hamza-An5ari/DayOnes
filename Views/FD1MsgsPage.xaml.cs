namespace DayOnes.Views;

public partial class FD1MsgsPage : ContentPage
{
	public FD1MsgsPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(FD1MsgsBubblesPage));
    }

    private void FrameTapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(FD1MsgsBubblesPage));
    }
}