namespace AndroidCrash;

public partial class MainPage : ContentPage
{
    private readonly View Control = new Label() {
        Text = "Test"
    };

    private readonly Button Trigger = new Button() {
        Text = "Click Me"
    };

    public MainPage()
    {
        InitializeComponent();

        Trigger.Clicked += (sender, args) =>
        {
            Add();
        };

        Content = new VerticalStackLayout()
        {
            Children =
            {
                Trigger,
                Control
            }
        };
    }

    private void Add()
    {
        Content = new VerticalStackLayout()
        {
            Control
        };
    }
}