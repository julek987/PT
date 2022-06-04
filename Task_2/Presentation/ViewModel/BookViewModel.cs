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
        public string BookId { get; set; }
        public string InfoId { get; set; }   

    }
}
