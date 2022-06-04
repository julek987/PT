using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Presentation.ViewModel 
{
    public class UsersViewModel: ObservableObject
    {
        private Service.API.IUsers _user;
        public UsersViewModel()
        {
        }
        public UsersViewModel(Service.API.IUsers user)
        {
            _user = user;
        }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
