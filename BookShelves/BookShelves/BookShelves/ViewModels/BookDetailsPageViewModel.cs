using Prism.Commands;
using Prism.Navigation;
using System.Windows.Input;

namespace BookShelves.ViewModels
{
    public class BookDetailsPageViewModel : BaseViewModel
    {
        public ICommand NavigateBackToRootPageCommand => new DelegateCommand(async () => await NavigateToRootPage());

        public BookDetailsPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Book Details Page";
        }
    }
}
