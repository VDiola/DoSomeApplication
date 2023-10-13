using DoSomeApplication.Pages;

namespace DoSomeApplication
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Main_DoSome_Option_Screen();
        }
    }
}