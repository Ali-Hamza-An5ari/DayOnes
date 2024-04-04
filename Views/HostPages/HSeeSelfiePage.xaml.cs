namespace DayOnes.Views;

public partial class HSeeSelfiePage : ContentPage
{
	public HSeeSelfiePage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }
}