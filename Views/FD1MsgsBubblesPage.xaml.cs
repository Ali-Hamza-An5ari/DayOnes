namespace DayOnes.Views;

public partial class FD1MsgsBubblesPage : ContentPage
{
	public FD1MsgsBubblesPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }

    private void btnBack_Click(object sender, EventArgs e)
    {

    }

    private void sendButton_Tapped(object sender, TappedEventArgs e)
    {

    }
}