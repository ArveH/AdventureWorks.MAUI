using System.Collections.ObjectModel;
using System.Diagnostics;
using AdventureWorks.EntityLayer;
using Common.Library;

namespace AdventureWorks.ViewModelLayer;

public class UserViewModel : ViewModelBase
{
    #region Get Method

    public ObservableCollection<User> Get()
    {
        if (Repository != null)
        {
            UserList = new ObservableCollection<User>(Repository.Get());
        }

        return UserList;
    }

    #endregion

    #region Get(id) Method

    /// <summary>
    ///     Get a single user object
    /// </summary>
    /// <param name="id">The UserId to locate</param>
    /// <returns>An instance of a User object</returns>
    public User? Get(int id)
    {
        try
        {
            // Get a User from a data store
            if (Repository != null)
                UserObject = Repository.Get(id);
            else
                // MOCK Data
                UserObject = new User
                {
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
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
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
        Debugger.Break();

        return true;
    }

    #endregion

    #region Constructors

    public UserViewModel()
    {
    }

    public UserViewModel(IRepository<User> repo)
    {
        Repository = repo;
    }

    public UserViewModel(IRepository<User> repo, IRepository<PhoneType> phoneRepo)
    {
        Repository = repo;
        _PhoneTypeRepository = phoneRepo;
    }

    #endregion

    #region Private Variables

    private User? _UserObject = new();
    private ObservableCollection<User> _UserList = new();

    private readonly IRepository<User>? Repository;
    private readonly IRepository<PhoneType>? _PhoneTypeRepository;
    private ObservableCollection<string> _PhoneTypesList = new();

    #endregion

    #region Public Properties

    public User? UserObject
    {
        get => _UserObject;
        set
        {
            _UserObject = value;
            RaisePropertyChanged(nameof(UserObject));
        }
    }

    public ObservableCollection<User> UserList
    {
        get => _UserList;
        set
        {
            _UserList = value;
            RaisePropertyChanged(nameof(UserList));
        }
    }

    public ObservableCollection<string> PhoneTypesList
    {
        get => _PhoneTypesList;
        set
        {
            _PhoneTypesList = value;
            RaisePropertyChanged(nameof(PhoneTypesList));
        }
    }

    #endregion
}