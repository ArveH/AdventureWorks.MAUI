namespace AdventureWorks.EntityLayer;

public class User
{
    public DateTime BirthDate { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public bool IsActive{ get; set; }
    public bool IsEnrolledIn401k{ get; set; }
    public bool IsEnrolledInFlexTime{ get; set; }
    public bool IsEnrolledInHealthCare{ get; set; }
    public bool IsEnrolledInHSA{ get; set; }
    public bool IsFullTime{ get; set; }
    public string LastName { get; set; }
    public string LoginId { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public string PhoneType { get; set; }
    public TimeSpan StartTime { get; set; }
    public int UserId { get; set; }
}