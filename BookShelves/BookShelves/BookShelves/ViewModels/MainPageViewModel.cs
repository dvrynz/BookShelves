using Prism.Navigation;

namespace BookShelves.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Main Page";
        }
    }
}
