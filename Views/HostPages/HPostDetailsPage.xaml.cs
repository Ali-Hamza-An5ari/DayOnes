using DayOnes.Models;
using DayOnes.Views.HostPages;

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

        posts.Add(new Post() { ArtistName = "Julie", ArtistImage = "singer.png", PostContent = "You have Received a gift!", IsLiked= true });
        posts.Add(new Post() { ArtistName = "Steve", ArtistImage = "singer.png", PostContent = "You have Received a gift!", IsLiked = false });
        posts.Add(new Post() { ArtistName = "Tom", ArtistImage = "singer.png", PostContent = "You have Received a gift!", IsLiked = false });
        posts.Add(new Post() { ArtistName = "Martyn", ArtistImage = "singer.png", PostContent = "You have Received a gift!", IsLiked = true });
        listPosts.ItemsSource = posts;
    }

    private void btnBack_Click(object Artist, EventArgs e)
    {

        Shell.Current.GoToAsync(nameof(HPOSTURSentMsgsPage));
    }

    private void btnDM_Click(object Artist, EventArgs e)
    {

        Shell.Current.GoToAsync(nameof(HDMDetailsList));
    }

    private void btnDM_Click(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HDMDetailsList));
    }
}
/*
class Post
{
    public string ArtistName { get; set; }
    public string ArtistImage { get; set; }
    public string PostContent { get; set; }
    public bool IsLiked { get; set; }

}*/