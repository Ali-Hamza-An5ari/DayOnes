using System.Collections.ObjectModel;

namespace DayOnes.Views.Components;

public partial class PostCartAction : ContentView
{
    public static readonly BindableProperty ImageSourceProperty =
        BindableProperty.Create(nameof(ImageSource), typeof(string), typeof(PostCartAction), default(string));

    public static readonly BindableProperty ArtistNameProperty =
        BindableProperty.Create(nameof(ArtistName), typeof(string), typeof(PostCartAction), default(string));

    public static readonly BindableProperty IsLikedProperty =
        BindableProperty.Create(nameof(IsLiked), typeof(bool), typeof(PostCartAction), false);

    public static readonly BindableProperty PostContentProperty =
        BindableProperty.Create(nameof(PostContent), typeof(string), typeof(PostCartAction), default(string));

    public string ImageSource
    {
        get => (string)GetValue(ImageSourceProperty);
        set => SetValue(ImageSourceProperty, value);
    }

    public string ArtistName
    {
        get => (string)GetValue(ArtistNameProperty);
        set => SetValue(ArtistNameProperty, value);
    }

    public string PostContent
    {
        get => (string)GetValue(PostContentProperty);
        set => SetValue(PostContentProperty, value);
    }
    public bool IsLiked
    {
        get => (bool)GetValue(IsLikedProperty);
        set => SetValue(IsLikedProperty, value);
    }

    public PostCartAction()
	{
		InitializeComponent();
        this.lblArtistName.Text = ArtistName;
	}
}