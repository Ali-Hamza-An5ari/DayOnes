namespace DayOnes.Views;

public partial class HUPLPhotoChooseSigPage : ContentPage
{
	public HUPLPhotoChooseSigPage()
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

    private void btnCancel_Click(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HReviewPhotoPage));
    }

    private void layoutImage_Tap(object sender, TappedEventArgs e)
    {

        Shell.Current.GoToAsync(nameof(HUPLSeePhotoPage));
    }
}