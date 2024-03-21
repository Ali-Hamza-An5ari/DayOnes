
namespace DayOnes.Views;

public partial class RegFanPage : ContentPage
{
	public RegFanPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }

    private void btnRegister_ClickAsync(object sender, EventArgs e)
    {
		 Shell.Current.GoToAsync(nameof(FHomePage));
        //Shell.Current.GoToAsync(nameof(LoginPage));

    }

    private void OnToggled(object sender, ToggledEventArgs e)
    {

    }

    private async void btnLogin_Click(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"///{nameof(LoginPage)}");
    }
}