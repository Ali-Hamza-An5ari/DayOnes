namespace DayOnes.Views;

public partial class HReviewPhotoPage : ContentPage
{
	public HReviewPhotoPage()
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