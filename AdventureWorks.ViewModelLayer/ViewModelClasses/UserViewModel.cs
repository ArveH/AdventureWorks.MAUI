using System.Collections.ObjectModel;
using AdventureWorks.EntityLayer;
using Common.Library;

namespace AdventureWorks.ViewModelLayer;

public class UserViewModel : ViewModelBase
{
  #region Constructors
  public UserViewModel() : base()
  {
  }

  public UserViewModel(IRepository<User> repo) : base()
  {
      Repository = repo;
  }

    public UserViewModel(IRepository<User> repo, IRepository<PhoneType> phoneRepo) : base()
    {
        Repository = repo;
        _PhoneTypeRepository = phoneRepo;
    }
    #endregion

    #region Private Variables
    private User? _UserObject = new();
    private readonly IRepository<User>? Repository;
    private readonly IRepository<PhoneType>? _PhoneTypeRepository;
    private ObservableCollection<string> _PhoneTypesList = new();
  #endregion

    #region Public Properties
    public User? UserObject
    {
        get { return _UserObject; }
        set
        {
          _UserObject = value;
          RaisePropertyChanged(nameof(UserObject));
        }
    }

    public ObservableCollection<string> PhoneTypesList
    {
        get { return _PhoneTypesList; }
        set
        {
            _PhoneTypesList = value;
            RaisePropertyChanged(nameof(PhoneTypesList));
        }
    }
    #endregion

    #region Get Method
    public ObservableCollection<User> Get()
  {
    return new();
  }
  #endregion

  #region Get(id) Method
  /// <summary>
  /// Get a single user object
  /// </summary>
  /// <param name="id">The UserId to locate</param>
  /// <returns>An instance of a User object</returns>
  public User? Get(int id)
  {
    try {
      // Get a User from a data store
      if (Repository != null) {
        UserObject = Repository.Get(id);
      }
      else {
        // MOCK Data
        UserObject = new User {
          UserId = id,
          LoginId = "SallyJones615",
          FirstName = "Sally",
          LastName = "Jones",
          Email = "Sallyj@jones.com",
          Phone = "615.987.3456",
          PhoneType = "Mobile",
          IsFullTime = true,
          IsEnrolledIn401k = true,
          IsEnrolledInFlexTime = false,
          IsEnrolledInHealthCare = true,
          IsEnrolledInHSA = false,
          IsActive = true,
          BirthDate = Convert.ToDateTime("08-13-1989"),
          StartTime = new TimeSpan(7, 30, 0)
        };
      }
    }
    catch (Exception ex) {
      System.Diagnostics.Debug.WriteLine(ex.ToString());
    }

    return UserObject;
  }
    #endregion

    #region GetPhoneTypes Method
    public ObservableCollection<string> GetPhoneTypes()
    {
        if (_PhoneTypeRepository != null)
        {
            var list = _PhoneTypeRepository.Get();

            PhoneTypesList = new ObservableCollection<string>(list.Select(row => row.TypeDescription));
        }

        return PhoneTypesList;
    }
    #endregion

    #region Save Method
    public virtual bool Save()
  {
    // TODO: Write code to save data
    System.Diagnostics.Debugger.Break();

    return true;
  }
  #endregion
}
