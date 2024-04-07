using DayOnes.Models;

namespace DayOnes.Views;

public partial class HPageHSigPenColorEditPage : ContentPage
{
    private List<SigImage> sigs;
    public static SigImage SelectedSigID = new SigImage();
    public HPageHSigPenColorEditPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });

        sigs = new List<SigImage>();
        sigs.Add(new() { ID = "1", ImageSource = "sig2.png", Name = "Sig1" });
        sigs.Add(new() { ID = "2", ImageSource = "sig3.png", Name = "Sig2" });
        sigs.Add(new() { ID = "3", ImageSource = "sig2.png", Name = "Sig3" });
        sigs.Add(new() { ID = "4", ImageSource = "sig3.png", Name = "Sig4" });

        this.listSigs.ItemsSource = sigs;
    }

    private void btnSig_Click(object sender, EventArgs e)
    {

    }

    private void imgSig_Click(object sender, TappedEventArgs e)
    {

        // Cast the sender object to an Image to access its properties
        Image tappedImage = (Image)sender;

        // Access the BindingContext of the tapped Image to get the selected item
        SigImage selectedItem = (SigImage)tappedImage.BindingContext;

        // Now you can access the ID field of the selected item and store it in SelectedSigID
        //Passing whole image with has its ID as well.
        SelectedSigID = selectedItem;
    }
}