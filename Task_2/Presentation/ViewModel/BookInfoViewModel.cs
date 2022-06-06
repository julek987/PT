using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Presentation.Model;
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
        public string InfoId
        {
            get => _catalog.Id;
            set
            {
                _catalog.Id = value;
                OnPropertyChanged();
            }
        }

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
        private async Task AddState()
        {
            await _catalog.AddAsync();
        }
        [ICommand]
        private async Task DeleteState()
        {
            await _catalog.DeleteAsync();
        }
    }
}
