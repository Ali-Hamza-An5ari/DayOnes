namespace DayOnes.Views;

public partial class HNotificationsPage : ContentPage
{
	public HNotificationsPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }
}