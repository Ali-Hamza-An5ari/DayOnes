namespace DayOnes.Views.HostPages;

public partial class HHomePage : ContentPage
{
    private double distance = 0;
    private string option = "";
    public static string CapturedImageResource = "";
    public static string UploadedImageResource = "";
	public HHomePage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }

    private void sliderDistance_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        distance = e.NewValue;
    }

    private async void layoutCamera_Tapped(object sender, TappedEventArgs e)
    {

        if (MediaPicker.Default.IsCaptureSupported)
        {
            //TAKE PHOTO OR CAPTURE PHOTO
            // FileResult myPhoto = await MediaPicker.Default.CapturePhotoAsync();

            //LOAD PHOTO
            FileResult myPhoto = await MediaPicker.Default.CapturePhotoAsync();
            if (myPhoto != null)
            {
                //save the image captured in the application.
                string localFilePath = Path.Combine(FileSystem.CacheDirectory, myPhoto.FileName);
                using Stream sourceStream = await myPhoto.OpenReadAsync();

                CapturedImageResource = localFilePath;

                using FileStream localFileStream = File.OpenWrite(localFilePath);
                await sourceStream.CopyToAsync(localFileStream);
                //await Shell.Current.DisplayAlert("Success", "Image uploaded successfully", "Ok");
            }
        }
        else
        {
            await Shell.Current.DisplayAlert("OOPS", "You device isn't supported", "Ok");
        }
        //Invoke the Device Camera to take a selfie
        Shell.Current.GoToAsync(nameof(HSeeSelfiePage));
    }

    private async void layoutPics_Tapped(object sender, TappedEventArgs e)
    {

        if (MediaPicker.Default.IsCaptureSupported)
        {
            //TAKE PHOTO OR CAPTURE PHOTO
            // FileResult myPhoto = await MediaPicker.Default.CapturePhotoAsync();

            //LOAD PHOTO
            FileResult myPhoto = await MediaPicker.Default.PickPhotoAsync();
            if (myPhoto != null)
            {
                //save the image captured in the application.
                string localFilePath = Path.Combine(FileSystem.CacheDirectory, myPhoto.FileName);
                using Stream sourceStream = await myPhoto.OpenReadAsync();

                UploadedImageResource = localFilePath; 

                using FileStream localFileStream = File.OpenWrite(localFilePath);
                await sourceStream.CopyToAsync(localFileStream);
                //await Shell.Current.DisplayAlert("Success", "Image uploaded successfully", "Ok");
            }
        }
        else
        {
            await Shell.Current.DisplayAlert("OOPS", "You device isn't supported", "Ok");
        }
        //This opens the device Photo libraries where the user picks a photo
        Shell.Current.GoToAsync(nameof(HReviewPhotoPage));
    }

    private void drpAction_Change(object sender, EventArgs e)
    {
        this.option = drpAction.SelectedItem as string;
    }
}