using AdventureWorks.EntityLayer;

namespace AdventureWorks.MAUI.Views;

public partial class UserDetailView : ContentPage
{
	public UserDetailView()
	{
		InitializeComponent();

        UserObject = (User)this.Resources["ViewModel"];
    }

	public User UserObject { get; set; }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        UserObject.LoginId = "PeterPiper384";
        UserObject.FirstName = "Peter";
        UserObject.LastName = "Piper";
        UserObject.Email = "Peter@Pipering.com";
    }

    private void SaveButton_Clicked(object? sender, EventArgs e)
    {
        System.Diagnostics.Debugger.Break();
    }
}