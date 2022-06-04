using CommunityToolkit.Mvvm.ComponentModel;
using Service.API;

namespace Presentation.ViewModel
{
    public partial class BookInfoViewModel : ObservableObject
    {
        private Service.API.ICatalog _catalog;

        public BookInfoViewModel(Service.API.ICatalog catalog)
        {
            _catalog = catalog;
        }

        public string InfoId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }
    }
}
