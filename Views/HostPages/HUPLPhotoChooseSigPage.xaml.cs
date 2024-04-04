namespace DayOnes.Views;

public partial class HUPLPhotoChooseSigPage : ContentPage
{
	public HUPLPhotoChooseSigPage()
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