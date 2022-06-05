﻿
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Presentation.Model;
using Service.API;

namespace Presentation.ViewModel
{
    public partial class BookViewModel : ObservableObject
    {
        private IState _state;

        public BookViewModel()
        {
        }

        public BookViewModel(IState state)
        {
            _state = state;
        }

        public string Id
        {
            get { return _state.Id; }
            set
            {
                _state.Id = value;
                OnPropertyChanged();
            }
        }
        public string CatalogId
        {
            get { return _state.CatalogId; }
            set
            {
                _state.CatalogId = value;
                OnPropertyChanged();
            }
        }
        [ICommand]
        private async Task AddState()
        {
            await _state.AddAsync();
        }
        [ICommand]
        private async Task DeleteState()
        {
            await _state.DeleteAsync();
        }

    }
}
