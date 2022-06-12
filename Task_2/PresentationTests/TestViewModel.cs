using Presentation.ViewModel;
using NSubstitute;
using Presentation.Model.ModelAPI;

namespace PresentationTests
{
    public class TestViewModel
    {
        private readonly BookInfoViewModel CatalogViewModel;

        private readonly UsersViewModel UsersViewModel;

        private readonly BookViewModel StateViewModel;

        private readonly ICatalogModel Catalog;

        private readonly IUsersModel User;

        private readonly IStateModel State;
        public TestViewModel()
        {
            Catalog = Substitute.For<ICatalogModel>();
            CatalogViewModel = new BookInfoViewModel(Catalog);
            User = Substitute.For<IUsersModel>();
            UsersViewModel = new UsersViewModel(User);
            State = Substitute.For<IStateModel>();
            StateViewModel = new BookViewModel(State);
        }

        [Fact]
        public async void AddStateTest()
        {
            await CatalogViewModel.AddStateCommand.ExecuteAsync(null);
            await Catalog.Received(1).AddAsync();
        }

        [Fact]
        public async void DeleteStateTest()
        {
            await CatalogViewModel.DeleteStateCommand.ExecuteAsync(null);
            await Catalog.Received(1).DeleteAsync();
        }

        [Fact]
        public async void AddUserTest()
        {
            await UsersViewModel.AddUserCommand.ExecuteAsync(null);
            await User.Received(1).AddAsync();
        }

        [Fact]
        public async void DeleteUserTest()
        {
            await UsersViewModel.DeleteUserCommand.ExecuteAsync(null);
            await User.Received(1).DeleteAsync();
        }
    }
}