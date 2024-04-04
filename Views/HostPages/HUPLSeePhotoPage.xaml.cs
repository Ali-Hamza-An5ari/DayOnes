namespace DayOnes.Views;

public partial class HUPLSeePhotoPage : ContentPage
{
	public HUPLSeePhotoPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }

    private void btnBack_Click(object sender, EventArgs e)
    {

    }
}