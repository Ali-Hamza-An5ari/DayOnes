using DayOnes.Views;

namespace DayOnes
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(RegFanPage), typeof(RegFanPage));
            Routing.RegisterRoute(nameof(FHomePage), typeof(FHomePage));
            Routing.RegisterRoute(nameof(FHomeCountdownPage), typeof(FHomeCountdownPage));
            Routing.RegisterRoute(nameof(FMessageReceivedPage), typeof(FMessageReceivedPage));
            Routing.RegisterRoute(nameof(FD1MsgsBubblesPage), typeof(FD1MsgsBubblesPage));
            Routing.RegisterRoute(nameof(FD1MsgsPage), typeof(FD1MsgsPage));
            Routing.RegisterRoute(nameof(FDirectMsgsBubblesPage), typeof(FDirectMsgsBubblesPage));
            Routing.RegisterRoute(nameof(FDirectMsgsPage), typeof(FDirectMsgsPage));
            Routing.RegisterRoute(nameof(FMyCollocationPage), typeof(FMyCollocationPage));
            Routing.RegisterRoute(nameof(FMyPicsLrgPage), typeof(FMyPicsLrgPage));
            Routing.RegisterRoute(nameof(FNotificationsPage), typeof(FNotificationsPage));
            Routing.RegisterRoute(nameof(FProfilePage), typeof(FProfilePage));
            Routing.RegisterRoute(nameof(FQuickStartPage), typeof(FQuickStartPage));
            Routing.RegisterRoute(nameof(FSettingsPage), typeof(FSettingsPage));
        }
    }
}
