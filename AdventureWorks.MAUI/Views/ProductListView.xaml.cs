using AdventureWorks.EntityLayer;
using AdventureWorks.MAUI.CommandClasses;

namespace AdventureWorks.MAUI.Views;

public partial class ProductListView : ContentPage
{
  public ProductListView(ProductViewModelCommands viewModel)
  {
    InitializeComponent();

    ViewModel = viewModel;
  }

  private readonly ProductViewModelCommands ViewModel;

  protected override void OnAppearing()
  {
    base.OnAppearing();

    BindingContext = ViewModel;

    ViewModel.Get();
  }
}
