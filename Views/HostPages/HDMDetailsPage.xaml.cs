using DayOnes.Views.HostPages;

namespace DayOnes.Views;

public partial class HDMDetailsPage : ContentPage
{
    public static string GroupName = "";
    public static string ClientID = "";
	public HDMDetailsPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });

        ClientID = HDMDetailsList.ClientID;
        GroupName = HDMDetailsList.GroupName;
       /* Execute API: GetHOSTDMChat passing the
        Groupname & CliendchatID# from pervious pages*/
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HDMDetailsList));
    }

    private void sendButton_Tapped(object sender, TappedEventArgs e)
    {

    }
}