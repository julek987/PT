using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Service.API;

namespace Presentation.ViewModel 
{
    public partial class RentViewModel : ObservableObject
    {
        private IRent _rent;
        public RentViewModel()
        {
        }
        public RentViewModel(IRent rent)
        {
            _rent = rent;
        }
        
        public string UserId
        {
            get { return _rent.UserId; }
            set 
            { 
                _rent.UserId = value; 
                OnPropertyChanged();
            }
        }

        public string StateId
        {
            get { return _rent.StateId; }
            set
            {
                _rent.StateId = value;
                OnPropertyChanged();
            }
        }
    }
}
