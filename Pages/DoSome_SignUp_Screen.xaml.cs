namespace DoSomeApplication.Pages;

public partial class DoSome_SignUp_Screen : ContentPage
{
	public DoSome_SignUp_Screen()
	{
		InitializeComponent();
	}

    private async void signup_button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new DoSome_Home_Screen());
    }
}