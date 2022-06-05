
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Presentation.Model;
using Service.API;

namespace Presentation.ViewModel
{
    public partial class BookViewModel : ObservableObject
    {

        private Service.API.IState _state;
        [ObservableProperty]
        private Service.API.ICatalog _catalog;

        private bool _newState = false;

        public BookViewModel()
        {
        }

        public BookViewModel(Service.API.IState state)
        {
            _state = state;
        }
        public string BookId => _state.Id;
        public string InfoId {
            get => _state.CatalogId;
            set { _state.CatalogId = value; OnPropertyChanged();} 
        }

        [ICommand]
        private async Task Save()
        {
            if (_newState)
            {
                await _state.Create();
                _newState = false;
            }
            else
            {
                // TO DO
                //await _catalog.Save();
            }
        }
        [ICommand]
        private void NewState()
        {
            _newState = true;
            _state = new StateModel(_state.Servicee);
            OnPropertyChanged(nameof(BookId));
            OnPropertyChanged(nameof(InfoId));
        }

    }
}
