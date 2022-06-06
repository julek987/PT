using Presentation.ViewModel;
using Service.API;
using NSubstitute;

namespace PresentationTests
{
    public class TestPresentation
    {
        private readonly BookInfoViewModel CatalogViewModel;

        private readonly ICatalog Catalog;
        public TestPresentation()
        {
            Catalog = Substitute.For<ICatalog>();
            CatalogViewModel = new BookInfoViewModel(Catalog);
        }

        [Fact]
        public async void AddTest()
        {
            await CatalogViewModel.AddStateCommand.ExecuteAsync(null);
            await Catalog.Received(1).AddAsync();
        }

        [Fact]
        public async void DeleteTest()
        {
            await CatalogViewModel.DeleteStateCommand.ExecuteAsync(null);
            await Catalog.Received(1).DeleteAsync();
        }
    }
}