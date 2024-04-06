using DayOnes.Models;

namespace DayOnes.Views.HostPages;

public partial class HDMDetailsList : ContentPage
{
    private List<Post> posts = new List<Post>(); //This is just a testing data

    public HDMDetailsList()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });

        posts.Add(new Post() { ArtistName = "Julie", ArtistImage = "singer.png", PostContent = "You have Received a gift!", IsPinned = true });
        posts.Add(new Post() { ArtistName = "Steve", ArtistImage = "singer.png", PostContent = "You have Received a gift!", IsPinned = false });
        posts.Add(new Post() { ArtistName = "Tom", ArtistImage = "singer.png", PostContent = "You have Received a gift!", IsPinned = false });
        posts.Add(new Post() { ArtistName = "Martyn", ArtistImage = "singer.png", PostContent = "You have Received a gift!", IsPinned = true });
        listPosts.ItemsSource = posts;
    }

    private void btnBack_Click(object sender, EventArgs e)
    {

    }
}