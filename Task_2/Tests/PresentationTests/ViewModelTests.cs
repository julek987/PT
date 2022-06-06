using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.PresentationTests
{
    public class ViewModelTests
    {
        /*
        private readonly UsersViewModel _viewmodel;
        private readonly UsersModel _model;
        public UsersViewModelTests()
        {
            _model = Substitute.For<UsersModel>();
            _viewmodel = new UserViewModel(_model);
        }

        [Fact]
        private async Task SaveCommand_ShouldSaveUser_IfItIsNotNewUser()
        {
            await _viewmodel.SaveCommand.ExecuteAsync(null);
            await _model.Received(1).Save();
        }

        [Fact]
        private async Task CreateCommand_ShouldCreatesNewUser_WhenSavingNewUser()
        {
            var library = Substitute.For<ILibraryService>();
            _model.Library.Returns(library);

            _viewmodel.NewUserCommand.Execute(null);
            await _viewmodel.SaveCommand.ExecuteAsync(null);
            await _model.DidNotReceive().Save();
            await library.Received(1).AddUser(Arg.Any<IUserModel>());
        }
        */
    }
}
