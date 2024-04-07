using DayOnes.Models;

namespace DayOnes.Views.HostPages;

public partial class HAssetsNManagementPage : ContentPage
{
    public static SigImage SelectedSig = new SigImage();
    public static SigImage SelectedImg = new SigImage();

    private List<SigImage> sigs;
    private List<SigImage> imgs;
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


        imgs = new List<SigImage>();
        imgs.Add(new() { ID = "1", ImageSource = "artist1.png", Name = "Sig1" });
        imgs.Add(new() { ID = "2", ImageSource = "artis2.png", Name = "Sig2" });
        imgs.Add(new() { ID = "3", ImageSource = "artist3.png", Name = "Sig3" });
        imgs.Add(new() { ID = "4", ImageSource = "artist1.png", Name = "Sig4" });

        this.listImgs.ItemsSource = imgs;

        //a.Execute API: GetPrivPhotos passing the
        //Username to receive the photos from AWS
        //i.Each will have an ID#
        //b.Execute API: GetPrivSig passubg the Username to receive the signature
        //photos from AWS
        //i.Each will have an ID#
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
        Image tappedImage = (Image)sender;
        string sourcePath = (tappedImage.Source as FileImageSource)?.File;

        SelectedSig = sigs.FirstOrDefault(x=>x.ImageSource == sourcePath);


    }

    private void imgImg_Click(object sender, TappedEventArgs e)
    {

        Image tappedImage = (Image)sender;
        string sourcePath = (tappedImage.Source as FileImageSource)?.File;

        SelectedSig = sigs.FirstOrDefault(x => x.ImageSource == sourcePath);
    }

    private void btnPlus_Clicked(object sender, EventArgs e)
    {
        /*i.Open the device photo library to complete the process of adding.
        The user should be prompted for the name of the photo
        ii.Execute API: AddPrivPhoto to save the photo to AWS, with a
        return ID# for the photo*/
    }

    private void btnMinus_Click(object sender, EventArgs e)
    {
            //An Alert window should pop up asking if they want to delete the
            //photo
            //iii.Execute API: DelPrivPhoto to delete the photo at AWS


    }

    private void btnSigPlus_Click(object sender, EventArgs e)
    {
        /*i.Open the device photo library to complete the process of adding.
        The user should be prompted for the name of the photo
        ii. Execute API: AddPrivDig to save the photo to AWS, with a return
        ID# for the photo
         */
    }

    private void btnSigMinus_Click(object sender, EventArgs e)
    {
        /*
         i. An Alert window should pop up asking if they want delete the photo
        ii. Execute API: DelPriSig to delete the photo at AWS
         */
    }
}