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
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
