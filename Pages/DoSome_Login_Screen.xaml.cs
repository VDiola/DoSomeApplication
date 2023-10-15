namespace DoSomeApplication.Pages;

public partial class DoSome_Login_Screen : ContentPage
{
	public DoSome_Login_Screen()
	{
		InitializeComponent();
	}

    private async void signup_button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new DoSome_SignUp_Screen());
    }

    private async void login_button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new DoSome_Home_Screen());
    }
}