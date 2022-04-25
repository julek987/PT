using System;
using Data;
using Data.API;
using Data.Implementation;
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
            ICatalog testCatalog = new TestCatalog("1", "'Harry Potter", "J. K. Rowling");
            datarepo.AddCatalog(testCatalog);
            Assert.True(datarepo.CatalogExists("1"));
            ICatalog testCatalog2 = new Catalog("2", "'Harry Potter 2", "J. K. Rowling");
            datarepo.AddCatalog(testCatalog2);
            Assert.True(datarepo.CatalogExists("2"));
            Assert.False(datarepo.CatalogExists("3"));
            datarepo.DeleteCatalog(testCatalog);
            Assert.False(datarepo.CatalogExists("1"));
            datarepo.AddCatalog(testCatalog);
            Assert.True(datarepo.CatalogExists("1"));
            datarepo.DeleteCatalogWithId("1");
            Assert.False(datarepo.CatalogExists("1"));
        }

        [Fact]
        public void TestUser()
        {
            var datarepo = IDataRepository.CreateDataRepository();
            IUsers user = new Users("1", "Will", "Smith");
            datarepo.AddUser(user);
            Assert.True(datarepo.UserExists("1"));
            Assert.False(datarepo.UserExists("10"));
            datarepo.DeleteUser(user);
            Assert.False(datarepo.UserExists("1"));
            
            IUsers user2 = new Users("2", "Will2", "Smith");
            datarepo.AddUser(user);
            datarepo.AddUser(user2);
            Assert.True(datarepo.UserExists("2"));
            datarepo.DeleteUserWithId("2");
            Assert.False(datarepo.UserExists("2"));
            
        }

        [Fact]
        public void TestState()
        {
            var datarepo = IDataRepository.CreateDataRepository();
            ICatalog testcatalog = new TestCatalog("1","'Harry Potter", "J. K. Rowling" );
            IState teststate = new State("1", testcatalog);
            datarepo.AddState(teststate);
            Assert.True(datarepo.StateExists("1"));
            Assert.False(datarepo.StateExists("10"));
            datarepo.DeleteState(teststate);
            Assert.False(datarepo.StateExists("1"));
            IState teststate2 = new State("2", testcatalog);
            datarepo.AddState(teststate2);
            Assert.True(datarepo.StateExists("2"));
            datarepo.DeleteStateWithId("2");
            Assert.False(datarepo.StateExists("2"));
        }

        [Fact]
        public void TestUserWithEvent()
        {
            var datarepo = IDataRepository.CreateDataRepository();
            ICatalog testCatalog = new TestCatalog("1","'Harry Potter", "J. K. Rowling" );
            IState testState = new State("1", testCatalog);
            datarepo.AddState(testState);
            IUsers user = new Users("1", "Will", "Smith");
            datarepo.AddUser(user);
            IRent rentTest = new Rent("1", "1");
            datarepo.AddEvent(rentTest);
            Assert.Throws<Exception>(() => datarepo.DeleteUser(user));
            Assert.Throws<Exception>(() => datarepo.DeleteUserWithId("1"));
            IReturn returnTest = new Return("1", "1");
            datarepo.AddEvent(returnTest);
            datarepo.DeleteUser(user);
            Assert.False(datarepo.UserExists("1"));
        }

        [Fact]
        public void DeleteEventTest()
        {
            var datarepo = IDataRepository.CreateDataRepository();
            ICatalog testCatalog = new TestCatalog("1","'Harry Potter", "J. K. Rowling" );
            IState testState1 = new State("1", testCatalog);
            datarepo.AddState(testState1);
            IUsers user = new Users("1", "Will", "Smith");
            datarepo.AddUser(user);
            IRent toBeDeletedRent1 = new Rent("1", "1");
            datarepo.AddEvent(toBeDeletedRent1);
            Assert.Throws<Exception>(()=> datarepo.DeleteUser(user));
            datarepo.DeleteEvent(toBeDeletedRent1);
            datarepo.DeleteUser(user);
            Assert.False(datarepo.UserExists("1"));

        }
    }