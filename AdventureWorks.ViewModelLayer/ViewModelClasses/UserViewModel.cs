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

  //public UserViewModel(IRepository<User> repo, IRepository<PhoneType> phoneRepo) : base()
  //{
  //    Repository = repo;
  //    _PhoneTypeRepository = phoneRepo;
  //}
  #endregion

  #region Private Variables
    private User? _UserObject = new();
  private readonly IRepository<User>? Repository;
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
  
  #region Save Method
  public virtual bool Save()
  {
    // TODO: Write code to save data
    System.Diagnostics.Debugger.Break();

    return true;
  }
  #endregion
}
