using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Presentation.ViewModel 
{
    public partial class RentViewModel : ObservableObject
    {
        private Service.API.IRent _rent;
        public RentViewModel()
        {
        }
        public RentViewModel(Service.API.IRent rent)
        {
            _rent = rent;
        }
        Service.API.IUsers User => _rent.User;
        Service.API.IState State => _rent.State;
    }
}
