namespace DayOnes.Views;

public partial class HPOSTURSentMsgsPage : ContentPage
{
	public HPOSTURSentMsgsPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }

    private void lblPost_Tap(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HPostDetailsPage));
    }

    private void btnGrp_Click(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HNewGrpPostPage));
    }

    private void btnFans_Click(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HNewALLPostPage));
    }
}