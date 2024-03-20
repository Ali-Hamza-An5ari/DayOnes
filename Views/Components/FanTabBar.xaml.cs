namespace DayOnes.Views.Components;

public partial class FanTabBar : ContentView
{
	public FanTabBar()
	{
		InitializeComponent();
	}

    private void lblHome_Tapped(object sender, TappedEventArgs e)
    {

        Shell.Current.GoToAsync(nameof(FHomePage));
        lblHome.TextColor = Color.FromHex("#E70971");
    }

    private void lblMsgs_Tapped(object sender, TappedEventArgs e)
    {

        Shell.Current.GoToAsync(nameof(FD1MsgsPage));
        lblMsgs.TextColor = Color.FromHex("#E70971");
    }

    private void lblDM_Tapped(object sender, TappedEventArgs e)
    {

        lblDM.TextColor = Color.FromHex("#E70971");
    }

    private void lblMyStuff_Tapped(object sender, TappedEventArgs e)
    {

        lblMyStuff.TextColor = Color.FromHex("#E70971");
        Shell.Current.GoToAsync(nameof(FMyCollocationPage));
    }

    private void lblNotification_Tapped(object sender, TappedEventArgs e)
    {
        lblNotification.TextColor = Color.FromHex("#E70971");
        Shell.Current.GoToAsync(nameof(FNotificationsPage));
    }
}