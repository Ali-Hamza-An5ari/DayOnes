namespace DayOnes.Views;

public partial class HFinalSeeSelfiePage : ContentPage
{
	public HFinalSeeSelfiePage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }
}