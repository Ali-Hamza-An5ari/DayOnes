namespace DayOnes.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }
    private bool IsLoginOrRegisterPage()
    {
        // Add your logic here
        // For example, check the NavigationStack or other conditions
        return false;
    }
    private void btnLog_Click(object sender, EventArgs e)
    {
		//DisplayAlert("Title","Clicked","Yes");
		Shell.Current.GoToAsync(nameof(FHomePage));
    }

    private void btnSignup_Click(object sender, EventArgs e)
    {

        Shell.Current.GoToAsync(nameof(RegFanPage));
    }
}