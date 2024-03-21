namespace DayOnes.Views;

public partial class FHomePage : ContentPage
{
	public FHomePage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }

    private void btnInvites_Click(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(FHomeCountdownPage));
    }

    private void lblHome_Tapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("H", "Hi", "Ok");
    }
}