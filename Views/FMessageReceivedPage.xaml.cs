namespace DayOnes.Views;

public partial class FMessageReceivedPage : ContentPage
{
	public FMessageReceivedPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
        var messages = new List<Message>()
		{
			new Message() {Artist="Artist", Title="You have Received a gift!"},
			new Message() {Artist="Artist", Title="You have Received a gift!"},
			new Message() {Artist="Artist", Title="You have Received a gift!"}
		};
		listMessages.ItemsSource = messages;
	}

    private void btnAccept_Click(object sender, EventArgs e)
    {

        Shell.Current.GoToAsync(nameof(FMyCollocationPage));
    }

    private void btnIgnore_Click(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(FHomePage));
    }

}

public class Message
{
	public string Artist { get; set; }
	public string Title { get; set; }
}