using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Presentation.ViewModel
{
    public class ReturnViewModel : ObservableObject
    {
        private Service.API.IReturn _return;
        public ReturnViewModel()
        {
        }
        public ReturnViewModel(Service.API.IReturn @return)
        {
            _return = @return;
        }

        public string UserId
        {
            get { return _return.UserId; }
            set
            {
                _return.UserId = value;
                OnPropertyChanged();
            }
        }

        public string StateId
        {
            get { return _return.StateId; }
            set
            {
                _return.StateId = value;
                OnPropertyChanged();
            }
        }

        [ICommand]
        private async Task AddReturn()
        {
            await _return.AddAsync();
        }
    }
}
