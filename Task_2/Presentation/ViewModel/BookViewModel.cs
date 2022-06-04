using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Presentation.ViewModel
{
    public partial class BookViewModel : ObservableObject
    {

        private Service.API.IState _state;

        public BookViewModel()
        {
        }

        public BookViewModel(Service.API.IState state)
        {
            _state = state;
        }
        public string BookId => _state.Id;
        public Service.API.ICatalog Catalog => _state.Catalog;

    }
}
