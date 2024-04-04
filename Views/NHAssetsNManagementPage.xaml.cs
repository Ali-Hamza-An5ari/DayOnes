namespace DayOnes.Views;

public partial class NHAssetsNManagementPage : ContentPage
{
	public NHAssetsNManagementPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }
}