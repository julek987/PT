using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Presentation.ViewModel 
{
    public partial class MainViewModel : ObservableObject
    {
        public BookViewModel BookViewModel { get; set; } = new BookViewModel();
        public BookInfoViewModel BookInfoViewModel { get; set; } = new BookInfoViewModel();
        public RentViewModel RentViewModel { get; set; } = new RentViewModel();
        public ReturnViewModel ReturnViewModel { get; set; } = new ReturnViewModel();
        public UsersViewModel UsersViewModel { get; set; } = new UsersViewModel();
        
    }
}
