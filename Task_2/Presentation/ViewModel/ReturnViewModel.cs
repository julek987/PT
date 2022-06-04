using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        Service.API.IUsers User => _return.User;
        Service.API.IState State => _return.State;
    }
}
