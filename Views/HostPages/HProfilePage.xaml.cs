using DayOnes.Views.HostPages;

namespace DayOnes.Views;

public partial class HProfilePage : ContentPage
{
	public HProfilePage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }

    private void btnAddChange_Click(object sender, EventArgs e)
    {

    }

    private void btnCancel_Click(object sender, EventArgs e)
    {

    }

    private void btnSig_Click(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HAssetsNManagementPage));
    }
}