namespace DayOnes.Views;

public partial class HPOSTURSentMsgsPage : ContentPage
{
	public HPOSTURSentMsgsPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }
}