
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Presentation.Model;
using Service.API;

namespace Presentation.ViewModel 
{
    public class UsersViewModel: ObservableObject
    {
        private IUsers _user;
        public UsersViewModel()
        {
        }
        public UsersViewModel(IUsers user)
        {
            _user = user;
        }
        public string UserId { 
            get => _user.Id;
            set
            {
                _user.Id = value;
                OnPropertyChanged();
            } }
        public string Name { 
            get => _user.FirstName;
            set
            {
                _user.FirstName = value;
                OnPropertyChanged();
            } }
        public string Surname { 
            get => _user.LastName;
            set
            {
                _user.LastName = value;
                OnPropertyChanged();
            } }
        [ICommand]
        private async Task AddUser()
        {
            await _user.AddAsync();
        }
        [ICommand]
        private async Task DeleteUser()
        {
            await _user.DeleteAsync();
        }
    }
}
