namespace DayOnes.Views;

public partial class FQuickStartPage : ContentPage
{
	public FQuickStartPage()
	{
		InitializeComponent();
	}

    private void btnBack_Click(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(FSettingsPage));
    }
}