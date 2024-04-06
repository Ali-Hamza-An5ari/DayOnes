namespace DayOnes.Views;

public partial class HFinalSeeSelfiePage : ContentPage
{
	public HFinalSeeSelfiePage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }

    private void imgCancel_Tap(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HSelfieChooseSigPage));
    }

    private void imgUpload_Tap(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HHomeUploadedPage));

    }
}