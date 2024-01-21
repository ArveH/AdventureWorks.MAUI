using AdventureWorks.MAUI.CommandClasses;

namespace AdventureWorks.MAUI.Views;

public partial class UserDetailView : ContentPage
{
	public UserDetailView(UserViewModelCommands viewModel)
	{
		InitializeComponent();
        ViewModel = viewModel;
    }

	public UserViewModelCommands? ViewModel { get; set; }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        BindingContext = ViewModel;

        ViewModel.GetPhoneTypes();

        ViewModel.Get(1);
    }
}