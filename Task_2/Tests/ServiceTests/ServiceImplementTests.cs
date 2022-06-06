using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Data.API;
using Data.Implementation;
//using NSubstitute;
//using NSubstitute.ReturnsExtensions;


namespace Tests.ServiceTests
{
    public class ServiceImplementTests
    {
        /*
        private readonly Data.API.ICatalog _catalog;
        private readonly Data.API.IUsers _user;
        private readonly Data.API.IDataRepository _datarepository;
        private readonly Data.API.IState _state;
        private readonly Data.API.IReturn _return;
        private readonly Data.API.IRent _rent;
        private readonly IDataContext _datacontext;
        /* substitute for not working, also what do we need here?
        public ServiceImplementTests()
        {
            _catalog = Substitute.For<ICatalog>();
            _user = Substitute.For<IUsers>();
            _datarepository = Substitute.For<IDataRepository>();
            _state = Substitute.For<IState>();
            _return = Substitute.For<IReturn>();
            _rent = Substitute.For<IRent>();
            _datacontext = new DataContext();
        }
        */
        /*
        //Users tests
        [Fact]
        public void UsersAddTest()
        {
            (await _datacontext.AddAsync()).Count().Should().Be(0);
            await _repository.CreateAsync(new User("user_1", "A", "B"));
            (await _repository.GetAllAsync()).Count().Should().Be(1);
        }
        [Fact]
        public async Task Delete_ShouldRemoveUser_IfSuchExists()
        {
            await _datacontext.AddUserAsync(new Users("user_1", "abd", "def"));
            Assert.True(1, )
            await _datacontext.DeleteUserAsync("user_1");
            
        }
        */
    }
}
