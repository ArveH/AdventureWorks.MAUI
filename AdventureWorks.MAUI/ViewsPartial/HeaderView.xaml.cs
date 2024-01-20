namespace AdventureWorks.MAUI.ViewsPartial;

public partial class HeaderView : ContentView
{
    public HeaderView()
    {
        InitializeComponent();

        ViewTitle = "View Title";
        ViewDescription = "View Description";
        this.BindingContext = this;
    }

    public string ViewTitle
    {
        get => (string)GetValue(ViewTitleProperty);
        set => SetValue(ViewTitleProperty, value);
    }

    public static readonly BindableProperty ViewTitleProperty =
        BindableProperty.Create(nameof(ViewTitle), typeof(string), typeof(HeaderView), string.Empty);

    public string ViewDescription
    {
        get => (string)GetValue(ViewDescriptionProperty);
        set => SetValue(ViewDescriptionProperty, value);
    }

    public static readonly BindableProperty ViewDescriptionProperty =
        BindableProperty.Create(nameof(ViewDescription), typeof(string), typeof(HeaderView), string.Empty);
}