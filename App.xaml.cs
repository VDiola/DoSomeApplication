using DoSomeApplication.Pages;

namespace DoSomeApplication
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Main_DoSome_Option_Screen();

            //Borderless Entry
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderlessEntry), (handler, view) =>
            {
            #if __ANDROID__
                        handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
            #endif
            });
        }
    }
}