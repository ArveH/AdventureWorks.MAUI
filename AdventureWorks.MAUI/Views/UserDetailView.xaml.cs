using AdventureWorks.EntityLayer;
using AdventureWorks.ViewModelLayer;

namespace AdventureWorks.MAUI.Views;

public partial class UserDetailView : ContentPage
{
	public UserDetailView()
	{
		InitializeComponent();
    }

	public UserViewModel? ViewModel { get; set; }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        ViewModel = new();

        BindingContext = ViewModel;

        ViewModel.Get(1);
    }

    private void SaveButton_Clicked(object? sender, EventArgs e)
    {
        System.Diagnostics.Debugger.Break();
    }
}