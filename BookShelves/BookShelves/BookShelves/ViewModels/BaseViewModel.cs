using Prism.Mvvm;
using Prism.Navigation;
using System.Threading.Tasks;

namespace BookShelves.ViewModels
{
    public abstract class BaseViewModel : BindableBase
    {
        protected INavigationService NavigationService { get; private set; }

        public string Title { get; set; }

        public BaseViewModel(INavigationService navigationService) => NavigationService = navigationService;

        protected async Task NavigateToPage(string pageName) => await NavigationService.NavigateAsync(pageName);

        protected async Task NavigateToRootPage()
        {
            var result = await NavigationService.GoBackToRootAsync();
        }
    }
}
