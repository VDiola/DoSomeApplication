namespace DoSomeApplication.Pages;

public partial class DoSome_Anonymous_Screen : ContentPage
{
	public DoSome_Anonymous_Screen()
	{
		InitializeComponent();
	}


    private async void enter_button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new DoSome_Home_Screen());
    }
}