namespace DayOnes.Views;

public partial class HHomeSentCountdownPage : ContentPage
{
	public HHomeSentCountdownPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }
}