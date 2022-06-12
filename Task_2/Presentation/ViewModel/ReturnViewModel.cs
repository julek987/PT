using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Presentation.Model.ModelAPI;

namespace Presentation.ViewModel
{
    public partial class ReturnViewModel : ObservableObject
    {
        private IReturnModel _return;
        public ReturnViewModel(IReturnModel @return)
        {
            _return = @return;
        }

        public string UserId
        {
            get { return _return.UserId; }
            set
            {
                _return.UserId = value;
                OnPropertyChanged();
            }
        }

        public string StateId
        {
            get { return _return.StateId; }
            set
            {
                _return.StateId = value;
                OnPropertyChanged();
            }
        }

        [ICommand]
        private async Task AddReturn()
        {
            await _return.AddAsync();
        }
    }
}
