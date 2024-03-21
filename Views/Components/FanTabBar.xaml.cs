namespace DayOnes.Views.Components;

public partial class FanTabBar : ContentView
{
    public static readonly BindableProperty CurrentPageProperty = BindableProperty.Create(
        nameof(CurrentPage), typeof(int), typeof(FanTitleBar), 0);

    public string CurrentPage
    {
        get => (string)GetValue(CurrentPageProperty);
        set
        {
            SetValue(CurrentPageProperty, value);
            switch (Convert.ToInt32(value))
            {
                case 1:
                    //lblHome.TextColor = Color.FromHex("#E70971");
                    lblHomeTitle.TextColor = Color.FromHex("#E70971");
                    break;
                case 2:
                    lblMsgs.TextColor = Color.FromHex("#E70971");
                    lblMsgsTitle.TextColor = Color.FromHex("#E70971");
                    break;
                case 3:
                    lblDM.TextColor = Color.FromHex("#E70971");
                    lblDMTitle.TextColor = Color.FromHex("#E70971");
                    break;
                case 4:
                    lblMyStuff.TextColor = Color.FromHex("#E70971");
                    lblMyStuffTitle.TextColor = Color.FromHex("#E70971");
                    break;
                case 5:
                    lblNotification.TextColor = Color.FromHex("#E70971");
                    lblNotificationTitle.TextColor = Color.FromHex("#E70971");
                    break;
                default:
                    break;
            }
        }
        }

    public FanTabBar()
	{
		InitializeComponent();
        
    }

    private void lblHome_Tapped(object sender, TappedEventArgs e)
    {

        Shell.Current.GoToAsync(nameof(FHomePage));
        //lblHome.TextColor = Color.FromHex("#E70971");
        this.CurrentPage = "1";
    }

    private void lblMsgs_Tapped(object sender, TappedEventArgs e)
    {

        Shell.Current.GoToAsync(nameof(FD1MsgsPage));
        lblMsgs.TextColor = Color.FromHex("#E70971");
        this.CurrentPage = "2";
    }

    private void lblDM_Tapped(object sender, TappedEventArgs e)
    {

        lblDM.TextColor = Color.FromHex("#E70971");
        this.CurrentPage = "3";
    }

    private void lblMyStuff_Tapped(object sender, TappedEventArgs e)
    {

        lblMyStuff.TextColor = Color.FromHex("#E70971");
        Shell.Current.GoToAsync(nameof(FMyCollocationPage));
        this.CurrentPage = "4";
    }

    private void lblNotification_Tapped(object sender, TappedEventArgs e)
    {
        lblNotification.TextColor = Color.FromHex("#E70971");
        Shell.Current.GoToAsync(nameof(FNotificationsPage));
        this.CurrentPage = "5";
    }
}