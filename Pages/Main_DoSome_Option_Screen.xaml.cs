namespace DoSomeApplication.Pages;

public partial class Main_DoSome_Option_Screen : ContentPage
{
	public Main_DoSome_Option_Screen()
	{
		InitializeComponent();
	}

    private async void login_button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new DoSome_Login_Screen());
    }

    private async void anonymous_button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new DoSome_Anonymous_Screen());
    }
}