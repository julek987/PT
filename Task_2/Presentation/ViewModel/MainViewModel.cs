using System;
using CommunityToolkit.Mvvm.ComponentModel;
using Presentation.Model;

namespace Presentation.ViewModel 
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            
            BookViewModel = new BookViewModel(new StateModel("", ""));
            BookInfoViewModel = new BookInfoViewModel(new CatalogModel("", "", ""));
            RentViewModel = new RentViewModel(new RentModel("", ""));
            ReturnViewModel = new ReturnViewModel(new ReturnModel("", ""));
            UsersViewModel = new UsersViewModel(new UsersModel("", "", ""));
        }
        public BookViewModel BookViewModel { get; set;}
        public BookInfoViewModel BookInfoViewModel { get; set;}
        public RentViewModel RentViewModel { get; set;}
        public ReturnViewModel ReturnViewModel { get; set;}
        public UsersViewModel UsersViewModel { get; set; }

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
