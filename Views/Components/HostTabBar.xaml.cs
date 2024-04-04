namespace DayOnes.Views.Components;

public partial class HostTabBar : ContentView
{
    public static int CurrentPage1 = 1;
    public static readonly BindableProperty CurrentPageProperty = BindableProperty.Create(
        nameof(CurrentPage), typeof(int), typeof(HostTabBar), 0);

    public string CurrentPage
    {
        get => (string)GetValue(CurrentPageProperty);
        set
        {
            SetValue(CurrentPageProperty, value);
            //OnTapped(int.Parse(CurrentPage));
        }
    }

    public HostTabBar()
    {
        InitializeComponent();
        OnTapped(Temp.currenttabbarpage);
    }
    private void lblHome_Tapped(object sender, TappedEventArgs e)
    {
        Temp.currenttabbarpage = 1;

        Shell.Current.GoToAsync(nameof(FHomePage));
        //lblHome.TextColor = Color.FromHex("#E70971");
        //   OnTapped(CurrentPage1);

    }

    private void lblMsgs_Tapped(object sender, TappedEventArgs e)
    {
        Temp.currenttabbarpage = 2;

        Shell.Current.GoToAsync(nameof(FD1MsgsPage));
        //lblMsgs.TextColor = Color.FromHex("#E70971");
        //   OnTapped(CurrentPage1);

    }

    private void lblDM_Tapped(object sender, TappedEventArgs e)
    {

        //lblDM.TextColor = Color.FromHex("#E70971");
        Temp.currenttabbarpage = 3;
        Shell.Current.GoToAsync(nameof(FDirectMsgsPage));

        //   OnTapped(CurrentPage1);

    }

    private void lblMyStuff_Tapped(object sender, TappedEventArgs e)
    {
        Temp.currenttabbarpage = 4;

        //lblMyStuff.TextColor = Color.FromHex("#E70971");
        Shell.Current.GoToAsync(nameof(FMyCollocationPage));
        // OnTapped(CurrentPage1);

    }

    private void lblNotification_Tapped(object sender, TappedEventArgs e)
    {
        Temp.currenttabbarpage = 5;

        //lblNotification.TextColor = Color.FromHex("#E70971");
        Shell.Current.GoToAsync(nameof(FNotificationsPage));
        //  OnTapped(CurrentPage1);
    }

    public void OnTapped(int tempCurrentPage)
    {

        if (tempCurrentPage == 1)
        {
            lblHome.Source = "shomeic";
            //lblHomeTitle.TextColor = Color.FromHex("#E70971");
        }
        else
        {
            lblHome.Source = "homeic";

            //lblHome.TextColor = Color.FromHex("{StaticResource DefaultWhite}");
            //lblHomeTitle.TextColor = Color.FromHex("{StaticResource DefaultWhite}");
        }

        if (tempCurrentPage == 2)
        {
            lblMsgs.Source = "smsgsic";
            //lblMsgsTitle.TextColor = Color.FromHex("#E70971");
        }
        else
        {
            lblMsgs.Source = "msgsic";

            //lblMsgs.TextColor = Color.FromHex("{StaticResource DefaultWhite}");
            //lblMsgsTitle.TextColor = Color.FromHex("{StaticResource DefaultWhite}");
        }

        if (tempCurrentPage == 3)
        {
            lblDM.Source = "sdmic";
            //lblDMTitle.TextColor = Color.FromHex("#E70971");
        }
        else
        {
            lblDM.Source = "dmic";

        }

        if (tempCurrentPage == 4)
        {
            lblNotification.Source = "snotificationic";
            //lblMyStuffTitle.TextColor = Color.FromHex("#E70971");
        }
        else
        {
            lblNotification.Source = "notificationic";

        }

        if (tempCurrentPage == 5)
        {
            lblSetting.Source = "ssetting";
        }
        else
        {
            lblSetting.Source = "settings";

        }

    }
}