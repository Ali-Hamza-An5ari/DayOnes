namespace DayOnes.Views;

public partial class FDirectMsgsBubblesPage : ContentPage
{
	public FDirectMsgsBubblesPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(FDirectMsgsPage));
    }

    private void sendButton_Tapped(object sender, TappedEventArgs e)
    {

    }
}