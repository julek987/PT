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
        public string BookId { get; set; }
        public string UserId { get; set; }
    }
}
