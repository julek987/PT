using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Presentation.Model.ModelAPI;

namespace Presentation.ViewModel
{
    public partial class RentViewModel : ObservableObject
    {
        private IRentModel _rent;
        public RentViewModel()
        {
        }
        public RentViewModel(IRentModel rent)
        {
            _rent = rent;
        }

        public string UserId
        {
            get { return _rent.UserId; }
            set
            {
                _rent.UserId = value;
                OnPropertyChanged();
            }
        }

        public string StateId
        {
            get { return _rent.StateId; }
            set
            {
                _rent.StateId = value;
                OnPropertyChanged();
            }
        }

        [ICommand]
        private async Task AddRent()
        {
            await _rent.AddAsync();
        }


    }
}
