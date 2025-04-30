using navigation2.MVVM.Pages;
namespace navigation2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new NewPage1());
        }
    }
}
