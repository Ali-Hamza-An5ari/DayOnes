namespace DayOnes.Views;

public partial class HNewGrpPostPage : ContentPage
{
	public HNewGrpPostPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HPOSTURSentMsgsPage));
    }

    private void sendButton_Tapped(object sender, TappedEventArgs e)
    {

    }
}