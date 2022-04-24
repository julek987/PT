using Data.API;
using Xunit;
namespace TestProject1;

public class TestCatalog : ICatalog
{
    public TestCatalog(string id, string title, string author)
    {
        Id = id;
        Title = title;
        Author = author;
    }

    public string Title { get; set; }
    public string Author { get; set; }
    public string Id { get; set; }
}

public class DataTests
{
    [Fact]
        public void TestAddCatalog()
        {
            var datarepo = IDataRepository.CreateDataRepository();
            datarepo.AddCatalog(new TestCatalog("1","'Harry Potter", "J. K. Rowling" ));
            Assert.True(datarepo.CatalogExists("1"));
        }
    }