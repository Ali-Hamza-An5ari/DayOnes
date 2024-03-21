namespace DayOnes.Views;

public partial class FQuickStartPage : ContentPage
{
	public FQuickStartPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(FSettingsPage));
    }
}