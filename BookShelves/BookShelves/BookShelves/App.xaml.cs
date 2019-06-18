using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BookShelves.Views;
using Prism.Unity;
using Prism.Ioc;
using Prism;

namespace BookShelves
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }

        protected override void OnInitialized()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
