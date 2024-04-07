using DayOnes.Views.HostPages;

namespace DayOnes.Views;

public partial class HHomeUploadedPage : ContentPage
{
    private double distance = 0;
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
        distance = e.NewValue;
    }

    private void btnSend_Click(object sender, EventArgs e)
    {
        /*a. The app sends the device’ GPS coordinates to AWS
        with API: SetMyGPS.
        i.Pass
        1.Username
        2.Lon.Lat
        3.Timestamp
        4.City

        b. Start Send Process AWS API: StartSendProc
        i. For this deliverable, comment the code with the
        location & where the data is to execute the API.
        */
        Shell.Current.GoToAsync(nameof(HHomeSentCountdownPage));
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HHomePage));
    }
}