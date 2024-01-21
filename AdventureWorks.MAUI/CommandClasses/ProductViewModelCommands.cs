using AdventureWorks.EntityLayer;
using AdventureWorks.ViewModelLayer;
using Common.Library;

namespace AdventureWorks.MAUI.CommandClasses;

public class ProductViewModelCommands : ProductViewModel
{
  #region Constructors
  public ProductViewModelCommands()
  {
  }

  public ProductViewModelCommands(IRepository<Product> repo) : base(repo)
  {
  }
  #endregion

}
