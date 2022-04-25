using Logic.API;
using Xunit;
using System;
using Data;
using Data.API;
using Data.Implementation;
using Logic.Implementation;

namespace TestProject1
{
    public class LogicTests
    {
        [Fact]
        public void TestRent()
        {
            var data = IDataRepository.CreateDataRepository();
            IUsers user = new Users("1", "Will", "Smith");
            data.AddUser(user);
            ICatalog catalog = new Catalog("1", "Harry Potter", "J. K. Rowling");
            data.AddCatalog(catalog);
            IState state = new State("1", catalog);
            data.AddState(state);
            Assert.True(data.UserExists("1"));
            var logic = IBusinessLogic.CreateLogic(data);
            Assert.True(data.IsAvailable("1"));
            logic.BorrowBook("1","1");
            Assert.False(data.IsAvailable("1"));
            
        }
        [Fact]
        public void TestReturn()
        {
            var data = IDataRepository.CreateDataRepository();
            IUsers user = new Users("1", "Will", "Smith");
            data.AddUser(user);
            ICatalog catalog = new Catalog("1", "Harry Potter", "J. K. Rowling");
            data.AddCatalog(catalog);
            IState state = new State("1", catalog);
            data.AddState(state);
            Assert.True(data.UserExists("1"));
            var logic = IBusinessLogic.CreateLogic(data);
            Assert.True(data.IsAvailable("1"));
            logic.BorrowBook("1","1");
            Assert.False(data.IsAvailable("1"));
            logic.ReturnBook("1", "1");
            Assert.True(data.IsAvailable("1"));
        }
    }
}