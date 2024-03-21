namespace DayOnes.Views;

public partial class FNotificationsPage : ContentPage
{
	public FNotificationsPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }
}