

namespace DayOnes.Views;

public partial class HFinalSeeSelfiePage : ContentPage
{
	public HFinalSeeSelfiePage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });

        imgSig.Source = HSelfieChooseSigPage.SelectedSigID.ImageSource;
        string sigID = HSelfieChooseSigPage.SelectedSigID.ID;
        //Invoke API: Get AllSigs100

    }

    private void imgCancel_Tap(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HSelfieChooseSigPage));
    }

    private void imgUpload_Tap(object sender, TappedEventArgs e)
    {
        /*a.Remove the dotted lines around the signature.
        b.Save the photo in temporary storage, with new
        Name & ID.
        c.Evoke API to upload this photo API:
        UPLPhotoSig.
        */
        Shell.Current.GoToAsync(nameof(HHomeUploadedPage));

    }
}