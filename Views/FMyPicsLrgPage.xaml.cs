namespace DayOnes.Views;

public partial class FMyPicsLrgPage : ContentPage
{
	public FMyPicsLrgPage()
	{
		InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }

    private void EmailRadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        this.imgSelected2.IsVisible = false;
        this.imgSelected3.IsVisible = false;
        this.imgSelected1.IsVisible = true;
    }

    private void DeviceRadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {

        this.imgSelected2.IsVisible = true;
        this.imgSelected3.IsVisible = false;
        this.imgSelected1.IsVisible = false;
    }

    private void TextRadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        this.imgSelected2.IsVisible = false;
        this.imgSelected3.IsVisible = true;
        this.imgSelected1.IsVisible = false;

    }
}