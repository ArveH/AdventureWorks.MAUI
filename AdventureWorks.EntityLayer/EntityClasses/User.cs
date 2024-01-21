using Common.Library;

namespace AdventureWorks.EntityLayer;

public class User : EntityBase
{
    #region Private Variables
    private int _UserId;
    private string _LoginId = string.Empty;
    private string _FirstName = string.Empty;
    private string _LastName = string.Empty;
    private string _Email = string.Empty;
    private string _Password = string.Empty;
    private string _Phone = string.Empty;
    private string _PhoneType = string.Empty;
    private bool _IsFullTime;
    private bool _IsEnrolledIn401k;
    private bool _IsEnrolledInHealthCare;
    private bool _IsEnrolledInHSA;
    private bool _IsEnrolledInFlexTime;
    private bool _IsActive;
    private DateTime _BirthDate = new();
    private TimeSpan _StartTime = new(6, 0, 0);
    #endregion

    #region Public Properties
    public int UserId
    {
        get { return _UserId; }
        set
        {
            _UserId = value;
            RaisePropertyChanged(nameof(UserId));
        }
    }

    public string LoginId
    {
        get { return _LoginId; }
        set
        {
            _LoginId = value;
            RaisePropertyChanged(nameof(LoginId));
        }
    }

    public string FirstName
    {
        get { return _FirstName; }
        set
        {
            _FirstName = value;
            RaisePropertyChanged(nameof(FirstName));
        }
    }

    public string LastName
    {
        get { return _LastName; }
        set
        {
            _LastName = value;
            RaisePropertyChanged(nameof(LastName));
        }
    }

    public string Email
    {
        get { return _Email; }
        set
        {
            _Email = value;
            RaisePropertyChanged(nameof(Email));
        }
    }

    public string Password
    {
        get { return _Password; }
        set
        {
            _Password = value;
            RaisePropertyChanged(nameof(Password));
        }
    }

    public string Phone
    {
        get { return _Phone; }
        set
        {
            _Phone = value;
            RaisePropertyChanged(nameof(Phone));
        }
    }

    public string PhoneType
    {
        get { return _PhoneType; }
        set
        {
            _PhoneType = value;
            RaisePropertyChanged(nameof(PhoneType));
        }
    }

    public bool IsFullTime
    {
        get { return _IsFullTime; }
        set
        {
            _IsFullTime = value;
            RaisePropertyChanged(nameof(IsFullTime));
        }
    }

    public bool IsEnrolledIn401k
    {
        get { return _IsEnrolledIn401k; }
        set
        {
            _IsEnrolledIn401k = value;
            RaisePropertyChanged(nameof(IsEnrolledIn401k));
        }
    }

    public bool IsEnrolledInHealthCare
    {
        get { return _IsEnrolledInHealthCare; }
        set
        {
            _IsEnrolledInHealthCare = value;
            RaisePropertyChanged(nameof(IsEnrolledInHealthCare));
        }
    }

    public bool IsEnrolledInHSA
    {
        get { return _IsEnrolledInHSA; }
        set
        {
            _IsEnrolledInHSA = value;
            RaisePropertyChanged(nameof(IsEnrolledInHSA));
        }
    }

    public bool IsEnrolledInFlexTime
    {
        get { return _IsEnrolledInFlexTime; }
        set
        {
            _IsEnrolledInFlexTime = value;
            RaisePropertyChanged(nameof(IsEnrolledInFlexTime));
        }
    }

    public bool IsActive
    {
        get { return _IsActive; }
        set
        {
            _IsActive = value;
            RaisePropertyChanged(nameof(IsActive));
        }
    }

    public DateTime BirthDate
    {
        get { return _BirthDate; }
        set
        {
            _BirthDate = value;
            RaisePropertyChanged(nameof(BirthDate));
        }
    }

    public TimeSpan StartTime
    {
        get { return _StartTime; }
        set
        {
            _StartTime = value;
            RaisePropertyChanged(nameof(StartTime));
        }
    }

    public string FullName
    {
        get { return FirstName + " " + LastName; }
    }

    public string LastNameFirstName
    {
        get { return LastName + ", " + FirstName; }
    }
    #endregion
}
