using NSubstitute;
using Service.API;
using Data.API;
using Service.Implementation;
using Service.Model;


namespace ServiceTests
{
    public class TestService
    {
        private readonly IDataContext dataContext;
        private readonly IService service;

        public TestService()
        {
            dataContext = Substitute.For<IDataContext>();
            service = new DataService(dataContext);
        }


        [Fact]
        public async Task AddUser()
        {
            IUsers user = new UsersModel(service, "Will", "Smith", "1");
            await service.AddUser(user);
            await dataContext.Received(1).AddUserAsync(Arg.Is<Data.IUsers>(user => user.Id == "1")) ; 
        }
    }
}