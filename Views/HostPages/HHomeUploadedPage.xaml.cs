namespace DayOnes.Views;

public partial class HHomeUploadedPage : ContentPage
{
	public HHomeUploadedPage()
	{
		InitializeComponent();
	}

    private void sliderDistance_ValueChanged(object sender, ValueChangedEventArgs e)
    {

    }

    private void btnSend_Click(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HHomeSentCountdownPage));
    }
}