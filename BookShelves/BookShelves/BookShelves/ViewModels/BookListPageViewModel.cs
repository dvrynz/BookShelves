using Prism.Navigation;
using System.Collections.ObjectModel;

namespace BookShelves.ViewModels
{
    public class BookListPageViewModel : BaseViewModel
    {
        public ObservableCollection<string> BookTitleList { get; set; } = new ObservableCollection<string>();

        private string _selectedBookTitle;
        public string SelectedBookTitle
        {
            get => _selectedBookTitle;
            set
            {
                SetProperty(ref _selectedBookTitle, value);
                if(value != null)
                    NavigateToBookDetails();
            }
        }

        public BookListPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Book Titles";

            BookTitleList = new ObservableCollection<string>
            {
                "Java", "C#", "Objective C", "Swift", "JavaScript", "JQuery", "Kotlin", "XML", "JSON"
            };
        }

        private async void NavigateToBookDetails() => await NavigateToPage(nameof(Views.BookDetailsPage));
    }
}
