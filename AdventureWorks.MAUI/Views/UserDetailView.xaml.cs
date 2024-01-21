using AdventureWorks.EntityLayer;
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

    public UserViewModelCommands ViewModel { get; set; }
    public int UserId { get; set; }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Set the Page BindingContext
        BindingContext = ViewModel;

        // Get the Phone Types
        ViewModel.GetPhoneTypes();

        // Retrieve a User
        ViewModel.Get(UserId);
    }
}