using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Presentation.Model;
using Service.API;

namespace Presentation.ViewModel 
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel(IService service)
        {
            BookViewModel = new BookViewModel(new StateModel("", "", service));
            BookInfoViewModel = new BookInfoViewModel(new CatalogModel("", "", "", service));
            RentViewModel = new RentViewModel(new RentModel("", "", service));
            ReturnViewModel = new ReturnViewModel(new ReturnModel("", "", service));
            UsersViewModel = new UsersViewModel(new UsersModel(service, "", "", ""));
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
