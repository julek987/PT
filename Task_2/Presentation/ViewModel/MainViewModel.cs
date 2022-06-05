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

        [ObservableProperty]
        private MainViewModel _activeBook;
        
        private int _selectedBook;


        public int SelectedBook
        {
            get => _selectedBook;
            set
            {
                _selectedBook = value;
                OnPropertyChanged();
                try
                {
                    _activeBook = new MainViewModel();
                    OnPropertyChanged(nameof(ActiveBook));
                }
                catch (ArgumentOutOfRangeException) { }
            }
        }
        [ObservableProperty]
        private MainViewModel _activeUser;
        private int _selectedUser;

        public int SelectedUser
        {
            get => _selectedUser;
            set
            {
                _selectedUser = value;
                OnPropertyChanged();
                try
                {
                    _activeUser = new MainViewModel();
                    OnPropertyChanged(nameof(ActiveUser));
                }
                catch (ArgumentOutOfRangeException) { }
            }
        }

    }
}
