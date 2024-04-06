using DayOnes.Views.HostPages;

namespace DayOnes.Views;

public partial class HHomeUploadedPage : ContentPage
{
	public HHomeUploadedPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }

    private void sliderDistance_ValueChanged(object sender, ValueChangedEventArgs e)
    {

    }

    private void btnSend_Click(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HHomeSentCountdownPage));
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HHomePage));
    }
}