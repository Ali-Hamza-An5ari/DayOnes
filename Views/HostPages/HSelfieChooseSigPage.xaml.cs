using System.ComponentModel;

namespace DayOnes.Views;

public partial class HSelfieChooseSigPage : ContentPage, INotifyPropertyChanged
{

    public event PropertyChangedEventHandler PropertyChanged;

    private List<string> _imageUrls;
    public List<string> ImageUrls
    {
        get { return _imageUrls; }
        set
        {
            _imageUrls = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ImageUrls)));
        }
    }
    public HSelfieChooseSigPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
        BindingContext = this;

        ImageUrls = new List<string>
            {
                "sig2.png",
                "sig2.png",
                "sig3.png",
                "sig3.png",
                // Add more image URLs as needed
            };
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {

        Shell.Current.GoToAsync(nameof(HSeeSelfiePage));
    }

    private void layoutSig_Tap(object sender, TappedEventArgs e)
    {

        Shell.Current.GoToAsync(nameof(HFinalSeeSelfiePage));

    }
    //private void HandleItemSelected(object sender, SelectedItemChangedEventArgs e)
    //{
    //    if (e.SelectedItem != null && e.SelectedItem is string selectedImage)
    //    {
    //        for (int i = 0; i < ImageUrls.Count; i++)
    //        {
    //            if (ImageUrls[i].Equals(selectedImage))
    //            {
    //                // Set IsSelected to true for the selected item
    //                ImageUrls[i] = selectedImage;
    //            }
    //            else
    //            {
    //                // Set IsSelected to false for other items
    //                ImageUrls[i] = null; // Or any other value that represents deselected state
    //            }
    //        }
    //    }
    //}
}