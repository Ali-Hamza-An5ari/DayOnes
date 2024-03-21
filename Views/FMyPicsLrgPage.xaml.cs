namespace DayOnes.Views;

public partial class FMyPicsLrgPage : ContentPage
{
	public FMyPicsLrgPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }
}