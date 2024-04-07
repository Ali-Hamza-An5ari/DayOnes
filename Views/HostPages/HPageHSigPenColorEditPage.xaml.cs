namespace DayOnes.Views;

public partial class HPageHSigPenColorEditPage : ContentPage
{
	public HPageHSigPenColorEditPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }

    private void btnSig_Click(object sender, EventArgs e)
    {

    }
}