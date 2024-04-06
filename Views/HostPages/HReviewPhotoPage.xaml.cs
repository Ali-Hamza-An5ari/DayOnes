using DayOnes.Views.HostPages;

namespace DayOnes.Views;

public partial class HReviewPhotoPage : ContentPage
{
	public HReviewPhotoPage()
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

    private void imgCancel_Tap(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HHomePage));
    }

    private void imgSig_Tap(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HUPLPhotoChooseSigPage));

    }

    private void imgUpload_Tap(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HHomeUploadedPage));

    }
}