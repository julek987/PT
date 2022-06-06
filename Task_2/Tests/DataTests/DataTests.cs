using Xunit;
using Data.API;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Tests.DataTests
{
    public class DataTests
    {
        
        private IDataContext context;

        public DataTests()
        {
            context = IDataContext.CreateContext();
        }

        [Fact]
        public async Task TestConnection()
        {
           const string Id = "1";
           CatalogTest catalog = new CatalogTest("Harry Potter", "J.K. Rowling", Id);
           await context.AddCatalogAsync(catalog);
           ICatalog result = context.Catalogs.Where(c => c.Id == Id).First();
           Assert.Equal("Harry Potter", result.Title);
           await context.DeleteCatalogAsync(Id);
        }

        [Fact]
        public async Task TestDelete()
        {
            const string Id = "1";
            CatalogTest catalog = new CatalogTest("Harry Potter", "J.K. Rowling", Id);
            await context.AddCatalogAsync(catalog);
            await context.DeleteCatalogAsync(Id);
            IEnumerable<ICatalog> results = context.Catalogs.ToList();
            Assert.False(results.Any());
        }

    }
}
