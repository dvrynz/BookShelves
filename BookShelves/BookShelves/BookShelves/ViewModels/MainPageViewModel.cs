using Prism.Commands;
using Prism.Navigation;
using System.Windows.Input;

namespace BookShelves.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ICommand NavigateToBookListPageCommand => new DelegateCommand(NavigateToBookList);

        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Main Page";
        }

        private async void NavigateToBookList() => await NavigateToPage(nameof(Views.BookListPage));
    }
}
