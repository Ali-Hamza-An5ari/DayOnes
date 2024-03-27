namespace DayOnes.Views.Components;

public partial class FanTabBar : ContentView
{
    public static int CurrentPage1 = 1;
    public static readonly BindableProperty CurrentPageProperty = BindableProperty.Create(
        nameof(CurrentPage), typeof(int), typeof(FanTitleBar), 0);

    public string CurrentPage
    {
        get => (string)GetValue(CurrentPageProperty);
        set
        {
            SetValue(CurrentPageProperty, value);
            //OnTapped(int.Parse(CurrentPage));
        }
    }

    public FanTabBar()
    {
        InitializeComponent();
        //Console.WriteLine(CurrentPage1);
        OnTapped(Temp.currenttabbarpage);
        //  OnTapped(int.Parse(CurrentPage));
        //switch (Convert.ToInt32(CurrentPage))
        //{
        //    case 1:
        //        lblHome.TextColor = Color.FromHex("#E70971");
        //        lblHomeTitle.TextColor = Color.FromHex("#E70971");
        //        break;
        //    case 2:
        //        lblMsgs.TextColor = Color.FromHex("#E70971");
        //        lblMsgsTitle.TextColor = Color.FromHex("#E70971");
        //        break;
        //    case 3:
        //        lblDM.TextColor = Color.FromHex("#E70971");
        //        lblDMTitle.TextColor = Color.FromHex("#E70971");
        //        break;
        //    case 4:
        //        lblMyStuff.TextColor = Color.FromHex("#E70971");
        //        lblMyStuffTitle.TextColor = Color.FromHex("#E70971");
        //        break;
        //    case 5:
        //        lblNotification.TextColor = Color.FromHex("#E70971");
        //        lblNotificationTitle.TextColor = Color.FromHex("#E70971");
        //        break;
        //    default:
        //        break;
        //}
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

            //lblHome.TextColor = Color.FromHex("#FFFFFF");
            //lblHomeTitle.TextColor = Color.FromHex("#FFFFFF");
        }

        if (tempCurrentPage == 2)
        {
            lblMsgs.Source = "smsgsic";
            //lblMsgsTitle.TextColor = Color.FromHex("#E70971");
        }
        else
        {
            lblMsgs.Source = "msgsic";

            //lblMsgs.TextColor = Color.FromHex("#FFFFFF");
            //lblMsgsTitle.TextColor = Color.FromHex("#FFFFFF");
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
            lblMyStuff.Source = "smystuffic";
            //lblMyStuffTitle.TextColor = Color.FromHex("#E70971");
        }
        else
        {
            lblMyStuff.Source = "mystuffic";

        }

        if (tempCurrentPage == 5)
        {
            lblNotification.Source = "snotificationic";
        }
        else
        {
            lblNotification.Source = "notificationic";

        }

    }
}