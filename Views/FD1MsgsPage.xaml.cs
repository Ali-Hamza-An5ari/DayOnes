namespace DayOnes.Views;

public partial class FD1MsgsPage : ContentPage
{
	public FD1MsgsPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });

        /*
        1. Invoke API: GetD1ChatSum. The return will be a tuple
of active Host’ chats
a. The 40px profile photo of the Host
b. The Host name
c. The number of Likes the host has
i. If more than 1, then a red heart should
be displayed
d. An ChatPostID of this chat
e. The app should format this per the component
in Figma & display

        2. If more than 2 items is returned, the summaries should
appear in a vertically aligned scrollable list.

         */
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(FD1MsgsBubblesPage));
    }

    private void FrameTapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(FD1MsgsBubblesPage));
    }
}