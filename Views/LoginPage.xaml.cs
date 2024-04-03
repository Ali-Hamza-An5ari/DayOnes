using DayOnes.Views.HostPages;

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
        var email = this.txtEmail.Text;
        var password = this.txtPassword.Text;

        /*
         Execute AWS API:L1 passing the email & password
to AWS, and receiving data as to whether the user is a
Client or Host. Client or Host status should be store in
SQLite

        Collect Geolocation data from the iPhone, store it in
SQLite, and ID the variable containing the data. Will need the email as part
of the data set.
         */

        Shell.Current.GoToAsync(nameof(HPostDetailsPage));
    }

    private void btnSignup_Click(object sender, EventArgs e)
    {

        Shell.Current.GoToAsync(nameof(RegFanPage));
    }
}