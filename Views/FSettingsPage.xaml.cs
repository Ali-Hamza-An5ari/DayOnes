using Microsoft.Maui;
using System.Runtime.InteropServices;

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

    private void btnLogout_Click(object sender, EventArgs e)
    {
        /* a.Launch a iOS Alert pop-up asking of the user really wants to quit the app
i.Yes – exit the app
ii.No - close the Alert Box *
         
         */
    }
}