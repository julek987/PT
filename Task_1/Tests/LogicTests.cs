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
            var logic = IBusinessLogic.CreateLogic(data);
            logic.BorrowBook("1","1");
            Assert.Throws<InvalidOperationException>(()=> logic.BorrowBook("2","1"));
            
        }
        [Fact]
        public void TestReturn()
        {
            var data = IDataRepository.CreateDataRepository();
            IUsers user = new Users("1", "Will", "Smith");
            IUsers user2 = new Users("2", "Will2", "Smith2");
            data.AddUser(user);
            ICatalog catalog = new Catalog("1", "Harry Potter", "J. K. Rowling");
            data.AddCatalog(catalog);
            IState state = new State("1", catalog);
            data.AddState(state);
            var logic = IBusinessLogic.CreateLogic(data);
            logic.BorrowBook("1","1");
            Assert.Throws<InvalidOperationException>(()=> logic.BorrowBook("2","1"));
            logic.ReturnBook("1", "1");
            Assert.Throws<InvalidOperationException>(() => logic.ReturnBook("2", "1"));
        }
    }
}