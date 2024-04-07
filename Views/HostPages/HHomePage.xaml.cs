namespace DayOnes.Views.HostPages;

public partial class HHomePage : ContentPage
{
    private double distance = 0;
    private string option = "";
	public HHomePage()
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

    private void layoutCamera_Tapped(object sender, TappedEventArgs e)
    {
        //Invoke the Device Camera to take a selfie
        Shell.Current.GoToAsync(nameof(HSeeSelfiePage));
    }

    private void layoutPics_Tapped(object sender, TappedEventArgs e)
    {
        //This opens the device Photo libraries where the user picks a photo
        Shell.Current.GoToAsync(nameof(HReviewPhotoPage));
    }

    private void drpAction_Change(object sender, EventArgs e)
    {
        this.option = drpAction.SelectedItem as string;
    }
}