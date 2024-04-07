using DayOnes.Models;

namespace DayOnes.Views.HostPages;

public partial class HAssetsNManagementPage : ContentPage
{
    public static SigImage SelectedSig = new SigImage();
    public static string SelectedImg = "";

    private List<SigImage> sigs;
    public HAssetsNManagementPage()
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

    private void btnBack_Click(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HProfilePage));
    }

    private void btnSigColor_Click(object sender, EventArgs e)
    {

        Shell.Current.GoToAsync(nameof(HPageHSigPenColorEditPage));
    }

    private void imgSig_Click(object sender, TappedEventArgs e)
    {
        SigImage tappedImage = (SigImage)sender;
        SelectedSig = tappedImage;


    }
}