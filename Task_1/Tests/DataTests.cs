using Data.API;
using Xunit;
namespace Data.Tests;

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
public class TestUsers : IUsers
{
    public TestUsers(string id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Id { get; set; }
}

public class DataTests
{
    //Catalogs
    [Fact]
        public void TestAddCatalog()
        {
            var datarepo = IDataRepository.CreateDataRepository();
            datarepo.AddCatalog(new TestCatalog("1","'Harry Potter", "J. K. Rowling" ));
            Assert.True(datarepo.CatalogExists("1"));
        }
        
   [Fact]
        public void TestDeleteCatalog()
        {
            var datarepo = IDataRepository.CreateDataRepository();
            datarepo.DeleteCatalog(new TestCatalog("1", "'Harry Potter", "J. K. Rowling"));
            Assert.True(datarepo.CatalogExists("0"));
        }
          
    //Users
    [Fact]
        public void TestAddUser()
        {
            var datarepo = IDataRepository.CreateDataRepository();
            datarepo.AddUser(new TestUsers("1", "Jola","Kowalska"));
            Assert.True(datarepo.UserExists("1"));
        }
    [Fact]
        public void TestDeleteUser()
        {
            var datarepo = IDataRepository.CreateDataRepository();
            datarepo.DeleteUser(new TestUsers("1", "Jola", "Kowalska"));
            Assert.True(datarepo.UserExists("0"));
        }
    //State
    //Event
}
