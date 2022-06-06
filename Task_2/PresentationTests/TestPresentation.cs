using Presentation.ViewModel;
using Service.API;
using NSubstitute;

namespace PresentationTests
{
    public class TestPresentation
    {
        private readonly BookInfoViewModel CatalogViewModel;

        private readonly UsersViewModel UsersViewModel;

        private readonly BookViewModel StateViewModel;

        private readonly ICatalog Catalog;

        private readonly IUsers User;

        private readonly IState State;
        public TestPresentation()
        {
            Catalog = Substitute.For<ICatalog>();
            CatalogViewModel = new BookInfoViewModel(Catalog);
            User = Substitute.For<IUsers>();
            UsersViewModel = new UsersViewModel(User);
            State = Substitute.For<IState>();
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