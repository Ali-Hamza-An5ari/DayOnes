namespace DayOnes.Views;

public partial class FSettingsPage : ContentPage
{
	public FSettingsPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }

    private void OnToggled(object sender, ToggledEventArgs e)
    {

    }

    private void toggleSoundSwitch_Toggle(object sender, ToggledEventArgs e)
    {

    }

    private void togglePushSwitch_Toggle(object sender, ToggledEventArgs e)
    {

    }

    private void lblQuickStart_Tapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(FQuickStartPage));
    }
}