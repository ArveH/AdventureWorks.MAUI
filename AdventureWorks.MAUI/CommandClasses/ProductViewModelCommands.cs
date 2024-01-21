using AdventureWorks.EntityLayer;
using AdventureWorks.ViewModelLayer;
using Common.Library;
using System.Windows.Input;

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

    #region Commands
    public ICommand SaveCommand { get; private set; }
    public ICommand EditCommand { get; private set; }
    #endregion

    #region Private Variables
    private bool _IsSaveCommandEnabled = true;
    #endregion

    #region Public Properties
    public bool IsSaveCommandEnabled
    {
        get { return _IsSaveCommandEnabled; }
        set
        {
            _IsSaveCommandEnabled = value;
            RaisePropertyChanged(nameof(IsSaveCommandEnabled));
        }
    }
    #endregion

    #region Init Method
    public override void Init()
    {
        base.Init();

        // Create commands for this view
        SaveCommand = new Command(async () => await SaveAsync(), () => IsSaveCommandEnabled);
        EditCommand = new Command<int>(async (int id) => await EditAsync(id), (id) => true);
    }
    #endregion

    #region SaveAsync Method
    public async Task<bool> SaveAsync()
    {
        var ret = base.Save();

        if (ret)
        {
            await Shell.Current.GoToAsync("..");
        }

        return ret;
    }
    #endregion

    #region EditAsync Method
    protected async Task EditAsync(int id)
    {
        await Shell.Current.GoToAsync($"{nameof(Views.ProductDetailView)}?id={id}");
    }
    #endregion
}