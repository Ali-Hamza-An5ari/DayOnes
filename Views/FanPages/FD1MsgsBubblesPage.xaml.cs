namespace DayOnes.Views;

public partial class FD1MsgsBubblesPage : ContentPage
{
	public FD1MsgsBubblesPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });

        /* Invoke AWS API: GetHostPost
a. Pass the ChatPostID. The API will return a lot
of data
*/
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(FD1MsgsPage));
    }

    private void sendButton_Tapped(object sender, TappedEventArgs e)
    {
        var message = this.txtMessage.Text;
        /*
         collect the message passing it and the
ChatPostID and timestamp to API: SendD1Msg

With success, display the message in a purple
message bubble.
         */
    }

    private void imgMicrophone_Tapped(object sender, TappedEventArgs e)
    {
        //this should all use the iOS voice-to-text
        //feature to fill the message area with text the that user is
        //saying
    }
}