namespace DayOnes.Views.HostPages;

public partial class HHomePage : ContentPage
{
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

    }
}