namespace DayOnes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            // Set up the main page within a navigation page
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
