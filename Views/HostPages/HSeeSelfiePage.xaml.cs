using DayOnes.Views.HostPages;

namespace DayOnes.Views;

public partial class HSeeSelfiePage : ContentPage
{
	public HSeeSelfiePage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }

    private void imgCancel_Tap(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HHomePage));
    }

    private void imgSig_Tap(object sender, TappedEventArgs e)
    {

        Shell.Current.GoToAsync(nameof(HSelfieChooseSigPage));
    }

    private void imgUpload_Tap(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HHomeUploadedPage));

    }
}