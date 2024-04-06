namespace DayOnes.Views.HostPages;

public partial class HAssetsNManagementPage : ContentPage
{
	public HAssetsNManagementPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HProfilePage));
    }

    private void btnSigColor_Click(object sender, EventArgs e)
    {

        Shell.Current.GoToAsync(nameof(HPageHSigPenColorEditPage));
    }
}