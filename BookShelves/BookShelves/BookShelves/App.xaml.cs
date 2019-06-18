using BookShelves.Views;
using Prism;
using Prism.Ioc;
using Prism.Navigation;
using Prism.Unity;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BookShelves
{
    public partial class App : PrismApplication
    {
        private readonly string BASEURI = "http://www.BookShelves.com/";
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
        }

        protected async override void OnInitialized()
        {
            InitializeComponent();
            await NavigateToRootPage(nameof(MainPage), NavigationService);
        }

        private async Task NavigateToRootPage(string pageName, INavigationService navigationService)
        {
            var rootPage = $"{BASEURI}/{nameof(NavigationPage)}/{pageName}";
            await navigationService.NavigateAsync(rootPage);
        }

        #region DEFAULT APP OVERRIDES

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        #endregion

    }
}
