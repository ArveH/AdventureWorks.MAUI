using AdventureWorks.MAUI.CommandClasses;

namespace AdventureWorks.MAUI.Views;

[QueryProperty(nameof(ProductId), "id")]
public partial class ProductDetailView : ContentPage
{
    public ProductDetailView(ProductViewModelCommands viewModel)
    {
        InitializeComponent();

        ViewModel = viewModel;
    }

    public ProductViewModelCommands ViewModel { get; set; }
    public int ProductId { get; set; }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Set the Page BindingContext
        BindingContext = ViewModel;

        // Retrieve a Product
        ViewModel.Get(ProductId);
    }
}