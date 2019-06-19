using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookShelves.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageBase : ContentPage
    {
        public PageBase()
        {
            InitializeComponent();
        }
    }
}