using AdventureWorks.MAUI.CommandClasses;

namespace AdventureWorks.MAUI.Views;

[QueryProperty(nameof(UserId), "id")]
public partial class UserDetailView : ContentPage
{
    public UserDetailView(UserViewModelCommands viewModel)
    {
        InitializeComponent();

        ViewModel = viewModel;
    }

    public UserViewModelCommands? ViewModel { get; set; }
    public int UserId { get; set; }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        BindingContext = ViewModel;

        ViewModel.GetPhoneTypes();

        ViewModel.Get(UserId);
    }
}