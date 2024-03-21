namespace DayOnes.Views;

public partial class FDirectMsgsPage : ContentPage
{
	public FDirectMsgsPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }

    private void FrameTapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(FDirectMsgsBubblesPage));
    }
}