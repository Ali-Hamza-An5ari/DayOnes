namespace DayOnes.Views;

public partial class FMyCollocationPage : ContentPage
{
	public FMyCollocationPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
        var images = new List<Im>();
        images.Add(new Im() { Source = "im2.png" });
        images.Add(new Im() { Source = "im1.PNG" });
        images.Add(new Im() { Source = "im3.png" });
        images.Add(new Im() { Source = "d1logo3.png" });
        images.Add(new Im() { Source = "im2.png" });
        images.Add(new Im() { Source = "im1.PNG" });
        images.Add(new Im() { Source = "im2.png" });
        images.Add(new Im() { Source = "im1.PNG" });
        images.Add(new Im() { Source = "im3.png" });
        images.Add(new Im() { Source = "d1logo3.png" });
        images.Add(new Im() { Source = "im3.png" });
        images.Add(new Im() { Source = "d1logo3.png" });
        imageViewer.ItemsSource = images;
	}

    private void OnImageTapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(FMyPicsLrgPage));
    }
}
public class Im
{
	public string Source { get; set; }
}