using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Service.API;
using System.Threading.Tasks;

namespace Presentation.ViewModel
{
    public partial class BookInfoViewModel : ObservableObject
    {
        [ObservableProperty]
        private Service.API.ICatalog _catalog;

        private bool _newCatalog = false;
        public BookInfoViewModel()
        {
        }

        public BookInfoViewModel(Service.API.ICatalog catalog)
        {
            _catalog = catalog;
        }
        public string InfoId => _catalog.Id;

        public string Title
        {
            get => _catalog.Title;
            set
            {
                _catalog.Title = value;
                OnPropertyChanged();
            }
        }

        public string Author
        {
            get => _catalog.Author;
            set
            {
                _catalog.Author = value;
                OnPropertyChanged();
            }
        }

        [ICommand]
        private async Task Save()
        {
            if (_newCatalog)
            {
                await _catalog.Create();
                _newCatalog = false;
            }
            else
            {
                await _catalog.Save();
            }
        }

        [ICommand]
        private void NewCatalog()
        {
            _newCatalog = true;
            _catalog = new BookModel(_book.Library);
            OnPropertyChanged(nameof(InfoId));
            OnPropertyChanged(nameof(Title));
            OnPropertyChanged(nameof(Author));
        }
    }
}
