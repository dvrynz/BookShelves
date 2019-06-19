using BookShelves.Infra;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookShelves.Views
{
    [Page]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookDetailsPage : PageBase
    {
        public BookDetailsPage()
        {
            InitializeComponent();
        }

    }
}