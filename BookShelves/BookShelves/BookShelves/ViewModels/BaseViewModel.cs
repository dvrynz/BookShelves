using Prism.Navigation;

namespace BookShelves.ViewModels
{
    public abstract class BaseViewModel
    {
        private readonly INavigationService _navigationService;

        protected string Title { get; set; }

        public BaseViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
