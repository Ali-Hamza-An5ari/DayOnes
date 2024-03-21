namespace DayOnes.Views;

public partial class FProfilePage : ContentPage
{
	public FProfilePage()
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
        Shell.Current.GoToAsync(nameof(FHomePage));
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(FHomePage));

    }
}