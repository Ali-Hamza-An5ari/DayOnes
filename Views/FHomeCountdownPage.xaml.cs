using System.ComponentModel;

namespace DayOnes.Views;

public partial class FHomeCountdownPage : ContentPage
{
    private const int CountdownDurationSeconds = 30;
    private int remainingSeconds;
    private bool isCountdownRunning;

    public event PropertyChangedEventHandler PropertyChanged;

    public int RemainingSeconds
    {
        get => remainingSeconds;
        set
        {
            if (remainingSeconds != value)
            {
                remainingSeconds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RemainingSeconds)));
            }
        }
    }

    public bool IsButtonEnabled => !isCountdownRunning && remainingSeconds == 0;

    public FHomeCountdownPage()
	{
		InitializeComponent();
        BindingContext = this;

        StartCountdown();
        this.lblCountDown.Text = RemainingSeconds.ToString();
    }

    private async void StartCountdown()
    {
        try
        {
            RemainingSeconds = CountdownDurationSeconds;
            isCountdownRunning = true;

            while (RemainingSeconds > 0)
            {
                await Task.Delay(1000); // Delay for one second
                RemainingSeconds--;
                this.lblCountDown.Text = RemainingSeconds.ToString();
            }
            btnInvites.IsEnabled = true;
            isCountdownRunning = false;
            btnInvites.IsVisible = true;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsButtonEnabled)));
        }
        catch { }
    }

    private void btnInvites_Click(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(FMessageReceivedPage));
    }
}