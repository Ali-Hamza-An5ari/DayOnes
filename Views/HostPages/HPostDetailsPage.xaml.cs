namespace DayOnes.Views;

public partial class HPostDetailsPage : ContentPage
{
    private List<Post> posts = new List<Post>(); //This is just a testing data
		
	public HPostDetailsPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });

        posts.Add(new Post() { SenderName = "Julie", SenderImage="singer.png", Content = "You have Received a gift!",  });
        posts.Add(new Post() { SenderName = "Steve", SenderImage="singer.png", Content = "You have Received a gift!",  });
        posts.Add(new Post() { SenderName = "Tom", SenderImage="singer.png", Content = "You have Received a gift!",  });
        posts.Add(new Post() { SenderName = "Martyn", SenderImage="singer.png", Content = "You have Received a gift!",  });
        listPosts.ItemsSource = posts;
    }

    private void btnBack_Click(object sender, EventArgs e)
    {

    }

    private void btnDM_Click(object sender, EventArgs e)
    {

    }
}
class Post
{
    public string SenderName { get; set; }
    public string SenderImage { get; set; }
    public string Content { get; set; }
    public bool IsLiked { get; set; }

}